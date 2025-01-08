using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;
using Telnyx.NET.Messaging.Interfaces;
using Telnyx.NET.Messaging.Models.Enums.Responses;

namespace Telnyx.NET.Messaging.Operations.TenDlc
{
    public class EnumOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IEnumOperations
    {
        /// <inheritdoc />
        public async Task<GetEnumResponse?> Get(EnumEndpoint endpoint,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/enum/{endpoint.ToString().ToLower()}");

            return await ExecuteAsync<GetEnumResponse>(req, cancellationToken);
        }
    }
}
