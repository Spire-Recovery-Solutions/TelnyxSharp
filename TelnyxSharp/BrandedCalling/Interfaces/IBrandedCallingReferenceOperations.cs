using TelnyxSharp.BrandedCalling.Models.ReferenceData.Requests;
using TelnyxSharp.BrandedCalling.Models.ReferenceData.Responses;

namespace TelnyxSharp.BrandedCalling.Interfaces
{
    /// <summary>
    /// Provides operations for Branded Calling reference data — the pre-vetted call-reason
    /// library and the supported document types.
    /// </summary>
    public interface IBrandedCallingReferenceOperations
    {
        /// <summary>
        /// Lists the pre-vetted call-reason library, paginated.
        /// </summary>
        /// <param name="request">The listing request.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<ListCallReasonsResponse> ListCallReasons(ListCallReasonsRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Validates candidate call reasons against the pre-vetted library.
        /// </summary>
        /// <param name="request">The candidate call-reason strings.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<ValidateCallReasonsResponse> ValidateCallReasons(ValidateCallReasonsRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists the supported document types for Branded Calling supporting documents.
        /// </summary>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<ListDirDocumentTypesResponse> ListDocumentTypes(
            CancellationToken cancellationToken = default);
    }
}
