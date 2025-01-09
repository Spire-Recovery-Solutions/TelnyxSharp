using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.PhoneNumber.Interfaces;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses;

namespace Telnyx.NET.PhoneNumber.Operations.PhoneNumber
{
    public class PhoneNumberConfigurationOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberConfigurationOperations
    {
        /// <inheritdoc />
        public async Task<UpdateNumberVoiceSettingsResponse> UpdateNumberVoiceSettings(string phoneNumberId,
            UpdateNumberVoiceSettingsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{phoneNumberId}/voice", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateNumberVoiceSettingsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListNumbersResponse> List(ListNumbersRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_numbers").AddFilterList("tag", request.Tags)
                .AddFilter("phone_number", request.PhoneNumber)
                .AddFilter("status", request.Status)
                .AddFilter("connection_id", request.ConnectionId)
                .AddFilter("voice.connection_name[contains]", request.VoiceConnectionNameContains)
                .AddFilter("voice.connection_name[starts_with]", request.VoiceConnectionNameStartsWith)
                .AddFilter("voice.connection_name[ends_with]", request.VoiceConnectionNameEndsWith)
                .AddFilter("voice.connection_name[eq]", request.VoiceConnectionNameEquals)
                .AddFilter("usage_payment_method", request.UsagePaymentMethod)
                .AddFilter("billing_group_id", request.BillingGroupId)
                .AddFilter("emergency_address_id", request.EmergencyAddressId)
                .AddFilter("customer_reference", request.CustomerReference)
                .AddFilter("sort", request.Sort)
                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListNumbersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateNumberConfigurationResponse> Update(string phoneNumberId,
            UpdateNumberConfigurationRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{phoneNumberId}", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateNumberConfigurationResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeletePhoneNumberResponse> Delete(string numberOrObjectId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{numberOrObjectId}", Method.Delete);

            return await ExecuteAsync<DeletePhoneNumberResponse>(req, cancellationToken);
        }
    }
}
