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
                .AddFilter("administrative_area", request.AdministrativeArea)
                .AddFilter("contains", request.Contains)
                .AddFilter("country_code", request.CountryCode)
                .AddFilter("ends_with", request.EndsWith)
                .AddFilter("features", request.Features)
                .AddFilter("locality", request.Locality)
                .AddFilter("phone_number_type", request.PhoneNumberType)
                .AddFilter("rate_center", request.RateCenter)
                .AddFilter("starts_with", request.StartsWith)
                .AddFilter("limit", request.Limit.ToString())
                .AddFilter("national_destination_code", request.NationalDestinationCode?.ToString())
                .AddFilter("quickship", request.Quickship.ToString())
                .AddFilter("best_effort", request.BestEffort.ToString())
                .AddFilter("reservable", request.Reservable.ToString())
                .AddFilter("exclude_held_numbers", request.ExcludeHeldNumbers.ToString());

            return await ExecuteAsync<AvailablePhoneNumbersResponse>(req, cancellationToken);
        }
    }
}
