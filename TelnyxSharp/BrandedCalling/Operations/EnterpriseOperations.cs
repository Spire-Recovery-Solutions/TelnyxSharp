using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.BrandedCalling.Interfaces;
using TelnyxSharp.BrandedCalling.Models.Enterprises.Requests;
using TelnyxSharp.BrandedCalling.Models.Enterprises.Responses;

namespace TelnyxSharp.BrandedCalling.Operations
{
    /// <summary>
    /// Provides operations for managing enterprises in the Branded Calling API.
    /// Implements the <see cref="IEnterpriseOperations"/> interface.
    /// </summary>
    public class EnterpriseOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        : BaseOperations(client, rateLimitRetryPolicy), IEnterpriseOperations
    {
        /// <inheritdoc />
        public async Task<ListEnterprisesResponse> List(ListEnterprisesRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("enterprises");
            req.AddFilter("filter[legal_name][contains]", request.LegalName);
            req.AddPagination(request.PageSize);

            return await ExecuteAsync<ListEnterprisesResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<EnterpriseResponse> Create(CreateEnterpriseRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest("enterprises", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<EnterpriseResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<EnterpriseResponse> Retrieve(string enterpriseId,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"enterprises/{enterpriseId}");

            return await ExecuteAsync<EnterpriseResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<EnterpriseResponse> Update(string enterpriseId, UpdateEnterpriseRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"enterprises/{enterpriseId}", TelnyxMethod.Put);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<EnterpriseResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteEnterpriseResponse> Delete(string enterpriseId,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"enterprises/{enterpriseId}", TelnyxMethod.Delete);

            return await ExecuteAsync<DeleteEnterpriseResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<EnterpriseResponse> ActivateBrandedCalling(string enterpriseId,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"enterprises/{enterpriseId}/branded_calling", TelnyxMethod.Post);

            return await ExecuteAsync<EnterpriseResponse>(req, cancellationToken);
        }
    }
}
