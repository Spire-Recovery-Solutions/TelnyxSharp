using Polly.Retry;
using RestSharp;
using TelnyxSharp.Base;
using TelnyxSharp.DetailRecords.Interfaces;
using TelnyxSharp.DetailRecords.Models.Requests;
using TelnyxSharp.DetailRecords.Models.Responses;

namespace TelnyxSharp.DetailRecords.Operations
{
    public class DetailRecordsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IDetailRecordsOperations
    {
        /// <inheritdoc />
        public async Task<DetailRecordSearchResponse?> Search(DetailRecordSearchRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("detail_records")
                .AddPagination(request.PageSize)
                .AddFilter("filter[record_type]", request.RecordType)
                .AddFilter("filter[date_range]", request.DateRange);

            if (request.Filters != null && request.Filters.Count > 0)
            {
                foreach (var filter in request.Filters)
                {
                    req = req.AddFilter($"filter[{filter.Field}]", filter.Value, filter.Operator);
                }
            }

            if (request.Sort != null && request.Sort.Count > 0)
            {
                req = req.AddFilterList("sort", request.Sort);
            }

            return await ExecuteAsync<DetailRecordSearchResponse>(req, cancellationToken);
        }
    }
}