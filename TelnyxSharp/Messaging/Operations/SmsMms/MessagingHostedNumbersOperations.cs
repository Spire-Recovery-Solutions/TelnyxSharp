using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.MessagingHostedNumber.Requests;
using TelnyxSharp.Messaging.Models.MessagingHostedNumber.Responses;

namespace TelnyxSharp.Messaging.Operations.SmsMms
{
    public class MessagingHostedNumbersOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IMessagingHostedNumbersOperations
    {
        /// <inheritdoc />
        public async Task<DeleteHostedNumberResponse?> Delete(string id,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_hosted_numbers/{id}", Method.Delete);

            return await ExecuteAsync<DeleteHostedNumberResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetHostedNumberOrderResponse?> List(
            GetHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_hosted_number_orders").AddPagination(request.PageSize);

            return await ExecuteAsync<GetHostedNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateHostedNumberOrderResponse?> Create(
            CreateHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messaging_hosted_number_orders", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreateHostedNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveHostedNumberOrderResponse?> Retrieve(string id,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_hosted_number_orders/{id}");

            return await ExecuteAsync<RetrieveHostedNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UploadFileHostedNumberOrderResponse?> UploadFileRequired(string id,
            UploadFileHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_hosted_number_orders/{id}/actions/file_upload", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UploadFileHostedNumberOrderResponse>(req, cancellationToken);
        }
    }
}