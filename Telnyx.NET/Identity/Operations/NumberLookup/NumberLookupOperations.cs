using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;
using Telnyx.NET.Identity.Interfaces;
using Telnyx.NET.Identity.Models.NumberLookup.Requests;
using Telnyx.NET.Identity.Models.NumberLookup.Responses;

namespace Telnyx.NET.Identity.Operations.NumberLookup
{
    public class NumberLookupOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), INumberLookupOperations
    {
        /// <inheritdoc />
        public async Task<NumberLookupResponse> LookupPhoneData(NumberLookupRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_lookup/{request.PhoneNumber}");

            foreach (var type in request.NumberLookupTypes)
            {
                switch (type)
                {
                    case NumberLookupType.CallerName:
                        req.AddFilter("type", "caller-name");
                        break;
                    case NumberLookupType.Carrier:
                        req.AddFilter("type", "carrier");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return await ExecuteAsync<NumberLookupResponse>(req, cancellationToken);
        }
    }
}
