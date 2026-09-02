using Polly.RateLimit;
using Polly.Retry;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text.Json;
using TelnyxSharp.Models;

namespace TelnyxSharp.Base
{
    /// <summary>
    /// A base class that provides common operations for interacting with Telnyx API endpoints.
    /// Handles API request execution, rate-limiting, and pagination.
    /// </summary>
    public abstract class BaseOperations
    {
        protected HttpClient Client { get; set; }
        protected AsyncRetryPolicy RateLimitRetryPolicy { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseOperations"/> class.
        /// </summary>
        protected BaseOperations() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseOperations"/> class with the specified client and rate limit retry policy.
        /// </summary>
        /// <param name="client">The <see cref="HttpClient"/> used for making API requests.</param>
        /// <param name="rateLimitRetryPolicy">The retry policy for rate-limiting.</param>
        protected BaseOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        {
            Client = client;
            RateLimitRetryPolicy = rateLimitRetryPolicy;
        }

        /// <summary>
        /// Executes an API request asynchronously and returns the response deserialized to the specified type.
        /// Handles rate-limiting, response deserialization, and pagination.
        /// </summary>
        /// <typeparam name="T">The type of the response model to deserialize into.</typeparam>
        /// <param name="request">The request builder to execute.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        /// <returns>A task representing the asynchronous operation, with a result of type <typeparamref name="T"/>.</returns>
        [UnconditionalSuppressMessage("Trimming", "IL2070",
            Justification = "Pagination reflects over Meta/Data on response types preserved by the source-gen context.")]
        [UnconditionalSuppressMessage("Trimming", "IL2075",
            Justification = "Pagination reflects over Meta/Data on response types preserved by the source-gen context.")]
        [UnconditionalSuppressMessage("AOT", "IL3050",
            Justification = "Pagination builds a List<> for the response's data element type; element types are concrete and preserved.")]
        protected async Task<T> ExecuteAsync<T>(TelnyxRequest request, CancellationToken cancellationToken = default)
            where T : ITelnyxResponse, new()
        {
            return await RateLimitRetryPolicy.ExecuteAsync(async () =>
            {
                // Add a unique correlation ID header for tracking.
                request.AddOrUpdateHeader("X-Correlation-ID", Guid.NewGuid());

                using var requestMessage = request.BuildHttpRequestMessage();
                var response = await Client.SendAsync(requestMessage, cancellationToken);
                var content = await response.Content.ReadAsStringAsync(cancellationToken);

                // Initialize the result with the response's basic status information.
                // ErrorMessage is left null on HTTP error status (matching RestSharp): the
                // deserialized Errors[] carries detail.
                var result = new T
                {
                    StatusCode = response.StatusCode,
                    IsSuccessful = response.IsSuccessStatusCode,
                    ErrorMessage = null
                };

                // Handle rate-limiting by checking for 429 Too Many Requests status.
                if (response.StatusCode == HttpStatusCode.TooManyRequests)
                {
                    throw new RateLimitRejectedException(TimeSpan.FromSeconds(GetRateLimitResetSeconds(response)));
                }

                // If the response is successful and contains content, attempt to deserialize it.
                if (!response.IsSuccessStatusCode || string.IsNullOrEmpty(content))
                {
                    // Telnyx returns a JSON "errors" array on failure responses (e.g. 422
                    // validation errors). Deserialize it the same way the success path does, so
                    // callers see the underlying error(s) via Errors[] instead of only the
                    // synthetic "telnyx-command-failed" default. Reassigning `result` (rather than
                    // copying just the Errors property) matters: several response types redeclare
                    // Errors/Data/Meta to hide the ITelnyxResponse-inherited members, so a copy
                    // through the generic T reference would write the wrong (base) property.
                    if (!string.IsNullOrEmpty(content))
                    {
                        try
                        {
                            var errorResult = JsonSerializer.Deserialize<T>(content,
                                TelnyxJsonSerializerContext.Default.Options);

                            if (errorResult != null)
                            {
                                result = errorResult;
                                result.StatusCode = response.StatusCode;
                                result.IsSuccessful = response.IsSuccessStatusCode;
                                result.ErrorMessage = null;
                            }
                        }
                        catch (JsonException)
                        {
                            // Non-2xx body wasn't the expected JSON error envelope (e.g. an
                            // upstream gateway's HTML/plain-text error page). Keep the
                            // synthetic result already populated above.
                        }
                    }

                    return result;
                }

                var deserializedResult =
                    JsonSerializer.Deserialize<T>(content, TelnyxJsonSerializerContext.Default.Options);

                if (deserializedResult == null) return result;

                result = deserializedResult;
                result.StatusCode = response.StatusCode;
                result.IsSuccessful = response.IsSuccessStatusCode;
                result.ErrorMessage = null;

                // Handle pagination if the response includes paginated data.
                var pageParam = request.Parameters.FirstOrDefault(p => p.Name == "page[number]");
                var metaProperty = typeof(T).GetProperty("Meta");
                var dataProperty = typeof(T).GetProperty("Data");

                if (metaProperty?.GetValue(result) is not PaginationMeta meta || dataProperty == null ||
                    meta.PageNumber >= meta.TotalPages) return result;

                var dataType = dataProperty.PropertyType.GetGenericArguments()[0];
                var listType = typeof(List<>).MakeGenericType(dataType);
                var allData = (IList)Activator.CreateInstance(listType)!;

                if (dataProperty.GetValue(result) is IEnumerable initialData)
                    foreach (var item in initialData)
                        allData.Add(item);

                // Continue fetching pages if there are more.
                while (meta.PageNumber < meta.TotalPages)
                {
                    await RateLimitRetryPolicy.ExecuteAsync(async () =>
                    {
                        request.AddOrUpdateHeader("X-Correlation-ID", Guid.NewGuid());
                        request.RemoveParameter(pageParam);
                        request.AddParameter("page[number]", meta.PageNumber + 1);

                        using var pageMessage = request.BuildHttpRequestMessage();
                        response = await Client.SendAsync(pageMessage, cancellationToken);
                        content = await response.Content.ReadAsStringAsync(cancellationToken);

                        if (response.StatusCode != HttpStatusCode.TooManyRequests) return;

                        throw new RateLimitRejectedException(TimeSpan.FromSeconds(GetRateLimitResetSeconds(response)));
                    });

                    // If the response is not successful, break the loop.
                    if (!response.IsSuccessStatusCode || string.IsNullOrEmpty(content))
                    {
                        result.IsSuccessful = false;
                        result.StatusCode = response.StatusCode;
                        result.ErrorMessage = null;
                        break;
                    }

                    var nextResult = JsonSerializer.Deserialize<T>(content,
                        TelnyxJsonSerializerContext.Default.Options);
                    if (nextResult == null) break;

                    var nextData = dataProperty.GetValue(nextResult);
                    if (nextData is IEnumerable pageData)
                        foreach (var item in pageData)
                            allData.Add(item);

                    metaProperty.SetValue(result, metaProperty.GetValue(nextResult));
                    meta = (PaginationMeta)metaProperty.GetValue(result)!;
                    pageParam = request.Parameters.FirstOrDefault(p => p.Name == "page[number]");
                }

                dataProperty.SetValue(result, allData);
                return result;
            });
        }

        /// <summary>
        /// Reads the <c>x-ratelimit-reset</c> header (in seconds) from a response, defaulting to 1.
        /// </summary>
        private static int GetRateLimitResetSeconds(HttpResponseMessage response)
        {
            string? resetSeconds = null;
            if (response.Headers.TryGetValues("x-ratelimit-reset", out var values))
                resetSeconds = values.FirstOrDefault();

            return int.TryParse(resetSeconds, out var parsedDelay) ? parsedDelay : 1;
        }
    }
}
