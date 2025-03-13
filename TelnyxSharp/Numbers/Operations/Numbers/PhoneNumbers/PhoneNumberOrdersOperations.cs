using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers
{
    public class PhoneNumberOrdersOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberOrdersOperations
    {
        /// <inheritdoc />
        public async Task<ListNumberOrdersResponse> List(ListNumberOrdersRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("number_orders")
                .AddFilter("filter[status]", request.Status)
                .AddFilter("filter[created_at][gt]", request.CreatedAfter)
                .AddFilter("filter[created_at][lt]", request.CreatedBefore)
                .AddFilter("filter[customer_reference]", request.CustomerReference)
                .AddFilter("filter[phone_numbers_count]", request.PhoneNumberCount)
                .AddFilter("filter[requirements_met]", request.RequirementsMet)
                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListNumberOrdersResponse>(req, cancellationToken);
        }
        

        /// <inheritdoc />
        public async Task<CreateNumberOrderResponse> Create(CreateNumberOrderRequest request,
        CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("number_orders", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreateNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetNumberOrderResponse> Get(string numberOrderId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_orders/{numberOrderId}");
            return await ExecuteAsync<GetNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateNumberOrderResponse> Update(string numberOrderId, UpdateNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_orders/{numberOrderId}", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListSubNumberOrdersResponse> ListSubNumber(ListSubNumberOrdersRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("sub_number_orders")
                .AddFilter("filter[status]", request.Status)
                .AddFilter("filter[order_request_id]", request.OrderRequestId)
                .AddFilter("filter[country_code]", request.CountryCode)
                .AddFilter("filter[phone_number_type]", request.PhoneNumberType)
                .AddFilter("filter[phone_numbers_count]", request.PhoneNumbersCount);

            return await ExecuteAsync<ListSubNumberOrdersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetSubNumberOrderResponse> GetSubNumber(string subNumberOrderId, GetSubNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"sub_number_orders/{subNumberOrderId}")
                .AddFilter("filter[include_phone_numbers]", request.IncludePhoneNumbers);

            return await ExecuteAsync<GetSubNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateSubNumberOrderResponse> UpdateSubNumber(string subNumberOrderId, UpdateSubNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"sub_number_orders/{subNumberOrderId}", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateSubNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CancelNumberOrderResponse> CancelSubNumber(string subNumberOrderId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"sub_number_orders/{subNumberOrderId}/cancel", Method.Patch);
            return await ExecuteAsync<CancelNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListNumberOrderPhonesResponse> ListNumberAssociatedOrders(ListNumberOrderPhonesRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("number_order_phone_numbers")
                .AddFilter("filter[country_code]", request.CountryCode);

            return await ExecuteAsync<ListNumberOrderPhonesResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SingleNumberOrderPhoneResponse> GetNumberAssociatedOrders(string numberOrderPhoneNumberId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_order_phone_numbers/{numberOrderPhoneNumberId}");
            return await ExecuteAsync<SingleNumberOrderPhoneResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateNumberOrderPhoneResponse> UpdateNumberAssociatedOrders(string numberOrderPhoneNumberId, UpdateNumberOrderPhoneRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_order_phone_numbers/{numberOrderPhoneNumberId}", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateNumberOrderPhoneResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateCommentResponse> CreateComment(CreateCommentRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("comments", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreateCommentResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListCommentsResponse> ListComment(ListCommentsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("comments")
                .AddFilter("filter[comment_record_type]", request.CommentRecordType)
                .AddFilter("filter[comment_record_id]", request.CommentRecordId);

            return await ExecuteAsync<ListCommentsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetCommentResponse> GetComment(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"comments/{id}");
            return await ExecuteAsync<GetCommentResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<MarkCommentReadResponse> MarkCommentAsRead(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"comments/{id}/read", Method.Patch);
            return await ExecuteAsync<MarkCommentReadResponse>(req, cancellationToken);
        }
    }
}
