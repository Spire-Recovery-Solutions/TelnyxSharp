using Polly.Retry;
using RestSharp;
using TelnyxSharp.Base;
using TelnyxSharp.Voice.Interfaces;
using TelnyxSharp.Voice.Models.CallInformation.Requests;
using TelnyxSharp.Voice.Models.CallInformation.Responses;

namespace TelnyxSharp.Voice.Operations.ProgrammableVoice
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
                .AddFilter("page[limit]", request.PageSize)
                .AddFilter("page[after]", request.PageAfter)
                .AddFilter("page[before]", request.PageBefore);

            return await ExecuteAsync<ListActiveCallsResponse>(req, cancellationToken);
        }
    }
}
