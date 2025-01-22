using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.BulkPhoneNumberOperations;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.BulkPhoneNumberOperations;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers
{
    public class BulkPhoneNumberOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IBulkPhoneNumberOperations
    {
        /// <inheritdoc />
        public async Task<ListNumbersJobsResponse> ListPhoneNumbersJobs(ListNumbersJobsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_numbers/jobs")
                .AddFilter("filter[type]", request.Type)
                .AddPagination(request.PageSize)
                .AddFilter("sort", request.Sort);

            return await ExecuteAsync<ListNumbersJobsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveNumbersJobResponse> GetPhoneNumbersJob(string jobId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/jobs/{jobId}");
            return await ExecuteAsync<RetrieveNumbersJobResponse>(req, cancellationToken);
        }

        
        /// <inheritdoc />
        public async Task<UpdateEmergencySettingsResponse> UpdateEmergencySettings(UpdateEmergencySettingsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_numbers/jobs/update_emergency_settings", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateEmergencySettingsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateNumbersBatchResponse> UpdateNumbersBatch(UpdateNumbersBatchRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_numbers/jobs/update_phone_numbers", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateNumbersBatchResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteNumbersBatchResponse> DeleteNumbersBatch(DeleteNumbersBatchRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_numbers/jobs/delete_phone_numbers", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<DeleteNumbersBatchResponse>(req, cancellationToken);
        }
    }
}
