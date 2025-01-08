using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Messaging.Interfaces;
using Telnyx.NET.Messaging.Models.NumberConfigurations.Requests;
using Telnyx.NET.Messaging.Models.NumberConfigurations.Responses;

namespace Telnyx.NET.Messaging.Operations.SmsMms
{
    public class NumberConfigurationOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), INumberConfigurationOperations
    {
        // <inheritdoc />
        public async Task<ListPhoneMessageSettingsResponse?> List(
            ListPhoneMessageSettingsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/messaging").AddPagination(request.PageSize);

            return await ExecuteAsync<ListPhoneMessageSettingsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrievePhoneMessageSettingsResponse?> Retrieve(string id,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{id}/messaging");

            return await ExecuteAsync<RetrievePhoneMessageSettingsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdatePhoneNumberMessagingResponse?> Update(string id,
            UpdatePhoneNumberMessagingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{id}/messaging", Method.Patch);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdatePhoneNumberMessagingResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateNumbersMessagingBulkResponse?> UpdateMultipleNumbers(
            UpdateNumbersMessagingBulkRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messaging_numbers_bulk_updates", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateNumbersMessagingBulkResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveBulkUpdateStatusResponse?> RetrieveBulkUpdateStatusAsync(string orderId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_numbers_bulk_updates/{orderId}");

            return await ExecuteAsync<RetrieveBulkUpdateStatusResponse>(req, cancellationToken);
        }
    }
}