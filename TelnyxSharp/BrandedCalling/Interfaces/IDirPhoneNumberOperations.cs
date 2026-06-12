using TelnyxSharp.BrandedCalling.Models.PhoneNumbers.Requests;
using TelnyxSharp.BrandedCalling.Models.PhoneNumbers.Responses;

namespace TelnyxSharp.BrandedCalling.Interfaces
{
    /// <summary>
    /// Provides operations for managing the phone numbers attached to a Display Identity Record (DIR).
    /// </summary>
    public interface IDirPhoneNumberOperations
    {
        /// <summary>
        /// Lists the phone numbers attached to a DIR, paginated.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="request">The listing request with optional filters.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<ListDirPhoneNumbersResponse> List(string dirId, ListDirPhoneNumbersRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Bulk-adds 1-15 phone numbers to a DIR. All numbers are vetted together as a single
        /// batch; if any number fails, the entire request is rejected.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="request">The phone numbers and supporting documents.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<AddDirPhoneNumbersResponse> Add(string dirId, AddDirPhoneNumbersRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Bulk-deletes 1-15 phone numbers from a DIR. Per-number failures are reported in the
        /// response meta without blocking the call.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="request">The phone numbers to remove.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<DeleteDirPhoneNumbersResponse> Delete(string dirId, DeleteDirPhoneNumbersRequest request,
            CancellationToken cancellationToken = default);
    }
}
