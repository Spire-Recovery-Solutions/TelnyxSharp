using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.BrandedCalling.Interfaces;
using TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Responses;
using TelnyxSharp.BrandedCalling.Models.InfringementClaims.Requests;
using TelnyxSharp.BrandedCalling.Models.InfringementClaims.Responses;

namespace TelnyxSharp.BrandedCalling.Operations
{
    /// <summary>
    /// Provides operations for handling infringement claims filed against a Display Identity Record (DIR).
    /// Implements the <see cref="IInfringementClaimOperations"/> interface.
    /// </summary>
    public class InfringementClaimOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        : BaseOperations(client, rateLimitRetryPolicy), IInfringementClaimOperations
    {
        /// <inheritdoc />
        public async Task<ListInfringementClaimsResponse> ListByDir(string dirId, ListInfringementClaimsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}/infringement_claims");
            req.AddPagination(request.PageSize);

            return await ExecuteAsync<ListInfringementClaimsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DirResponse> UpdateDirInfringement(string dirId, UpdateDirInfringementRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}/infringement_update", TelnyxMethod.Put);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<DirResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<InfringementClaimResponse> Retrieve(string claimId,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"infringement_claims/{claimId}");

            return await ExecuteAsync<InfringementClaimResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<InfringementClaimResponse> Contest(string claimId, ContestInfringementClaimRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"infringement_claims/{claimId}/contest", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<InfringementClaimResponse>(req, cancellationToken);
        }
    }
}
