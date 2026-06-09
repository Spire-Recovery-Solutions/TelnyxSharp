using Polly.Retry;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.RegulatoryRequirements;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.RegulatoryRequirements;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers
{
    public class RegulatoryRequirementsOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IRegulatoryRequirementsOperations
    {
        /// <inheritdoc />
        public async Task<GetRegulatoryRequirementsResponse> Get(GetRegulatoryRequirementsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("regulatory_requirements")
                .AddFilter("filter[phone_number]", request.PhoneNumber)
                .AddFilter("filter[requirement_group_id]", request.RequirementGroupId)
                .AddFilter("filter[country_code]", request.CountryCode)
                .AddFilter("filter[phone_number_type]", request.PhoneNumberType)
                .AddFilter("filter[action]", request.Action);

            return await ExecuteAsync<GetRegulatoryRequirementsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListRegulatoryRequirementsResponse> GetPhoneNumber(ListRegulatoryRequirementsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("phone_numbers_regulatory_requirements")
                        .AddFilter("filter[phone_number]", request.PhoneNumber);

            return await ExecuteAsync<ListRegulatoryRequirementsResponse>(req, cancellationToken);
        }
    }
}
