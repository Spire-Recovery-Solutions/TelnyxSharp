using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.MessagingHostedNumber.Requests;
using TelnyxSharp.Messaging.Models.MessagingHostedNumber.Responses;

namespace TelnyxSharp.Messaging.Operations.SmsMms
{
    public class MessagingHostedNumbersOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IMessagingHostedNumbersOperations
    {
        /// <inheritdoc />
        public async Task<DeleteHostedNumberResponse?> Delete(string id,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"messaging_hosted_numbers/{id}", TelnyxMethod.Delete);

            return await ExecuteAsync<DeleteHostedNumberResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetHostedNumberOrderResponse?> List(
            GetHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"messaging_hosted_number_orders").AddPagination(request.PageSize);

            return await ExecuteAsync<GetHostedNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateHostedNumberOrderResponse?> Create(
            CreateHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("messaging_hosted_number_orders", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreateHostedNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveHostedNumberOrderResponse?> Retrieve(string id,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"messaging_hosted_number_orders/{id}");

            return await ExecuteAsync<RetrieveHostedNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UploadFileHostedNumberOrderResponse?> UploadFileRequired(string id,
            UploadFileHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"messaging_hosted_number_orders/{id}/actions/file_upload", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UploadFileHostedNumberOrderResponse>(req, cancellationToken);
        }
    }
}