using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Messaging.Interfaces;
using Telnyx.NET.Messaging.Models.AdvancedOptInOptOut;

namespace Telnyx.NET.Messaging.Operations.SmsMms
{
    public class AdvancedOptInOptOutOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IAdvancedOptInOptOutOperations
    {
        /// <inheritdoc />
        public async Task<ListAutoResponseSettingsResponse?> List(string profileId,
            ListAutoResponseSettingsRequest request, CancellationToken cancellationToken = default)
        {
            var createdAtGteFormatted = request.CreatedAtGte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");
            var createdAtLteFormatted = request.CreatedAtLte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");
            var updatedAtGteFormatted = request.UpdatedAtGte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");
            var updatedAtLteFormatted = request.UpdatedAtLte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");

            var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs")
                .AddFilter("country_code", request.CountryCode)
                .AddFilter("created_at[gte]", createdAtGteFormatted)
                .AddFilter("created_at[lte]", createdAtLteFormatted)
                .AddFilter("updated_at[gte]", updatedAtGteFormatted)
                .AddFilter("updated_at[lte]", updatedAtLteFormatted);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ListAutoResponseSettingsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateAutoResponseSettingResponse?> Create(string profileId,
            CreateAutoResponseSettingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreateAutoResponseSettingResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetAutoResponseSettingResponse?> Retrieve(string profileId,
            string autorespCfgId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs/{autorespCfgId}");

            return await ExecuteAsync<GetAutoResponseSettingResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateAutoResponseSettingResponse?> Update(string profileId,
            string autorespCfgId, UpdateAutoResponseSettingRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs/{autorespCfgId}", Method.Put);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateAutoResponseSettingResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteAutoResponseSettingResponse?> Delete(string profileId,
            string autorespCfgId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs/{autorespCfgId}",
                Method.Delete);

            return await ExecuteAsync<DeleteAutoResponseSettingResponse>(req, cancellationToken);
        }
    }
}