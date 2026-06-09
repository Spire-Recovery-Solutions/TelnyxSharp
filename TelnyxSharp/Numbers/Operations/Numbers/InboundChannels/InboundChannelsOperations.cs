using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.InboundChannels.Requests;
using TelnyxSharp.Numbers.Models.InboundChannels.Responses;

namespace TelnyxSharp.Numbers.Operations.Numbers.InboundChannels
{
    internal class InboundChannelsOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IInboundChannelsOperations
    {

        /// <inheritdoc />
        public async Task<ListInboundChannelsResponse> List(CancellationToken cancellationToken = default)
        {
            var request = new TelnyxRequest("phone_numbers/inbound_channels");

            return await ExecuteAsync<ListInboundChannelsResponse>(request, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateInboundChannelsResponse> Update(UpdateInboundChannelsRequest request,
           CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("phone_numbers/inbound_channels", TelnyxMethod.Patch);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateInboundChannelsResponse>(req, cancellationToken);
        }
    }
}
