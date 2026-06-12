using TelnyxSharp.BrandedCalling.Models.TermsOfService.Responses;

namespace TelnyxSharp.BrandedCalling.Interfaces
{
    /// <summary>
    /// Provides operations for the Branded Calling Terms of Service.
    /// </summary>
    public interface IBrandedCallingTosOperations
    {
        /// <summary>
        /// Records the calling user's agreement to the current Branded Calling Terms of Service.
        /// </summary>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<TosAgreementResponse> Agree(CancellationToken cancellationToken = default);
    }
}
