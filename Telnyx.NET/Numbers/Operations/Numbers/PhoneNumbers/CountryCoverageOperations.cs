using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.CountryCoverage;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers
{
    public class CountryCoverageOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ICountryCoverageOperations
    {
        /// <inheritdoc />
        public async Task<ListCountryCoverageResponse> List(CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"country_coverage");
            return await ExecuteAsync<ListCountryCoverageResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetCountryCoverageResponse> Get(string countryCode, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"country_coverage/countries/{countryCode}");
            return await ExecuteAsync<GetCountryCoverageResponse>(req, cancellationToken);
        }
    }
}
