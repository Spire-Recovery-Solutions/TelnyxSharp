using System.Net;
using System.Net.Http.Headers;
using System.Text;
using Polly;
using Polly.RateLimit;
using Polly.Retry;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Models.MessagingUrlDomain.Responses;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace TelnyxSharp.Tests
{
    /// <summary>
    /// Exercises the hand-written HTTP wire path introduced by the RestSharp -> HttpClient migration:
    /// <see cref="TelnyxRequest.BuildHttpRequestMessage"/> (query/method/body/multipart/header rules)
    /// and <see cref="BaseOperations.ExecuteAsync{T}"/> (send, deserialize, paginate, 429 retry).
    /// These tests assert the WIRE, not the parameter store, and run with no TELNYX_API_KEY.
    /// </summary>
    public sealed class WireProtocolTests
    {
        // ---------------------------------------------------------------------
        // Test infrastructure
        // ---------------------------------------------------------------------

        /// <summary>
        /// An <see cref="HttpMessageHandler"/> that returns canned responses from a queue and records
        /// every outgoing request (its URI string, method, and the message reference itself).
        /// </summary>
        private sealed class RecordingHandler : HttpMessageHandler
        {
            private readonly Queue<Func<HttpResponseMessage>> _responses;

            public List<HttpRequestMessage> SentMessages { get; } = new();
            public List<string> SentUris { get; } = new();
            public List<HttpMethod> SentMethods { get; } = new();

            public RecordingHandler(params Func<HttpResponseMessage>[] responses)
            {
                _responses = new Queue<Func<HttpResponseMessage>>(responses);
            }

            protected override Task<HttpResponseMessage> SendAsync(
                HttpRequestMessage request, CancellationToken cancellationToken)
            {
                // Capture at call time: ExecuteAsync wraps the message in `using`, so it is disposed
                // once the call returns. Read the URI/method now.
                SentMessages.Add(request);
                SentUris.Add(request.RequestUri!.ToString());
                SentMethods.Add(request.Method);

                var factory = _responses.Count > 0
                    ? _responses.Dequeue()
                    : throw new InvalidOperationException("RecordingHandler ran out of canned responses.");
                return Task.FromResult(factory());
            }
        }

        private static HttpResponseMessage Json(HttpStatusCode status, string body)
            => new(status)
            {
                Content = new StringContent(body, Encoding.UTF8, "application/json")
            };

        /// <summary>A 429 response carrying <c>x-ratelimit-reset: 0</c> so the retry incurs no real delay.</summary>
        private static HttpResponseMessage TooManyRequests()
        {
            var response = new HttpResponseMessage(HttpStatusCode.TooManyRequests)
            {
                Content = new StringContent(string.Empty)
            };
            response.Headers.TryAddWithoutValidation("x-ratelimit-reset", "0");
            return response;
        }

        /// <summary>A test operation that exposes the protected <see cref="BaseOperations.ExecuteAsync{T}"/>.</summary>
        private sealed class TestOperations : BaseOperations
        {
            public TestOperations(HttpClient client, AsyncRetryPolicy policy) : base(client, policy) { }

            public Task<T> Run<T>(TelnyxRequest request, CancellationToken ct = default)
                where T : ITelnyxResponse, new()
                => ExecuteAsync<T>(request, ct);
        }

        private static HttpClient ClientWith(RecordingHandler handler)
            => new(handler) { BaseAddress = new Uri("https://api.telnyx.com/v2/") };

        /// <summary>A pass-through policy for the happy/pagination paths (no exception is thrown on 200s).</summary>
        private static AsyncRetryPolicy NoRetryPolicy()
            => Policy.Handle<RateLimitRejectedException>().RetryAsync(0);

        /// <summary>A retry policy that retries 429s once with zero delay (avoids real x-ratelimit-reset waits).</summary>
        private static AsyncRetryPolicy ZeroDelayRetryPolicy()
            => Policy.Handle<RateLimitRejectedException>().WaitAndRetryAsync(1, _ => TimeSpan.Zero);

        private static string Page(int pageNumber, int totalPages, params string[] ids)
        {
            var data = string.Join(",", ids.Select(id =>
                $"{{\"record_type\":\"messaging_url_domain\",\"id\":\"{id}\",\"url_domain\":\"{id}.example.com\",\"use_case\":\"marketing\"}}"));
            return $"{{\"data\":[{data}],\"meta\":{{\"total_pages\":{totalPages},\"total_results\":4,\"page_number\":{pageNumber},\"page_size\":2}}}}";
        }

        // =====================================================================
        // A) BuildHttpRequestMessage  (public — call directly, no mock needed)
        // =====================================================================

        [Test]
        public async Task BuildHttpRequestMessage_AssemblesEncodedQueryWithBracketedAndPaginationKeys()
        {
            var request = new TelnyxRequest("messaging_url_domains")
                .AddFilter("filter[phone_number]", "+15551234567")
                .AddPagination(50);

            var message = request.BuildHttpRequestMessage();

            // RequestUri is RELATIVE here; .Query/.AbsoluteUri would throw. Assert on the raw string.
            var uri = message.RequestUri!.OriginalString;

            // Bracketed key + '+' value are percent-encoded by Uri.EscapeDataString.
            await Assert.That(uri).Contains("filter%5Bphone_number%5D=%2B15551234567");
            await Assert.That(uri).Contains("page%5Bsize%5D=50");
            await Assert.That(uri).Contains("page%5Bnumber%5D=1");
            await Assert.That(uri).StartsWith("messaging_url_domains?");
        }

        [Test]
        [Arguments(TelnyxMethod.Get, "GET")]
        [Arguments(TelnyxMethod.Post, "POST")]
        [Arguments(TelnyxMethod.Put, "PUT")]
        [Arguments(TelnyxMethod.Patch, "PATCH")]
        [Arguments(TelnyxMethod.Delete, "DELETE")]
        public async Task BuildHttpRequestMessage_MapsMethod(TelnyxMethod method, string expected)
        {
            var message = new TelnyxRequest("x", method).BuildHttpRequestMessage();
            await Assert.That(message.Method.Method).IsEqualTo(expected);
        }

        [Test]
        public async Task BuildHttpRequestMessage_JsonBody_SetsApplicationJsonAndRoundTrips()
        {
            const string body = "{\"a\":1}";
            var request = new TelnyxRequest("x", TelnyxMethod.Post).AddJsonBody(body);

            var message = request.BuildHttpRequestMessage();

            await Assert.That(message.Content).IsNotNull();
            await Assert.That(message.Content!.Headers.ContentType!.MediaType).IsEqualTo("application/json");
            var roundTripped = await message.Content.ReadAsStringAsync();
            await Assert.That(roundTripped).IsEqualTo(body);
        }

        [Test]
        public async Task BuildHttpRequestMessage_WithFile_ProducesMultipartWithFilePartAndFormField()
        {
            var bytes = Encoding.UTF8.GetBytes("%PDF-1.4 fake");
            var request = new TelnyxRequest("documents", TelnyxMethod.Post)
                .AddFile("file", bytes, "doc.pdf")
                .AddParameter("customer_reference", "abc");

            var message = request.BuildHttpRequestMessage();

            await Assert.That(message.Content).IsTypeOf<MultipartFormDataContent>();
            await Assert.That(message.Content!.Headers.ContentType!.MediaType).IsEqualTo("multipart/form-data");

            var multipart = (MultipartFormDataContent)message.Content;
            var parts = multipart.ToList();

            // File part: name="file", filename="doc.pdf", payload round-trips.
            var filePart = parts.Single(p => p.Headers.ContentDisposition!.Name!.Trim('"') == "file");
            await Assert.That(filePart.Headers.ContentDisposition!.FileName!.Trim('"')).IsEqualTo("doc.pdf");
            await Assert.That(await filePart.ReadAsStringAsync()).IsEqualTo("%PDF-1.4 fake");

            // Non-query GetOrPost parameter becomes a form field (it is NOT placed on the query string).
            var formField = parts.Single(p => p.Headers.ContentDisposition!.Name!.Trim('"') == "customer_reference");
            await Assert.That(await formField.ReadAsStringAsync()).IsEqualTo("abc");

            // And nothing leaked into the query string when a file is present.
            await Assert.That(message.RequestUri!.OriginalString).IsEqualTo("documents");
        }

        [Test]
        public async Task BuildHttpRequestMessage_ContentTypeHeader_IsOwnedByContentNotAddedAsRequestHeader()
        {
            var request = new TelnyxRequest("x", TelnyxMethod.Post)
                .AddJsonBody("{\"a\":1}")
                .AddHeader("Content-Type", "multipart/form-data");

            // Must not throw (adding Content-Type to HttpRequestMessage.Headers would).
            var message = request.BuildHttpRequestMessage();

            // The request-level headers must NOT carry Content-Type. Note: HttpRequestHeaders.Contains
            // ("Content-Type") itself throws (it is a content header), so enumerate the request headers
            // instead — that is the very BCL constraint the production skip-rule exists to respect.
            var requestHeaderNames = message.Headers.Select(h => h.Key).ToList();
            await Assert.That(requestHeaderNames.Any(n =>
                string.Equals(n, "Content-Type", StringComparison.OrdinalIgnoreCase))).IsFalse();
            // ...and the content keeps its own (json), undisturbed by the ignored header.
            await Assert.That(message.Content!.Headers.ContentType!.MediaType).IsEqualTo("application/json");
        }

        // =====================================================================
        // B) ExecuteAsync via a mocked HttpMessageHandler
        // =====================================================================

        [Test]
        public async Task ExecuteAsync_SendsCorrectRelativeUriQueryAndMethodToHandler()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK, Page(1, 1, "a", "b")));
            using var client = ClientWith(handler);
            var ops = new TestOperations(client, NoRetryPolicy());

            var request = new TelnyxRequest("messaging_url_domains")
                .AddFilter("filter[record_type]", "messaging_url_domain")
                .AddPagination(2);

            var result = await ops.Run<ListMessagingUrlDomainsResponse>(request);

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Get);
            var uri = handler.SentUris.Single();
            await Assert.That(uri).StartsWith("https://api.telnyx.com/v2/messaging_url_domains?");
            await Assert.That(uri).Contains("filter%5Brecord_type%5D=messaging_url_domain");
            await Assert.That(uri).Contains("page%5Bsize%5D=2");
            await Assert.That(uri).Contains("page%5Bnumber%5D=1");

            // Sanity: deserialization populated Meta + Data (else pagination tests would pass for the wrong reason).
            await Assert.That(result.IsSuccessful).IsTrue();
            await Assert.That(result.Meta).IsNotNull();
            await Assert.That(result.Data!.Count).IsEqualTo(2);
        }

        [Test]
        public async Task ExecuteAsync_Paginates_RebuildsFreshMessagePerPageAndAggregatesData()
        {
            // Page 1 says total_pages=2; page 2 is the final page.
            var handler = new RecordingHandler(
                () => Json(HttpStatusCode.OK, Page(1, 2, "a", "b")),
                () => Json(HttpStatusCode.OK, Page(2, 2, "c", "d")));
            using var client = ClientWith(handler);
            var ops = new TestOperations(client, NoRetryPolicy());

            var request = new TelnyxRequest("messaging_url_domains").AddPagination(2);

            var result = await ops.Run<ListMessagingUrlDomainsResponse>(request);

            // Exactly two sends.
            await Assert.That(handler.SentMessages.Count).IsEqualTo(2);

            // Each send used a FRESH HttpRequestMessage (highest-risk behavior: a reused message would throw).
            await Assert.That(ReferenceEquals(handler.SentMessages[0], handler.SentMessages[1])).IsFalse();

            // First page requests page[number]=1, second page requests page[number]=2.
            await Assert.That(handler.SentUris[0]).Contains("page%5Bnumber%5D=1");
            await Assert.That(handler.SentUris[1]).Contains("page%5Bnumber%5D=2");

            // Aggregated Data contains items from BOTH pages, in order.
            await Assert.That(result.Data!.Count).IsEqualTo(4);
            await Assert.That(result.Data!.Select(d => d.Id).ToList())
                .IsEquivalentTo(new[] { "a", "b", "c", "d" });
        }

        [Test]
        public async Task ExecuteAsync_429ThenSuccess_RetriesAndSucceeds()
        {
            // First send is throttled (429), retry succeeds. ZeroDelayRetryPolicy avoids real waits.
            var handler = new RecordingHandler(
                () => TooManyRequests(),
                () => Json(HttpStatusCode.OK, Page(1, 1, "a", "b")));
            using var client = ClientWith(handler);
            var ops = new TestOperations(client, ZeroDelayRetryPolicy());

            var request = new TelnyxRequest("messaging_url_domains").AddPagination(2);

            var result = await ops.Run<ListMessagingUrlDomainsResponse>(request);

            await Assert.That(handler.SentMessages.Count).IsEqualTo(2);
            await Assert.That(result.IsSuccessful).IsTrue();
            await Assert.That(result.StatusCode).IsEqualTo(HttpStatusCode.OK);
            await Assert.That(result.Data!.Count).IsEqualTo(2);
        }
    }
}
