using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Voice.Interfaces;
using Telnyx.NET.Voice.Models.CallControlApplications.Requests;
using Telnyx.NET.Voice.Models.CallControlApplications.Responses;

namespace Telnyx.NET.Voice.Operations.ProgrammableVoice
{
    public class CallControlApplicationsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ICallControlApplicationsOperations
    {
        /// <inheritdoc />
        public async Task<ListCallControlApplicationsResponse?> List(ListCallControlApplicationsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("call_control_applications")
                .AddPagination(request.PageSize)
                .AddFilter("filter[application_name][contains]", request.ApplicationNameContains)
                .AddFilter("filter[outbound.outbound_voice_profile_id]", request.OutboundVoiceProfileId.ToString())
                .AddParameter("sort", request.Sort.ToString());

            return await ExecuteAsync<ListCallControlApplicationsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateCallControlApplicationResponse?> Create(CreateCallControlApplicationRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("call_control_applications", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreateCallControlApplicationResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveCallControlApplicationResponse?> Retrieve(long id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"call_control_applications/{id}");
            return await ExecuteAsync<RetrieveCallControlApplicationResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateCallControlApplicationResponse?> Update(long id, UpdateCallControlApplicationRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"call_control_applications/{id}", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateCallControlApplicationResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteCallControlApplicationResponse?> Delete(long id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"call_control_applications/{id}", Method.Delete);
            return await ExecuteAsync<DeleteCallControlApplicationResponse>(req, cancellationToken);
        }
    }
}
