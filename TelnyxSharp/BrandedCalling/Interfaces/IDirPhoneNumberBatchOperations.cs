using TelnyxSharp.BrandedCalling.Models.PhoneNumberBatches.Requests;
using TelnyxSharp.BrandedCalling.Models.PhoneNumberBatches.Responses;

namespace TelnyxSharp.BrandedCalling.Interfaces
{
    /// <summary>
    /// Provides operations for inspecting the phone-number batches of a Display Identity Record (DIR).
    /// </summary>
    public interface IDirPhoneNumberBatchOperations
    {
        /// <summary>
        /// Lists the phone-number batches of a DIR, paginated.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="request">The listing request with optional filters.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<ListDirPhoneNumberBatchesResponse> List(string dirId, ListDirPhoneNumberBatchesRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a single phone-number batch with per-number status.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="batchId">The batch id.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<DirPhoneNumberBatchResponse> Retrieve(string dirId, string batchId,
            CancellationToken cancellationToken = default);
    }
}
