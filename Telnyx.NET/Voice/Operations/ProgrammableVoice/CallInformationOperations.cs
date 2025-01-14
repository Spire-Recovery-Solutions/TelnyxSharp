using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Voice.Interfaces;
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
    }
}
