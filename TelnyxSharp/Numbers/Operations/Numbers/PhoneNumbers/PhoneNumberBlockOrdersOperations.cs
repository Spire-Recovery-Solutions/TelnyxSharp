using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberBlockOrders;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlockOrders;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers
{
    public class PhoneNumberBlockOrdersOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberBlockOrdersOperations
    {
        /// <inheritdoc />
        public async Task<ListNumberBlockOrdersResponse> List(ListNumberBlockOrdersRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("number_block_orders")
                .AddFilter("filter[status]", request.Status)
                .AddFilter("filter[created_at][gt]", request.CreatedAfter)
                .AddFilter("filter[created_at][lt]", request.CreatedBefore)
                .AddFilter("filter[phone_numbers.starting_number]", request.StartingNumber)
                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListNumberBlockOrdersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateNumberBlockOrderResponse> Create(CreateNumberBlockOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("number_block_orders", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreateNumberBlockOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetNumberBlockOrderResponse> Get(string numberBlockOrderId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_block_orders/{numberBlockOrderId}");

            return await ExecuteAsync<GetNumberBlockOrderResponse>(req, cancellationToken);
        }
    }
}
