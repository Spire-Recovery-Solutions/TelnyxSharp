using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.ShortCodes.Requests;
using TelnyxSharp.Messaging.Models.ShortCodes.Responses;

namespace TelnyxSharp.Messaging.Operations.SmsMms;

public class ShortCodeOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IShortCodeOperations
{
    /// <inheritdoc />
    public async Task<ListShortCodesResponse?> List(ListShortCodesRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("short_codes")
            .AddPagination(request.PageSize)
            .AddFilter("filter[messaging_profile_id]", request.MessagingProfileId);

        return await ExecuteAsync<ListShortCodesResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrieveShortCodeResponse?> Retrieve(string shortCodeId, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"short_codes/{shortCodeId}");
        return await ExecuteAsync<RetrieveShortCodeResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateShortCodeResponse?> Update(string shortCodeId, UpdateShortCodeRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"short_codes/{shortCodeId}", Method.Patch);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateShortCodeResponse>(req, cancellationToken);
    }
}