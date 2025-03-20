using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.V1Operations.Interfaces;
using TelnyxSharp.V1Operations.Models.Requests;
using TelnyxSharp.V1Operations.Models.Responses;

namespace TelnyxSharp.V1Operations.Operations
{
    /// <summary>
    /// Implements operations for CDR requests.
    /// </summary>
    public class CdrRequestsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        : BaseOperations(client, rateLimitRetryPolicy), ICdrRequestsOperations
    {
        /// <inheritdoc />
        public async Task<CreateCdrRequestsResponse> Create(CreateCdrRequestsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("reporting/cdr_requests", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreateCdrRequestsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListCdrRequestsResponse> List(ListCdrRequestsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("reporting/cdr_requests", Method.Get)
                .AddPagination(request.PageSize);
            return await ExecuteAsync<ListCdrRequestsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetCdrRequestsResponse> Get(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"reporting/cdr_requests/{id}", Method.Get);
            return await ExecuteAsync<GetCdrRequestsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteCdrRequestsResponse> Delete(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"reporting/cdr_requests/{id}", Method.Delete);
            return await ExecuteAsync<DeleteCdrRequestsResponse>(req, cancellationToken);
        }
    }
}
