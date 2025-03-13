using Polly.Retry;
using RestSharp;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.InventoryLevel;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.InventoryLevel;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers
{
    public class InventoryLevelOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IInventoryLevelOperations
    {
        /// <inheritdoc />
        public async Task<InventoryCoverageResponse> Get(InventoryCoverageRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("inventory_coverage")
                .AddFilter("filter[npa]", request.Npa)
                .AddFilter("filter[nxx]", request.Nxx)
                .AddFilter("filter[administrative_area]", request.AdministrativeArea)
                .AddFilter("filter[phone_number_type]", request.PhoneNumberType)
                .AddFilter("filter[country_code]", request.CountryCode)
                .AddFilter("filter[count]", request.Count)
                .AddFilter("filter[features]", request.Features)
                .AddFilter("filter[groupBy]", request.GroupBy);

            return await ExecuteAsync<InventoryCoverageResponse>(req, cancellationToken);
        }
    }
}
