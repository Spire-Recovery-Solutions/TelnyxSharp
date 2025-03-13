using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.Brands.Requests;
using TelnyxSharp.Messaging.Models.Brands.Responses;

namespace TelnyxSharp.Messaging.Operations.TenDlc
{
    public class BrandOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IBrandOperations
    {
        /// <inheritdoc />
        public async Task<ListBrandsResponse?> ListBrandsAsync(ListBrandsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand")
                .AddFilter("recordsPerPage", request.PageSize)
                .AddFilter("sort", request.Sort)
                .AddFilter("displayName", request.DisplayName)
                .AddFilter("entityType", request.EntityType)
                .AddFilter("state", request.State)
                .AddFilter("country", request.Country)
                .AddFilter("brandId", request.BrandId)
                .AddFilter("tcrBrandId", request.TcrBrandId);

            return await ExecuteAsync<ListBrandsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateBrandResponse?> Create(CreateBrandRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("10dlc/brand", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreateBrandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetBrandResponse?> Retrieve(string brandId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}");

            return await ExecuteAsync<GetBrandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateBrandResponse?> Update(string brandId, UpdateBrandRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}", Method.Put);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateBrandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteBrandResponse?> Delete(string brandId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}", Method.Delete);

            return await ExecuteAsync<DeleteBrandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ResendBrand2FAEmailResponse?> Resend2FAEmailAsync(string brandId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}/2faEmail", Method.Post);

            return await ExecuteAsync<ResendBrand2FAEmailResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RevetBrandResponse?> Revet(string brandId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}/revet", Method.Put);

            return await ExecuteAsync<RevetBrandResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListExternalVettingResponse?> ListExternalVetting(string brandId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}/externalVetting");

            return await ExecuteAsync<ListExternalVettingResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ImportExternalVettingResponse?> ImportExternalVettingRecord(string brandId,
            ImportExternalVettingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}/externalVetting", Method.Put);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<ImportExternalVettingResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<OrderExternalVettingResponse?> OrderExternalVetting(string brandId,
            OrderExternalVettingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}/externalVetting", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<OrderExternalVettingResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetBrandFeedbackResponse?> GetFeedback(string brandId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/feedback/{brandId}");

            return await ExecuteAsync<GetBrandFeedbackResponse>(req, cancellationToken);
        }
    }
}