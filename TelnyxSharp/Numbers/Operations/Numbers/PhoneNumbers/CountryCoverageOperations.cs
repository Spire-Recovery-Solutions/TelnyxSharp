using Polly.Retry;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.CountryCoverage;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers
{
    public class CountryCoverageOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ICountryCoverageOperations
    {
        /// <inheritdoc />
        public async Task<ListCountryCoverageResponse> List(CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"country_coverage");
            return await ExecuteAsync<ListCountryCoverageResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetCountryCoverageResponse> Get(string countryCode, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"country_coverage/countries/{countryCode}");
            return await ExecuteAsync<GetCountryCoverageResponse>(req, cancellationToken);
        }
    }
}
