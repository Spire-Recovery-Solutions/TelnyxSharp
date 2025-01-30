using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.CsvDownloads;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.CsvDowloads;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.CsvDownloads;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers
{
    public class CsvDownloadsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ICsvDownloadsOperations
    {
        /// <inheritdoc />
        public async Task<ListCsvDownloadsResponse> List(ListCsvDownloadsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("phone_numbers/csv_downloads")
                                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListCsvDownloadsResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<CreateCsvDownloadResponse> Create(CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest("phone_numbers/csv_downloads", Method.Post);
            return await ExecuteAsync<CreateCsvDownloadResponse>(restRequest, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<GetCsvDownloadResponse> Get(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/csv_downloads/{id}");
            return await ExecuteAsync<GetCsvDownloadResponse>(req, cancellationToken);
        }
    }
}
