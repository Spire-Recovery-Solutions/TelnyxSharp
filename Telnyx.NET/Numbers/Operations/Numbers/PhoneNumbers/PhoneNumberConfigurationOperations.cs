using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers
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
        public async Task<ListNumbersResponse> List(ListNumbersRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_numbers")
                .AddFilterList("filter[tag]", request.Tags)
                .AddFilter("filter[phone_number]", request.PhoneNumber)
                .AddFilter("filter[status]", request.Status)
                .AddFilter("filter[connection_id]", request.ConnectionId?.ToString())
                .AddFilter("filter[voice.connection_name][contains]", request.VoiceConnectionNameContains)
                .AddFilter("filter[voice.connection_name][starts_with]", request.VoiceConnectionNameStartsWith)
                .AddFilter("filter[voice.connection_name][ends_with]", request.VoiceConnectionNameEndsWith)
                .AddFilter("filter[voice.connection_name][eq]", request.VoiceConnectionNameEquals)
                .AddFilter("filter[voice.usage_payment_method]", request.UsagePaymentMethod)
                .AddFilter("filter[billing_group_id]", request.BillingGroupId)
                .AddFilter("filter[emergency_address_id]", request.EmergencyAddressId?.ToString())
                .AddFilter("filter[customer_reference]", request.CustomerReference)
                .AddFilter("filter[number_type][eq]", request.NumberType)
                .AddParameter("sort", request.Sort)
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
