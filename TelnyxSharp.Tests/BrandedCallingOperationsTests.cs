using System.Net;
using System.Text;
using System.Text.Json;
using Polly;
using Polly.RateLimit;
using Polly.Retry;
using TelnyxSharp.BrandedCalling.Models.Comments.Requests;
using TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Requests;
using TelnyxSharp.BrandedCalling.Models.Enterprises;
using TelnyxSharp.BrandedCalling.Models.Enterprises.Requests;
using TelnyxSharp.BrandedCalling.Models.InfringementClaims.Requests;
using TelnyxSharp.BrandedCalling.Models.PhoneNumberBatches.Requests;
using TelnyxSharp.BrandedCalling.Models.PhoneNumbers.Requests;
using TelnyxSharp.BrandedCalling.Models.ReferenceData.Requests;
using TelnyxSharp.BrandedCalling.Models;
using TelnyxSharp.BrandedCalling.Operations;
using TelnyxSharp.Enums;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace TelnyxSharp.Tests
{
    /// <summary>
    /// Exercises the Branded Calling operations over a mocked <see cref="HttpMessageHandler"/>:
    /// URL/method correctness, request body serialization (snake_case, enums, bare-array bodies),
    /// and response deserialization for representative operations in each tag group.
    /// These tests run with no TELNYX_API_KEY.
    /// </summary>
    public sealed class BrandedCallingOperationsTests
    {
        // ---------------------------------------------------------------------
        // Test infrastructure
        // ---------------------------------------------------------------------

        /// <summary>
        /// An <see cref="HttpMessageHandler"/> that returns canned responses from a queue and records
        /// every outgoing request's URI, method, and body (captured at send time, before disposal).
        /// </summary>
        private sealed class RecordingHandler : HttpMessageHandler
        {
            private readonly Queue<Func<HttpResponseMessage>> _responses;

            public List<string> SentUris { get; } = new();
            public List<HttpMethod> SentMethods { get; } = new();
            public List<string?> SentBodies { get; } = new();

            public RecordingHandler(params Func<HttpResponseMessage>[] responses)
            {
                _responses = new Queue<Func<HttpResponseMessage>>(responses);
            }

            protected override async Task<HttpResponseMessage> SendAsync(
                HttpRequestMessage request, CancellationToken cancellationToken)
            {
                SentUris.Add(request.RequestUri!.ToString());
                SentMethods.Add(request.Method);
                SentBodies.Add(request.Content == null
                    ? null
                    : await request.Content.ReadAsStringAsync(cancellationToken));

                var factory = _responses.Count > 0
                    ? _responses.Dequeue()
                    : throw new InvalidOperationException("RecordingHandler ran out of canned responses.");
                return factory();
            }
        }

        private static HttpResponseMessage Json(HttpStatusCode status, string body)
            => new(status)
            {
                Content = new StringContent(body, Encoding.UTF8, "application/json")
            };

        private static HttpResponseMessage NoContent()
            => new(HttpStatusCode.NoContent) { Content = new StringContent(string.Empty) };

        private static HttpClient ClientWith(RecordingHandler handler)
            => new(handler) { BaseAddress = new Uri("https://api.telnyx.com/v2/") };

        private static AsyncRetryPolicy NoRetryPolicy()
            => Policy.Handle<RateLimitRejectedException>().RetryAsync(0);

        private static string SinglePageMeta()
            => "\"meta\":{\"total_pages\":1,\"total_results\":1,\"page_number\":1,\"page_size\":20}";

        // =====================================================================
        // Enterprises
        // =====================================================================

        [Test]
        public async Task Enterprises_List_SendsFilterAndPagination_AndDeserializes()
        {
            var body = $"{{\"data\":[{{\"id\":\"ent-1\",\"legal_name\":\"Acme Plumbing LLC\",\"branded_calling_enabled\":true}}],{SinglePageMeta()}}}";
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK, body));
            using var client = ClientWith(handler);
            var ops = new EnterpriseOperations(client, NoRetryPolicy());

            var result = await ops.List(new ListEnterprisesRequest { LegalName = "Acme", PageSize = 20 });

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Get);
            var uri = handler.SentUris.Single();
            await Assert.That(uri).StartsWith("https://api.telnyx.com/v2/enterprises?");
            await Assert.That(uri).Contains("filter%5Blegal_name%5D%5Bcontains%5D=Acme");
            await Assert.That(uri).Contains("page%5Bsize%5D=20");
            await Assert.That(uri).Contains("page%5Bnumber%5D=1");

            await Assert.That(result.IsSuccessful).IsTrue();
            await Assert.That(result.Data!.Count).IsEqualTo(1);
            await Assert.That(result.Data![0].Id).IsEqualTo("ent-1");
            await Assert.That(result.Data![0].LegalName).IsEqualTo("Acme Plumbing LLC");
            await Assert.That(result.Data![0].BrandedCallingEnabled).IsEqualTo(true);
            await Assert.That(result.Meta!.TotalResults).IsEqualTo(1);
        }

        [Test]
        public async Task Enterprises_Create_PostsSnakeCaseBody_AndDeserializes()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.Created,
                "{\"data\":{\"id\":\"ent-1\",\"legal_name\":\"Acme Plumbing LLC\",\"country_code\":\"US\"}}"));
            using var client = ClientWith(handler);
            var ops = new EnterpriseOperations(client, NoRetryPolicy());

            var result = await ops.Create(new CreateEnterpriseRequest
            {
                LegalName = "Acme Plumbing LLC",
                OrganizationType = "commercial",
                CountryCode = "US",
                OrganizationContact = new OrganizationContact
                {
                    FirstName = "Sam",
                    Email = "sam@acmeplumbing.example.com",
                    PhoneNumber = "+13125550000"
                },
                OrganizationPhysicalAddress = new PhysicalAddress
                {
                    Country = "US",
                    City = "Chicago",
                    StreetAddress = "100 Main St"
                }
            });

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Post);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/enterprises");

            using var sent = JsonDocument.Parse(handler.SentBodies.Single()!);
            await Assert.That(sent.RootElement.GetProperty("legal_name").GetString()).IsEqualTo("Acme Plumbing LLC");
            await Assert.That(sent.RootElement.GetProperty("organization_type").GetString()).IsEqualTo("commercial");
            await Assert.That(sent.RootElement.GetProperty("organization_contact").GetProperty("first_name").GetString()).IsEqualTo("Sam");
            await Assert.That(sent.RootElement.GetProperty("organization_physical_address").GetProperty("street_address").GetString()).IsEqualTo("100 Main St");
            // Null optional fields are omitted (WhenWritingNull).
            await Assert.That(sent.RootElement.TryGetProperty("dun_bradstreet_number", out _)).IsFalse();

            await Assert.That(result.IsSuccessful).IsTrue();
            await Assert.That(result.Data!.Id).IsEqualTo("ent-1");
        }

        [Test]
        public async Task Enterprises_Delete_SendsDelete_AndHandles204()
        {
            var handler = new RecordingHandler(NoContent);
            using var client = ClientWith(handler);
            var ops = new EnterpriseOperations(client, NoRetryPolicy());

            var result = await ops.Delete("ent-1");

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Delete);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/enterprises/ent-1");
            await Assert.That(result.IsSuccessful).IsTrue();
            await Assert.That(result.StatusCode).IsEqualTo(HttpStatusCode.NoContent);
        }

        [Test]
        public async Task Enterprises_ActivateBrandedCalling_PostsToActivationUrl()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK,
                "{\"data\":{\"id\":\"ent-1\",\"branded_calling_enabled\":true}}"));
            using var client = ClientWith(handler);
            var ops = new EnterpriseOperations(client, NoRetryPolicy());

            var result = await ops.ActivateBrandedCalling("ent-1");

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Post);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/enterprises/ent-1/branded_calling");
            await Assert.That(result.Data!.BrandedCallingEnabled).IsEqualTo(true);
        }

        // =====================================================================
        // Display Identity Records
        // =====================================================================

        [Test]
        public async Task Dirs_List_SendsEnumStatusFilterAsSnakeCase()
        {
            var body = $"{{\"data\":[{{\"id\":\"dir-1\",\"display_name\":\"Acme Plumbing\",\"status\":\"in_review\"}}],{SinglePageMeta()}}}";
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK, body));
            using var client = ClientWith(handler);
            var ops = new DisplayIdentityRecordsOperations(client, NoRetryPolicy());

            var result = await ops.List(new ListDirsRequest
            {
                Status = DirStatus.InReview,
                EnterpriseId = "ent-1",
                DisplayNameContains = "Acme"
            });

            var uri = handler.SentUris.Single();
            await Assert.That(uri).StartsWith("https://api.telnyx.com/v2/dir?");
            await Assert.That(uri).Contains("filter%5Bstatus%5D=in_review");
            await Assert.That(uri).Contains("filter%5Benterprise_id%5D=ent-1");
            await Assert.That(uri).Contains("filter%5Bdisplay_name%5D%5Bcontains%5D=Acme");

            await Assert.That(result.Data!.Single().Status).IsEqualTo(DirStatus.InReview);
        }

        [Test]
        public async Task Dirs_Create_PostsToEnterpriseScopedUrl_WithCertifications()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.Created,
                "{\"data\":{\"id\":\"dir-1\",\"enterprise_id\":\"ent-1\",\"display_name\":\"Acme Plumbing\",\"status\":\"draft\"}}"));
            using var client = ClientWith(handler);
            var ops = new DisplayIdentityRecordsOperations(client, NoRetryPolicy());

            var result = await ops.Create("ent-1", new CreateDirRequest
            {
                DisplayName = "Acme Plumbing",
                CertifyBrandIsAccurate = true,
                CertifyNoShaftContent = true,
                CertifyIpOwnership = true,
                AuthorizerName = "Sam Owner",
                AuthorizerEmail = "sam@acmeplumbing.example.com",
                CallReasons = new List<string> { "Appointment reminders" },
                Documents = new List<DirDocument>
                {
                    new() { DocumentId = "doc-1", DocumentType = "business_registration" }
                }
            });

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Post);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/enterprises/ent-1/dir");

            using var sent = JsonDocument.Parse(handler.SentBodies.Single()!);
            await Assert.That(sent.RootElement.GetProperty("display_name").GetString()).IsEqualTo("Acme Plumbing");
            await Assert.That(sent.RootElement.GetProperty("certify_brand_is_accurate").GetBoolean()).IsTrue();
            await Assert.That(sent.RootElement.GetProperty("certify_no_shaft_content").GetBoolean()).IsTrue();
            await Assert.That(sent.RootElement.GetProperty("certify_ip_ownership").GetBoolean()).IsTrue();
            await Assert.That(sent.RootElement.GetProperty("call_reasons")[0].GetString()).IsEqualTo("Appointment reminders");
            await Assert.That(sent.RootElement.GetProperty("documents")[0].GetProperty("document_type").GetString()).IsEqualTo("business_registration");

            await Assert.That(result.Data!.Status).IsEqualTo(DirStatus.Draft);
        }

        [Test]
        public async Task Dirs_Update_SendsPatchToDirUrl()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK,
                "{\"data\":{\"id\":\"dir-1\",\"display_name\":\"New Name\",\"status\":\"draft\"}}"));
            using var client = ClientWith(handler);
            var ops = new DisplayIdentityRecordsOperations(client, NoRetryPolicy());

            var result = await ops.Update("dir-1", new UpdateDirRequest { DisplayName = "New Name" });

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Patch);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/dir/dir-1");

            using var sent = JsonDocument.Parse(handler.SentBodies.Single()!);
            await Assert.That(sent.RootElement.GetProperty("display_name").GetString()).IsEqualTo("New Name");
            // Unset optional certifications must be omitted, not sent as null/false.
            await Assert.That(sent.RootElement.TryGetProperty("certify_brand_is_accurate", out _)).IsFalse();

            await Assert.That(result.Data!.DisplayName).IsEqualTo("New Name");
        }

        [Test]
        public async Task Dirs_Submit_PostsToSubmitUrl_AndDeserializesDir()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK,
                "{\"data\":{\"id\":\"dir-1\",\"status\":\"submitted\",\"submitted_at\":\"2026-04-26T18:07:03.716411Z\"}}"));
            using var client = ClientWith(handler);
            var ops = new DisplayIdentityRecordsOperations(client, NoRetryPolicy());

            var result = await ops.Submit("dir-1");

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Post);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/dir/dir-1/submit");
            await Assert.That(handler.SentBodies.Single()).IsNull();
            await Assert.That(result.Data!.Status).IsEqualTo(DirStatus.Submitted);
        }

        [Test]
        public async Task Dirs_RenderLoa_PostsBody_AndReturnsPdfBytes()
        {
            var pdfBytes = Encoding.ASCII.GetBytes("%PDF-1.4 fake-loa");
            var handler = new RecordingHandler(() =>
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent(pdfBytes)
                };
                response.Content.Headers.ContentType = new("application/pdf");
                return response;
            });
            using var client = ClientWith(handler);
            var ops = new DisplayIdentityRecordsOperations(client, NoRetryPolicy());

            var result = await ops.RenderLoa("dir-1", new RenderDirLoaRequest
            {
                PhoneNumbers = new List<string> { "+13125550000" },
                Signature = new LoaSignature { ImageBase64 = "aWcK", SignerName = "Sam Owner" }
            });

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Post);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/dir/dir-1/loa");

            using var sent = JsonDocument.Parse(handler.SentBodies.Single()!);
            await Assert.That(sent.RootElement.GetProperty("phone_numbers")[0].GetString()).IsEqualTo("+13125550000");
            await Assert.That(sent.RootElement.GetProperty("signature").GetProperty("signer_name").GetString()).IsEqualTo("Sam Owner");

            await Assert.That(result.IsSuccessful).IsTrue();
            await Assert.That(result.Content).IsEquivalentTo(pdfBytes);
        }

        // =====================================================================
        // Phone Numbers
        // =====================================================================

        [Test]
        public async Task PhoneNumbers_List_SendsStatusAsPlainQueryParameter()
        {
            var body = $"{{\"data\":[{{\"id\":\"pn-1\",\"phone_number\":\"+19493253498\",\"status\":\"verified\"}}],{SinglePageMeta()}}}";
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK, body));
            using var client = ClientWith(handler);
            var ops = new DirPhoneNumberOperations(client, NoRetryPolicy());

            var result = await ops.List("dir-1", new ListDirPhoneNumbersRequest
            {
                Status = DirPhoneNumberStatus.Verified
            });

            var uri = handler.SentUris.Single();
            await Assert.That(uri).StartsWith("https://api.telnyx.com/v2/dir/dir-1/phone_numbers?");
            await Assert.That(uri).Contains("status=verified");
            await Assert.That(result.Data!.Single().Status).IsEqualTo(DirPhoneNumberStatus.Verified);
        }

        [Test]
        public async Task PhoneNumbers_Add_PostsNumbersAndDocuments_AndDeserializesBatch()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.Created,
                "{\"data\":[{\"id\":\"pn-1\",\"phone_number\":\"+19493253498\",\"batch_id\":\"batch-1\",\"status\":\"submitted\"}]}"));
            using var client = ClientWith(handler);
            var ops = new DirPhoneNumberOperations(client, NoRetryPolicy());

            var result = await ops.Add("dir-1", new AddDirPhoneNumbersRequest
            {
                PhoneNumbers = new List<string> { "+19493253498" },
                Documents = new List<DirDocument>
                {
                    new() { DocumentId = "doc-1", DocumentType = "letter_of_authorization" }
                }
            });

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Post);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/dir/dir-1/phone_numbers");

            using var sent = JsonDocument.Parse(handler.SentBodies.Single()!);
            await Assert.That(sent.RootElement.GetProperty("phone_numbers")[0].GetString()).IsEqualTo("+19493253498");
            await Assert.That(sent.RootElement.GetProperty("documents")[0].GetProperty("document_type").GetString()).IsEqualTo("letter_of_authorization");

            await Assert.That(result.Data!.Single().BatchId).IsEqualTo("batch-1");
        }

        [Test]
        public async Task PhoneNumbers_Delete_SendsBody_AndParsesPerNumberErrors()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK,
                "{\"data\":[\"+19493253498\"],\"meta\":{\"errors\":[{\"phone_number\":\"+15555550000\",\"code\":\"not_associated\",\"title\":\"Phone number not associated\",\"detail\":\"Phone number not associated with this DIR.\"}]}}"));
            using var client = ClientWith(handler);
            var ops = new DirPhoneNumberOperations(client, NoRetryPolicy());

            var result = await ops.Delete("dir-1", new DeleteDirPhoneNumbersRequest
            {
                PhoneNumbers = new List<string> { "+19493253498", "+15555550000" }
            });

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Delete);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/dir/dir-1/phone_numbers");

            using var sent = JsonDocument.Parse(handler.SentBodies.Single()!);
            await Assert.That(sent.RootElement.GetProperty("phone_numbers").GetArrayLength()).IsEqualTo(2);

            await Assert.That(result.Data!.Single()).IsEqualTo("+19493253498");
            await Assert.That(result.Meta!.Errors!.Single().Code).IsEqualTo("not_associated");
        }

        // =====================================================================
        // Phone Number Batches
        // =====================================================================

        [Test]
        public async Task PhoneNumberBatches_Retrieve_SendsGetToBatchUrl_AndDeserializes()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK,
                "{\"data\":{\"batch_id\":\"batch-1\",\"dir_id\":\"dir-1\",\"status\":\"in_review\",\"total_count\":2,\"phone_numbers\":[{\"phone_number\":\"+19493253498\",\"status\":\"in_review\"},{\"phone_number\":\"+19493253499\",\"status\":\"in_review\"}]}}"));
            using var client = ClientWith(handler);
            var ops = new DirPhoneNumberBatchOperations(client, NoRetryPolicy());

            var result = await ops.Retrieve("dir-1", "batch-1");

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Get);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/dir/dir-1/phone_number_batches/batch-1");
            await Assert.That(result.Data!.BatchId).IsEqualTo("batch-1");
            await Assert.That(result.Data!.TotalCount).IsEqualTo(2);
            await Assert.That(result.Data!.PhoneNumbers!.Count).IsEqualTo(2);
        }

        [Test]
        public async Task PhoneNumberBatches_List_SendsStatusFilter()
        {
            var body = $"{{\"data\":[{{\"batch_id\":\"batch-1\",\"status\":\"verified\"}}],{SinglePageMeta()}}}";
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK, body));
            using var client = ClientWith(handler);
            var ops = new DirPhoneNumberBatchOperations(client, NoRetryPolicy());

            var result = await ops.List("dir-1", new ListDirPhoneNumberBatchesRequest
            {
                Status = DirPhoneNumberStatus.Verified
            });

            var uri = handler.SentUris.Single();
            await Assert.That(uri).StartsWith("https://api.telnyx.com/v2/dir/dir-1/phone_number_batches?");
            await Assert.That(uri).Contains("filter%5Bstatus%5D=verified");
            await Assert.That(result.Data!.Single().Status).IsEqualTo(DirPhoneNumberStatus.Verified);
        }

        // =====================================================================
        // Comments
        // =====================================================================

        [Test]
        public async Task Comments_Create_PostsContent_AndDeserializes()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.Created,
                "{\"data\":{\"id\":\"com-1\",\"entity_type\":\"dir\",\"content\":\"Please re-review.\",\"comment_type\":\"customer_inquiry\",\"author_role\":\"customer\"}}"));
            using var client = ClientWith(handler);
            var ops = new DirCommentOperations(client, NoRetryPolicy());

            var result = await ops.Create("dir-1", new CreateDirCommentRequest { Content = "Please re-review." });

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Post);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/dir/dir-1/comments");

            using var sent = JsonDocument.Parse(handler.SentBodies.Single()!);
            await Assert.That(sent.RootElement.GetProperty("content").GetString()).IsEqualTo("Please re-review.");

            await Assert.That(result.Data!.CommentType).IsEqualTo(DirCommentType.CustomerInquiry);
        }

        [Test]
        public async Task Comments_List_SendsCommentTypeAsPlainQueryParameter()
        {
            var body = $"{{\"data\":[{{\"id\":\"com-1\",\"comment_type\":\"vetting_comment\"}}],{SinglePageMeta()}}}";
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK, body));
            using var client = ClientWith(handler);
            var ops = new DirCommentOperations(client, NoRetryPolicy());

            var result = await ops.List("dir-1", new ListDirCommentsRequest
            {
                CommentType = DirCommentType.VettingComment
            });

            var uri = handler.SentUris.Single();
            await Assert.That(uri).StartsWith("https://api.telnyx.com/v2/dir/dir-1/comments?");
            await Assert.That(uri).Contains("comment_type=vetting_comment");
            await Assert.That(result.Data!.Single().CommentType).IsEqualTo(DirCommentType.VettingComment);
        }

        // =====================================================================
        // Infringement Claims
        // =====================================================================

        [Test]
        public async Task InfringementClaims_Contest_PostsNotesAndDocuments_AndDeserializesClaim()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK,
                "{\"data\":{\"id\":\"claim-1\",\"dir_id\":\"dir-1\",\"claim_type\":\"trademark\",\"status\":\"contested\",\"contest_history\":[{\"notes\":\"We own the trademark outright.\",\"document_count\":1}]}}"));
            using var client = ClientWith(handler);
            var ops = new InfringementClaimOperations(client, NoRetryPolicy());

            var result = await ops.Contest("claim-1", new ContestInfringementClaimRequest
            {
                ContestNotes = "We own the trademark outright.",
                Documents = new List<DirDocument>
                {
                    new() { DocumentId = "doc-1", DocumentType = "trademark_registration" }
                }
            });

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Post);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/infringement_claims/claim-1/contest");

            using var sent = JsonDocument.Parse(handler.SentBodies.Single()!);
            await Assert.That(sent.RootElement.GetProperty("contest_notes").GetString()).IsEqualTo("We own the trademark outright.");

            await Assert.That(result.Data!.Status).IsEqualTo(InfringementClaimStatus.Contested);
            await Assert.That(result.Data!.ClaimType).IsEqualTo(InfringementClaimType.Trademark);
            await Assert.That(result.Data!.ContestHistory!.Single().DocumentCount).IsEqualTo(1);
        }

        [Test]
        public async Task InfringementClaims_UpdateDirInfringement_SendsPutWithCertifications()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK,
                "{\"data\":{\"id\":\"dir-1\",\"status\":\"submitted\"}}"));
            using var client = ClientWith(handler);
            var ops = new InfringementClaimOperations(client, NoRetryPolicy());

            var result = await ops.UpdateDirInfringement("dir-1", new UpdateDirInfringementRequest
            {
                CertifyNoInfringement = true,
                CertifyBrandIsAccurate = true,
                CertifyNoShaftContent = true,
                CertifyIpOwnership = true,
                InfringementResolutionNotes = "Renamed the brand and removed the disputed logo."
            });

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Put);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/dir/dir-1/infringement_update");

            using var sent = JsonDocument.Parse(handler.SentBodies.Single()!);
            await Assert.That(sent.RootElement.GetProperty("certify_no_infringement").GetBoolean()).IsTrue();
            await Assert.That(sent.RootElement.GetProperty("infringement_resolution_notes").GetString())
                .IsEqualTo("Renamed the brand and removed the disputed logo.");

            await Assert.That(result.Data!.Id).IsEqualTo("dir-1");
        }

        // =====================================================================
        // Reference Data
        // =====================================================================

        [Test]
        public async Task ReferenceData_ValidateCallReasons_PostsBareJsonArray()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK,
                "{\"data\":{\"all_pre_approved\":false,\"non_approved_reasons\":[\"Billing inquiries\"],\"requires_manual_vetting\":true}}"));
            using var client = ClientWith(handler);
            var ops = new BrandedCallingReferenceOperations(client, NoRetryPolicy());

            var result = await ops.ValidateCallReasons(new ValidateCallReasonsRequest
            {
                CallReasons = new List<string> { "Appointment reminders", "Billing inquiries" }
            });

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Post);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/call_reasons/validate");

            // The wire body must be a bare JSON array of strings, NOT an object.
            using var sent = JsonDocument.Parse(handler.SentBodies.Single()!);
            await Assert.That(sent.RootElement.ValueKind).IsEqualTo(JsonValueKind.Array);
            await Assert.That(sent.RootElement[0].GetString()).IsEqualTo("Appointment reminders");

            await Assert.That(result.Data!.AllPreApproved).IsFalse();
            await Assert.That(result.Data!.RequiresManualVetting).IsTrue();
            await Assert.That(result.Data!.NonApprovedReasons!.Single()).IsEqualTo("Billing inquiries");
        }

        [Test]
        public async Task ReferenceData_ListDocumentTypes_SendsGetToReferenceUrl()
        {
            var body = $"{{\"data\":[{{\"short_name\":\"letter_of_authorization\",\"description\":\"Signed authorization\"}}],{SinglePageMeta()}}}";
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK, body));
            using var client = ClientWith(handler);
            var ops = new BrandedCallingReferenceOperations(client, NoRetryPolicy());

            var result = await ops.ListDocumentTypes();

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Get);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/dir/document_types");
            await Assert.That(result.Data!.Single().ShortName).IsEqualTo("letter_of_authorization");
        }

        [Test]
        public async Task ReferenceData_ListCallReasons_SendsPagination_AndDeserializes()
        {
            var body = $"{{\"data\":[{{\"id\":\"cr-1\",\"reason\":\"Account Alert\",\"description\":\"Alert about account status\"}}],{SinglePageMeta()}}}";
            var handler = new RecordingHandler(() => Json(HttpStatusCode.OK, body));
            using var client = ClientWith(handler);
            var ops = new BrandedCallingReferenceOperations(client, NoRetryPolicy());

            var result = await ops.ListCallReasons(new ListCallReasonsRequest { PageSize = 100 });

            var uri = handler.SentUris.Single();
            await Assert.That(uri).StartsWith("https://api.telnyx.com/v2/call_reasons?");
            await Assert.That(uri).Contains("page%5Bsize%5D=100");
            await Assert.That(result.Data!.Single().Reason).IsEqualTo("Account Alert");
        }

        // =====================================================================
        // Terms of Service
        // =====================================================================

        [Test]
        public async Task TermsOfService_Agree_PostsToAgreeUrl_AndDeserializesAgreement()
        {
            var handler = new RecordingHandler(() => Json(HttpStatusCode.Created,
                "{\"data\":{\"id\":\"tos-1\",\"terms_version\":\"v1.0.0\",\"version\":\"v1.0.0\",\"product_type\":\"branded_calling\",\"agreed_at\":\"2025-07-10T10:30:00Z\"}}"));
            using var client = ClientWith(handler);
            var ops = new BrandedCallingTosOperations(client, NoRetryPolicy());

            var result = await ops.Agree();

            await Assert.That(handler.SentMethods.Single()).IsEqualTo(HttpMethod.Post);
            await Assert.That(handler.SentUris.Single()).IsEqualTo("https://api.telnyx.com/v2/terms_of_service/branded_calling/agree");
            await Assert.That(handler.SentBodies.Single()).IsNull();
            await Assert.That(result.Data!.TermsVersion).IsEqualTo("v1.0.0");
            await Assert.That(result.Data!.ProductType).IsEqualTo(TosProductType.BrandedCalling);
        }

        // =====================================================================
        // Client wiring
        // =====================================================================

        [Test]
        public async Task TelnyxClient_ExposesBrandedCallingSection()
        {
            using var client = new TelnyxClient("mock_api_key");

            await Assert.That(client.BrandedCalling).IsNotNull();
            await Assert.That(client.BrandedCalling.Enterprises).IsNotNull();
            await Assert.That(client.BrandedCalling.DisplayIdentityRecords).IsNotNull();
            await Assert.That(client.BrandedCalling.PhoneNumbers).IsNotNull();
            await Assert.That(client.BrandedCalling.PhoneNumberBatches).IsNotNull();
            await Assert.That(client.BrandedCalling.Comments).IsNotNull();
            await Assert.That(client.BrandedCalling.InfringementClaims).IsNotNull();
            await Assert.That(client.BrandedCalling.ReferenceData).IsNotNull();
            await Assert.That(client.BrandedCalling.TermsOfService).IsNotNull();
        }
    }
}
