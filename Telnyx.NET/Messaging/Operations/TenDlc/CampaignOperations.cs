using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Messaging.Interfaces;
using Telnyx.NET.Messaging.Models.Campaign;

namespace Telnyx.NET.Messaging.Operations.TenDlc
{
    public class CampaignOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ICampaignOperations
    {
        // <inheritdoc />
        public async Task<ListCampaignsResponse?> List(ListCampaignsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/campaign").AddPagination(request.PageSize)
                .AddFilter("sort", request.Sort)
                .AddFilter("brandId", request.BrandId);
            return await ExecuteAsync<ListCampaignsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetCampaignResponse?> Get(string campaignId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/campaign/{campaignId}");

            return await ExecuteAsync<GetCampaignResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateCampaignResponse?> Update(string campaignId, UpdateCampaignRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/campaign/{campaignId}", Method.Put);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateCampaignResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeactivateCampaignResponse?> Deactivate(string campaignId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/campaign/{campaignId}", Method.Delete);

            return await ExecuteAsync<DeactivateCampaignResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetCampaignOperationStatusResponse?> RetrieveOperationStatus(string campaignId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/campaign/{campaignId}/operationStatus");

            return await ExecuteAsync<GetCampaignOperationStatusResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetCampaignOsrAttributesResponse?> RetrieveOsrAttributes(string campaignId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/campaign/{campaignId}/osr/attributes");

            return await ExecuteAsync<GetCampaignOsrAttributesResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetCampaignCostResponse?> GetCost(GetCampaignCostRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/campaign/usecase/cost").AddFilter("usecase", request.UseCase);

            return await ExecuteAsync<GetCampaignCostResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SubmitCampaignResponse?> Submit(SubmitCampaignRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("10dlc/campaignBuilder", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<SubmitCampaignResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<QualifyCampaignByUsecaseResponse?> QualifyByUsecase(string brandId,
            string usecase, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/campaignBuilder/brand/{brandId}/usecase/{usecase}");

            return await ExecuteAsync<QualifyCampaignByUsecaseResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetCampaignMnoMetadataResponse?> GetCampaignMnoMetadataAsync(string campaignId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/campaign/{campaignId}/mnoMetadata");

            return await ExecuteAsync<GetCampaignMnoMetadataResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<AcceptSharedCampaignResponse?> AcceptSharedCampaignAsync(string campaignId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/campaign/acceptSharing/{campaignId}", Method.Post);

            return await ExecuteAsync<AcceptSharedCampaignResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetCampaignSharingStatusResponse?> GetSharingStatus(string campaignId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/campaign/{campaignId}/sharing");

            return await ExecuteAsync<GetCampaignSharingStatusResponse>(req, cancellationToken);
        }
    }
}