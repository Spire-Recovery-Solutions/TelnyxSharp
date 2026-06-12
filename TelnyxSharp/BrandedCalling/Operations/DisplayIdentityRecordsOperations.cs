using Polly.RateLimit;
using Polly.Retry;
using System.Net;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.BrandedCalling.Interfaces;
using TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Requests;
using TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Responses;

namespace TelnyxSharp.BrandedCalling.Operations
{
    /// <summary>
    /// Provides operations for managing Display Identity Records (DIRs) in the Branded Calling API.
    /// Implements the <see cref="IDisplayIdentityRecordsOperations"/> interface.
    /// </summary>
    public class DisplayIdentityRecordsOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        : BaseOperations(client, rateLimitRetryPolicy), IDisplayIdentityRecordsOperations
    {
        /// <inheritdoc />
        public async Task<ListDirsResponse> List(ListDirsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("dir");
            req.AddFilter("sort", request.Sort);
            req.AddFilter("filter[enterprise_id]", request.EnterpriseId);
            req.AddFilter("filter[status]", request.Status);
            req.AddFilter("filter[display_name][contains]", request.DisplayNameContains);
            req.AddFilter("filter[call_reason][contains]", request.CallReasonContains);
            req.AddFilter("filter[expiring_at][gte]", request.ExpiringAtGte);
            req.AddFilter("filter[expiring_at][lte]", request.ExpiringAtLte);
            req.AddPagination(request.PageSize);

            return await ExecuteAsync<ListDirsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListDirsResponse> ListByEnterprise(string enterpriseId, ListDirsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"enterprises/{enterpriseId}/dir");
            req.AddFilter("sort", request.Sort);
            req.AddFilter("filter[status]", request.Status);
            req.AddFilter("filter[display_name][contains]", request.DisplayNameContains);
            req.AddFilter("filter[call_reason][contains]", request.CallReasonContains);
            req.AddFilter("filter[expiring_at][gte]", request.ExpiringAtGte);
            req.AddFilter("filter[expiring_at][lte]", request.ExpiringAtLte);
            req.AddFilter("filter[expiring_within_days]", request.ExpiringWithinDays);
            req.AddPagination(request.PageSize);

            return await ExecuteAsync<ListDirsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DirResponse> Create(string enterpriseId, CreateDirRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"enterprises/{enterpriseId}/dir", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<DirResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DirResponse> Retrieve(string dirId,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}");

            return await ExecuteAsync<DirResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DirResponse> Update(string dirId, UpdateDirRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}", TelnyxMethod.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<DirResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteDirResponse> Delete(string dirId,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}", TelnyxMethod.Delete);

            return await ExecuteAsync<DeleteDirResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DirResponse> Submit(string dirId,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}/submit", TelnyxMethod.Post);

            return await ExecuteAsync<DirResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RenderDirLoaResponse> RenderLoa(string dirId, RenderDirLoaRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}/loa", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            // The LOA endpoint returns the rendered PDF as a binary body (application/pdf),
            // so the JSON deserialization path in ExecuteAsync does not apply here.
            return await RateLimitRetryPolicy.ExecuteAsync(async () =>
            {
                req.AddOrUpdateHeader("X-Correlation-ID", Guid.NewGuid());

                using var requestMessage = req.BuildHttpRequestMessage();
                var response = await Client.SendAsync(requestMessage, cancellationToken);

                if (response.StatusCode == HttpStatusCode.TooManyRequests)
                {
                    string? resetSeconds = null;
                    if (response.Headers.TryGetValues("x-ratelimit-reset", out var values))
                        resetSeconds = values.FirstOrDefault();

                    var delay = int.TryParse(resetSeconds, out var parsedDelay) ? parsedDelay : 1;
                    throw new RateLimitRejectedException(TimeSpan.FromSeconds(delay));
                }

                var result = new RenderDirLoaResponse
                {
                    StatusCode = response.StatusCode,
                    IsSuccessful = response.IsSuccessStatusCode,
                    ErrorMessage = null
                };

                if (response.IsSuccessStatusCode)
                    result.Content = await response.Content.ReadAsByteArrayAsync(cancellationToken);

                return result;
            });
        }
    }
}
