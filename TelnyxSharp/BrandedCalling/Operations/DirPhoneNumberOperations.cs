using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.BrandedCalling.Interfaces;
using TelnyxSharp.BrandedCalling.Models.PhoneNumbers.Requests;
using TelnyxSharp.BrandedCalling.Models.PhoneNumbers.Responses;

namespace TelnyxSharp.BrandedCalling.Operations
{
    /// <summary>
    /// Provides operations for managing the phone numbers attached to a Display Identity Record (DIR).
    /// Implements the <see cref="IDirPhoneNumberOperations"/> interface.
    /// </summary>
    public class DirPhoneNumberOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        : BaseOperations(client, rateLimitRetryPolicy), IDirPhoneNumberOperations
    {
        /// <inheritdoc />
        public async Task<ListDirPhoneNumbersResponse> List(string dirId, ListDirPhoneNumbersRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}/phone_numbers");
            req.AddFilter("status", request.Status);
            req.AddPagination(request.PageSize);

            return await ExecuteAsync<ListDirPhoneNumbersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<AddDirPhoneNumbersResponse> Add(string dirId, AddDirPhoneNumbersRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}/phone_numbers", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<AddDirPhoneNumbersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteDirPhoneNumbersResponse> Delete(string dirId, DeleteDirPhoneNumbersRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}/phone_numbers", TelnyxMethod.Delete);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<DeleteDirPhoneNumbersResponse>(req, cancellationToken);
        }
    }
}
