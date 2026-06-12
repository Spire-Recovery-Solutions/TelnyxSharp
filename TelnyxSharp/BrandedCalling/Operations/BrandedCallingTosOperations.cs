using Polly.Retry;
using TelnyxSharp.Base;
using TelnyxSharp.BrandedCalling.Interfaces;
using TelnyxSharp.BrandedCalling.Models.TermsOfService.Responses;

namespace TelnyxSharp.BrandedCalling.Operations
{
    /// <summary>
    /// Provides operations for the Branded Calling Terms of Service.
    /// Implements the <see cref="IBrandedCallingTosOperations"/> interface.
    /// </summary>
    public class BrandedCallingTosOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        : BaseOperations(client, rateLimitRetryPolicy), IBrandedCallingTosOperations
    {
        /// <inheritdoc />
        public async Task<TosAgreementResponse> Agree(CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("terms_of_service/branded_calling/agree", TelnyxMethod.Post);

            return await ExecuteAsync<TosAgreementResponse>(req, cancellationToken);
        }
    }
}
