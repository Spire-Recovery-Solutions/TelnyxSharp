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
            .AddFilter("filter[leg_id]", request.LegId)
            .AddFilter("filter[application_session_id]", request.ApplicationSessionId)
            .AddFilter("filter[connection_id]", request.ConnectionId)
            .AddFilter("filter[product]", request.Product)
            .AddFilter("filter[from]", request.From)
            .AddFilter("filter[to]", request.To)
            .AddFilter("filter[failed]", request.Failed)
            .AddFilter("filter[type]", request.Type)
            .AddFilter("filter[name]", request.Name)
            .AddFilter("filter[occurred_at][gt]", request.OccurredAtGt)
            .AddFilter("filter[occurred_at][gte]", request.OccurredAtGte)
            .AddFilter("filter[occurred_at][lt]", request.OccurredAtLt)
            .AddFilter("filter[occurred_at][lte]", request.OccurredAtLte)
            .AddFilter("filter[occurred_at][eq]", request.OccurredAtEq)
            .AddPagination(request.PageSize);

            return await ExecuteAsync<ListCallEventsResponse>(req, cancellationToken);
        }
    }
}
