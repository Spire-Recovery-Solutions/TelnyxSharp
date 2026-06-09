using Polly.Retry;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.Enums.Responses;

namespace TelnyxSharp.Messaging.Operations.TenDlc
{
    public class EnumOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IEnumOperations
    {
        /// <inheritdoc />
        public async Task<GetEnumResponse?> Get(EnumEndpoint endpoint,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"10dlc/enum/{endpoint.ToString().ToLower()}");

            return await ExecuteAsync<GetEnumResponse>(req, cancellationToken);
        }
    }
}
