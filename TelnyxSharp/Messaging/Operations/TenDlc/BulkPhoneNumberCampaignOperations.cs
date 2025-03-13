using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.BulkPhoneNumberCampaign.Requests;
using TelnyxSharp.Messaging.Models.BulkPhoneNumberCampaign.Responses;

namespace TelnyxSharp.Messaging.Operations.TenDlc
{
    public class BulkPhoneNumberCampaignOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IBulkPhoneNumberCampaignOperations
    {
        /// <inheritdoc />
        public async Task<AssignMessagingProfileToCampaignResponse?> AssignMessagingProfile(
            AssignMessagingProfileToCampaignRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("10dlc/phoneNumberAssignmentByProfile", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<AssignMessagingProfileToCampaignResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetAssignmentTaskStatusResponse?> GetAssignmentTaskStatus(string taskId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/phoneNumberAssignmentByProfile/{taskId}");

            return await ExecuteAsync<GetAssignmentTaskStatusResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetPhoneNumberStatusResponse?> GetPhoneNumberStatus(string taskId,
            GetPhoneNumberStatusRequest request, CancellationToken cancellationToken = default)
        {
            var req =
                new RestRequest($"10dlc/phoneNumberAssignmentByProfile/{taskId}/phoneNumbers")
                .AddFilter("recordsPerPage", request.PageSize);

            return await ExecuteAsync<GetPhoneNumberStatusResponse>(req, cancellationToken);
        }
    }
}