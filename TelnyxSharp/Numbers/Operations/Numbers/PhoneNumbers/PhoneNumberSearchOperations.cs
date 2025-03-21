﻿using Polly.Retry;
using RestSharp;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberSearch;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberSearch;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers
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
                .AddFilter("filter[features]", request.Features)
                .AddFilter("filter[locality]", request.Locality)
                .AddFilter("filter[phone_number_type]", request.PhoneNumberType)
                .AddFilter("filter[rate_center]", request.RateCenter)
                .AddFilter("filter[phone_number][starts_with]", request.StartsWith)
                .AddFilter("filter[limit]", request.Limit)
                .AddFilter("filter[national_destination_code]", request.NationalDestinationCode)
                .AddFilter("filter[quickship]", request.Quickship)
                .AddFilter("filter[best_effort]", request.BestEffort)
                .AddFilter("filter[reservable]", request.Reservable)
                .AddFilter("filter[exclude_held_numbers]", request.ExcludeHeldNumbers);

            return await ExecuteAsync<AvailablePhoneNumbersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListAvailablePhoneNumberBlocksResponse> ListAvailableNumberBlocks(ListAvailablePhoneNumberBlocksRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("available_phone_number_blocks")
                .AddFilter("filter[locality]", request.Locality)
                .AddFilter("filter[country_code]", request.CountryCode)
                .AddFilter("filter[national_destination_code]", request.NationalDestinationCode)
                .AddFilter("filter[phone_number_type]", request.PhoneNumberType);

            return await ExecuteAsync<ListAvailablePhoneNumberBlocksResponse>(req, cancellationToken);
        }
    }
}
