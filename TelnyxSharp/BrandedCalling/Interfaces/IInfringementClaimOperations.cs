using TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Responses;
using TelnyxSharp.BrandedCalling.Models.InfringementClaims.Requests;
using TelnyxSharp.BrandedCalling.Models.InfringementClaims.Responses;

namespace TelnyxSharp.BrandedCalling.Interfaces
{
    /// <summary>
    /// Provides operations for handling infringement claims filed against a Display Identity Record (DIR).
    /// </summary>
    public interface IInfringementClaimOperations
    {
        /// <summary>
        /// Lists the infringement claims filed against a DIR, paginated.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="request">The listing request.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<ListInfringementClaimsResponse> ListByDir(string dirId, ListInfringementClaimsRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a DIR in response to an infringement concern, re-certifying the brand
        /// information and explaining how the concern was addressed.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="request">The re-certifications and updated brand fields.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<DirResponse> UpdateDirInfringement(string dirId, UpdateDirInfringementRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a single infringement claim by id.
        /// </summary>
        /// <param name="claimId">The claim id.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<InfringementClaimResponse> Retrieve(string claimId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Contests an infringement claim with supporting evidence.
        /// </summary>
        /// <param name="claimId">The claim id.</param>
        /// <param name="request">The contest notes and supporting documents.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<InfringementClaimResponse> Contest(string claimId, ContestInfringementClaimRequest request,
            CancellationToken cancellationToken = default);
    }
}
