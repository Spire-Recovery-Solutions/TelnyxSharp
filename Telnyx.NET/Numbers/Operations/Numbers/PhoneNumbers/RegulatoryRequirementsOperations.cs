using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.RegulatoryRequirements;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.RegulatoryRequirements;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers
{
    public class RegulatoryRequirementsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IRegulatoryRequirementsOperations
    {
        /// <inheritdoc />
        public async Task<GetRegulatoryRequirementsResponse> Get(GetRegulatoryRequirementsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("regulatory_requirements")
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
            var req = new RestRequest("phone_numbers_regulatory_requirements")
                        .AddFilter("filter[phone_number]", request.PhoneNumber);

            return await ExecuteAsync<ListRegulatoryRequirementsResponse>(req, cancellationToken);
        }
    }
}
