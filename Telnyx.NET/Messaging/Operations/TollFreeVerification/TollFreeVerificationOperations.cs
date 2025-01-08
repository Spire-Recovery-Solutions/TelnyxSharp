using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Messaging.Interfaces;
using Telnyx.NET.Messaging.Models.TollFreeVerificationOperations;

namespace Telnyx.NET.Messaging.Operations.TollFreeVerification
{
    public class TollFreeVerificationOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ITollFreeVerificationOperations
    {
        /// <inheritdoc />
        public async Task<ListVerificationRequestsResponse?> List(
            ListVerificationRequestsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_tollfree/verification/requests").AddPagination(request.PageSize)
                .AddFilter("date_start", request.DateStart?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz"))
                .AddFilter("date_end", request.DateEnd?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz"))
                .AddFilter("status", request.Status?.ToString())
                .AddFilter("phone_number", request.PhoneNumber);

            return await ExecuteAsync<ListVerificationRequestsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SubmitVerificationRequestResponse?> Submit(
            SubmitVerificationRequestRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messaging_tollfree/verification/requests", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<SubmitVerificationRequestResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetVerificationRequestResponse?> Retrieve(string id,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_tollfree/verification/requests/{id}");

            return await ExecuteAsync<GetVerificationRequestResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteVerificationRequestResponse?> Delete(string id,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_tollfree/verification/requests/{id}", Method.Delete);

            return await ExecuteAsync<DeleteVerificationRequestResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateVerificationRequestResponse?> Update(string id,
            UpdateVerificationRequestRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_tollfree/verification/requests/{id}", Method.Patch);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateVerificationRequestResponse>(req, cancellationToken);
        }
    }
}