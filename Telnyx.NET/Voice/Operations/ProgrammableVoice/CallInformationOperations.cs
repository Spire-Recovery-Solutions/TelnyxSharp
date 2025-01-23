using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Voice.Interfaces;
using Telnyx.NET.Voice.Models.CallInformation.Requests;
using Telnyx.NET.Voice.Models.CallInformation.Responses;

namespace Telnyx.NET.Voice.Operations.ProgrammableVoice
{
    public class CallInformationOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ICallInformationOperations
    {
        /// <inheritdoc />
        public async Task<RetrieveCallResponse?> RetrieveCall(string callControlId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}");
            return await ExecuteAsync<RetrieveCallResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListActiveCallsResponse?> ListActiveCalls(string connectionId, ListActiveCallsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"connections/{connectionId}/active_calls")
                .AddFilter("page[limit]", request.PageSize.ToString())
                .AddFilter("page[after]", request.PageAfter)
                .AddFilter("page[before]", request.PageBefore);

            return await ExecuteAsync<ListActiveCallsResponse>(req, cancellationToken);
        }
    }
}
