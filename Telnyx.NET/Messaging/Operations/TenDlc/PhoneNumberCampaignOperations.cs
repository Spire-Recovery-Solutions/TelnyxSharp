using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Messaging.Interfaces;
using Telnyx.NET.Messaging.Models.PhoneNumberCampaign.Requests;
using Telnyx.NET.Messaging.Models.PhoneNumberCampaign.Responses;

namespace Telnyx.NET.Messaging.Operations.TenDlc
{
    public class PhoneNumberCampaignOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberCampaignOperations
    {
        /// <inheritdoc />
        public async Task<RetrievePhoneNumberCampaignsResponse?> Retrieve(
            RetrievePhoneNumberCampaignsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/phone_number_campaigns")
                .AddFilter("telnyx_campaign_id", request.FilterTelnyxCampaignId)
                .AddFilter("telnyx_brand_id", request.FilterTelnyxBrandId)
                .AddFilter("tcr_campaign_id", request.FilterTcrCampaignId)
                .AddFilter("tcr_brand_id", request.FilterTcrBrandId)
                .AddFilter("sort", request.Sort)
                .AddPagination(request.PageSize);

            return await ExecuteAsync<RetrievePhoneNumberCampaignsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreatePhoneNumberCampaignResponse?> Create(
            CreatePhoneNumberCampaignRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("10dlc/phone_number_campaigns", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreatePhoneNumberCampaignResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetPhoneNumberCampaignResponse?> Get(string phoneNumber,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/phone_number_campaigns/{phoneNumber}");

            return await ExecuteAsync<GetPhoneNumberCampaignResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdatePhoneNumberCampaignResponse?> Update(string phoneNumber,
            UpdatePhoneNumberCampaignRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/phone_number_campaigns/{phoneNumber}", Method.Put);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdatePhoneNumberCampaignResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeletePhoneNumberCampaignResponse?> Delete(string phoneNumber,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/phone_number_campaigns/{phoneNumber}", Method.Delete);

            return await ExecuteAsync<DeletePhoneNumberCampaignResponse>(req, cancellationToken);
        }
    }
}
