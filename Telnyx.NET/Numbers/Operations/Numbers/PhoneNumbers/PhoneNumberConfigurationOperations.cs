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
        public async Task<ListNumbersResponse> List(ListNumbersRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_numbers")
                .AddFilterList("filter[tag]", request.Tags)
                .AddFilter("filter[phone_number]", request.PhoneNumber)
                .AddFilter("filter[status]", request.Status)
                .AddFilter("filter[connection_id]", request.ConnectionId)
                .AddFilter("filter[voice.connection_name][contains]", request.VoiceConnectionNameContains)
                .AddFilter("filter[voice.connection_name][starts_with]", request.VoiceConnectionNameStartsWith)
                .AddFilter("filter[voice.connection_name][ends_with]", request.VoiceConnectionNameEndsWith)
                .AddFilter("filter[voice.connection_name][eq]", request.VoiceConnectionNameEquals)
                .AddFilter("filter[voice.usage_payment_method]", request.UsagePaymentMethod)
                .AddFilter("filter[billing_group_id]", request.BillingGroupId)
                .AddFilter("filter[emergency_address_id]", request.EmergencyAddressId)
                .AddFilter("filter[customer_reference]", request.CustomerReference)
                .AddFilter("filter[number_type][eq]", request.NumberType)
                .AddParameter("sort", request.Sort)
                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListNumbersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SlimListNumbersResponse> SlimList(SlimListNumbersRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_numbers/slim")
                .AddPagination(request.PageSize)
                .AddFilter("include_connection", request.IncludeConnection)
                .AddFilter("include_tags", request.IncludeTags)
                .AddFilter("filter[tag]", request.Tag)
                .AddFilter("filter[phone_number]", request.PhoneNumber)
                .AddFilter("filter[status]", request.Status)
                .AddFilter("filter[connection_id]", request.ConnectionId)
                .AddFilter("filter[voice.connection_name][contains]", request.ConnectionNameContains)
                .AddFilter("filter[voice.connection_name][starts_with]", request.ConnectionNameStartsWith)
                .AddFilter("filter[voice.connection_name][ends_with]", request.ConnectionNameEndsWith)
                .AddFilter("filter[voice.connection_name]", request.ConnectionName)
                .AddFilter("filter[voice.usage_payment_method]", request.UsagePaymentMethod)
                .AddFilter("filter[billing_group_id]", request.BillingGroupId)
                .AddFilter("filter[emergency_address_id]", request.EmergencyAddressId)
                .AddFilter("filter[customer_reference]", request.CustomerReference)
                .AddFilter("filter[number_type][eq]", request.NumberType)
                .AddFilter("sort", request.Sort);

            return await ExecuteAsync<SlimListNumbersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetNumberResponse> Get(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{id}");
            return await ExecuteAsync<GetNumberResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListNumbersWithVoiceSettingsResponse> ListNumbersVoiceSettings(
           ListNumbersWithVoiceSettingsRequest request,
           CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_numbers/voice")
                            .AddPagination(request.PageSize)
                            .AddFilter("filter[phone_number]", request.PhoneNumber)
                            .AddFilter("filter[connection_name][contains]", request.ConnectionNameContains)
                            .AddFilter("filter[customer_reference]", request.CustomerReference)
                            .AddFilter("filter[voice.usage_payment_method]", request.UsagePaymentMethod)
                            .AddFilter("sort", request.Sort);

            return await ExecuteAsync<ListNumbersWithVoiceSettingsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetNumberVoiceSettingsResponse> GetNumberVoiceSettings(string phoneNumberId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{phoneNumberId}/voice");
            return await ExecuteAsync<GetNumberVoiceSettingsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateNumberVoiceSettingsResponse> UpdateNumberVoiceSettings(string phoneNumberId,
            UpdateNumberVoiceSettingsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{phoneNumberId}/voice", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateNumberVoiceSettingsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<EnableEmergencyResponse> EnableEmergency(string phoneNumberId, EnableEmergencyRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{phoneNumberId}/actions/enable_emergency", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<EnableEmergencyResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<ChangeBundleStatusResponse> ChangeBundleStatus(long phoneNumberId, ChangeBundleStatusRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{phoneNumberId}/actions/bundle_status_change", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ChangeBundleStatusResponse>(req, cancellationToken);
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
