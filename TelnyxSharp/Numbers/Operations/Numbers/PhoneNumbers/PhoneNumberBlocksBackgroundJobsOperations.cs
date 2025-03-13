using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberBlocksBackgroundJobs;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlocksBackgroundJobs;

namespace TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers
{
    public class PhoneNumberBlocksBackgroundJobsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberBlocksBackgroundJobsOperations
    {
        /// <inheritdoc />
        public async Task<ListPhoneNumberBlockJobsResponse> List(ListPhoneNumberBlockJobsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_number_blocks/jobs")
                .AddFilter("filter[type]", request.Type)
                .AddFilter("filter[status]", request.Status)
                .AddPagination(request.PageSize)
                .AddFilter("sort", request.Sort);

            return await ExecuteAsync<ListPhoneNumberBlockJobsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetPhoneNumberBlocksJobResponse> Get(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_number_blocks/jobs/{id}");
            return await ExecuteAsync<GetPhoneNumberBlocksJobResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<DeletePhoneNumberBlockResponse> Delete(DeletePhoneNumberBlockRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_number_blocks/jobs/delete_phone_number_block", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<DeletePhoneNumberBlockResponse>(req, cancellationToken);
        }
    }
}
