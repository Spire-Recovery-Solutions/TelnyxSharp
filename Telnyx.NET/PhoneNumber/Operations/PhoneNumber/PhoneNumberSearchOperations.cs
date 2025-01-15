using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.PhoneNumber.Interfaces;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses;

namespace Telnyx.NET.PhoneNumber.Operations.PhoneNumber
{
    public class PhoneNumberSearchOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberSearchOperations
    {
        /// <inheritdoc />
        public async Task<AvailablePhoneNumbersResponse> AvailableNumbers(AvailablePhoneNumbersRequest request,
    CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("available_phone_numbers")
                .AddFilter("filter[administrative_area]", request.AdministrativeArea)
                .AddFilter("filter[phone_number][contains]", request.Contains)
                .AddFilter("filter[country_code]", request.CountryCode)
                .AddFilter("filter[phone_number][ends_with]", request.EndsWith)
                .AddFilterList("filter[features]", request.Features)
                .AddFilter("filter[locality]", request.Locality)
                .AddFilter("filter[phone_number_type]", request.PhoneNumberType)
                .AddFilter("filter[rate_center]", request.RateCenter)
                .AddFilter("filter[phone_number][starts_with]", request.StartsWith)
                .AddFilter("filter[limit]", request.Limit?.ToString())
                .AddFilter("filter[national_destination_code]", request.NationalDestinationCode?.ToString())
                .AddFilter("filter[quickship]", request.Quickship?.ToString())
                .AddFilter("filter[best_effort]", request.BestEffort?.ToString())
                .AddFilter("filter[reservable]", request.Reservable?.ToString())
                .AddFilter("filter[exclude_held_numbers]", request.ExcludeHeldNumbers?.ToString());

            return await ExecuteAsync<AvailablePhoneNumbersResponse>(req, cancellationToken);
        }
    }
}
