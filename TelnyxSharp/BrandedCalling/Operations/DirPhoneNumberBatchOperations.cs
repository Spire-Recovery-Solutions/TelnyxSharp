using Polly.Retry;
using TelnyxSharp.Base;
using TelnyxSharp.BrandedCalling.Interfaces;
using TelnyxSharp.BrandedCalling.Models.PhoneNumberBatches.Requests;
using TelnyxSharp.BrandedCalling.Models.PhoneNumberBatches.Responses;

namespace TelnyxSharp.BrandedCalling.Operations
{
    /// <summary>
    /// Provides operations for inspecting the phone-number batches of a Display Identity Record (DIR).
    /// Implements the <see cref="IDirPhoneNumberBatchOperations"/> interface.
    /// </summary>
    public class DirPhoneNumberBatchOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        : BaseOperations(client, rateLimitRetryPolicy), IDirPhoneNumberBatchOperations
    {
        /// <inheritdoc />
        public async Task<ListDirPhoneNumberBatchesResponse> List(string dirId, ListDirPhoneNumberBatchesRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}/phone_number_batches");
            req.AddFilter("filter[status]", request.Status);
            req.AddPagination(request.PageSize);

            return await ExecuteAsync<ListDirPhoneNumberBatchesResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DirPhoneNumberBatchResponse> Retrieve(string dirId, string batchId,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}/phone_number_batches/{batchId}");

            return await ExecuteAsync<DirPhoneNumberBatchResponse>(req, cancellationToken);
        }
    }
}
