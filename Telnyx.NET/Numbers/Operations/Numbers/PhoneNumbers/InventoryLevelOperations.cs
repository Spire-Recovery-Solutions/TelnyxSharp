using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.InventoryLevel;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.InventoryLevel;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers
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
