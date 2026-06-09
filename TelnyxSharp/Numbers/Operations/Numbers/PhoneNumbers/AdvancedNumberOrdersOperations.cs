using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.AdvancedNumberOrders;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.AdvancedNumberOrders;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers
{
    public class AdvancedNumberOrdersOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IAdvancedNumberOrdersOperations
    {

        /// <inheritdoc />
        public async Task<CreateAdvancedOrderResponse> Create(CreateAdvancedOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("advanced_orders", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreateAdvancedOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListAdvancedOrdersResponse> List(CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("advanced_orders");

            return await ExecuteAsync<ListAdvancedOrdersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetAdvancedOrderResponse> Get(string orderId, CancellationToken cancellationToken = default)
        {
            var restRequest = new TelnyxRequest($"advanced_orders/{orderId}");
            return await ExecuteAsync<GetAdvancedOrderResponse>(restRequest, cancellationToken);
        }
    }
}
