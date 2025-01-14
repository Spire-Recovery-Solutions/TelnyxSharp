using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Voice.Interfaces;
using Telnyx.NET.Voice.Models.Debugging.Requests;
using Telnyx.NET.Voice.Models.Debugging.Responses;

namespace Telnyx.NET.Voice.Operations.ProgrammableVoice
{
    internal class DebuggingOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IDebuggingOperations
    {
         /// <inheritdoc />
        public async Task<ListCallEventsResponse?> ListCallEvents(ListCallEventsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("call_events")
                .AddFilter("leg_id", request.LegId)
                .AddFilter("application_session_id", request.ApplicationSessionId)
                .AddFilter("connection_id", request.ConnectionId)
                .AddFilter("product", request.Product)
                .AddFilter("from", request.From)
                .AddFilter("to", request.To)
                .AddFilter("failed", request.Failed.ToString()?.ToLower())
                .AddFilter("type", request.Type)
                .AddFilter("name", request.Name)
                .AddFilter("occurred_at[gt]", request.OccurredAtGt)
                .AddFilter("occurred_at[gte]", request.OccurredAtGte)
                .AddFilter("occurred_at[lt]", request.OccurredAtLt)
                .AddFilter("occurred_at[lte]", request.OccurredAtLte)
                .AddFilter("occurred_at[eq]", request.OccurredAtEq)
                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListCallEventsResponse>(req, cancellationToken);
        }
    }
}
