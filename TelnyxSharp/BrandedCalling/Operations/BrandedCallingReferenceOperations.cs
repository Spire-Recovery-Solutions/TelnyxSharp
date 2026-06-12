using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.BrandedCalling.Interfaces;
using TelnyxSharp.BrandedCalling.Models.ReferenceData.Requests;
using TelnyxSharp.BrandedCalling.Models.ReferenceData.Responses;

namespace TelnyxSharp.BrandedCalling.Operations
{
    /// <summary>
    /// Provides operations for Branded Calling reference data — the pre-vetted call-reason
    /// library and the supported document types.
    /// Implements the <see cref="IBrandedCallingReferenceOperations"/> interface.
    /// </summary>
    public class BrandedCallingReferenceOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        : BaseOperations(client, rateLimitRetryPolicy), IBrandedCallingReferenceOperations
    {
        /// <inheritdoc />
        public async Task<ListCallReasonsResponse> ListCallReasons(ListCallReasonsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("call_reasons");
            req.AddPagination(request.PageSize);

            return await ExecuteAsync<ListCallReasonsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ValidateCallReasonsResponse> ValidateCallReasons(ValidateCallReasonsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("call_reasons/validate", TelnyxMethod.Post);

            // The endpoint expects a bare JSON array of strings, not an object.
            req.AddBody(JsonSerializer.Serialize(request.CallReasons ?? new List<string>(),
                TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ValidateCallReasonsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListDirDocumentTypesResponse> ListDocumentTypes(
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("dir/document_types");

            return await ExecuteAsync<ListDirDocumentTypesResponse>(req, cancellationToken);
        }
    }
}
