using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.SharedCampaign.Requests;
using TelnyxSharp.Messaging.Models.SharedCampaign.Responses;

namespace TelnyxSharp.Messaging.Operations.TenDlc
{
    public class SharedCampaignOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ISharedCampaignOperations
    {
        /// <inheritdoc />
        public async Task<ListSharedCampaignsResponse?> List(ListSharedCampaignsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/partner_campaigns")
                .AddFilter("recordsPerPage", request.PageSize)
                .AddFilter("sort", request.Sort);

            return await ExecuteAsync<ListSharedCampaignsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetSharedCampaignRecordResponse?> Get(string campaignId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/partner_campaigns/{campaignId}");

            return await ExecuteAsync<GetSharedCampaignRecordResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateSingleSharedCampaignResponse?> Update(string campaignId,
            UpdateSingleSharedCampaignRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/partner_campaigns/{campaignId}", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateSingleSharedCampaignResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetSharingStatusResponse?> GetSharingStatus(string campaignId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/partnerCampaign/{campaignId}/sharing");

            return await ExecuteAsync<GetSharingStatusResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetPartnerCampaignsSharedByUserResponse?> GetPartnerCampaignsSharedByUser(
            GetPartnerCampaignsSharedByUserRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/partnerCampaign/sharedByMe").AddFilter("recordsPerPage", request.PageSize);
            return await ExecuteAsync<GetPartnerCampaignsSharedByUserResponse>(req, cancellationToken);
        }
    }
}
