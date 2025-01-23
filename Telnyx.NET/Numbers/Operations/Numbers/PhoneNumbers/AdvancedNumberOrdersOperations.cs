using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.AdvancedNumberOrders;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.AdvancedNumberOrders;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers
{
    public class AdvancedNumberOrdersOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IAdvancedNumberOrdersOperations
    {
        
        /// <inheritdoc />
        public async Task<CreateAdvancedOrderResponse> Create(CreateAdvancedOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("advanced_orders", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            
            return await ExecuteAsync<CreateAdvancedOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListAdvancedOrdersResponse> List(CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("advanced_orders");
            
            return await ExecuteAsync<ListAdvancedOrdersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetAdvancedOrderResponse> Get(string orderId, CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest($"advanced_orders/{orderId}");
            return await ExecuteAsync<GetAdvancedOrderResponse>(restRequest, cancellationToken);
        }
    }
}
