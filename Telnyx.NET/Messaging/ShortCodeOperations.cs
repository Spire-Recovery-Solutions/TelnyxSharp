using System.Text.Json;
using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging;
public interface IShortCodeOperations
{
    Task<ListShortCodesResponse?> List(ListShortCodesRequest request, CancellationToken cancellationToken = default);
    Task<RetrieveShortCodeResponse?> Retrieve(string shortCodeId, CancellationToken cancellationToken = default);
    Task<UpdateShortCodeResponse?> Update(string shortCodeId, UpdateShortCodeRequest request, CancellationToken cancellationToken = default);
}
public class ShortCodeOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IShortCodeOperations
{
    public async Task<ListShortCodesResponse?> List(ListShortCodesRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("short_codes")
            .AddPagination(request.PageSize)
            .AddFilter("messaging_profile_id", request.MessagingProfileId);
            
        return await ExecuteAsync<ListShortCodesResponse>(req, cancellationToken);
    }

    public async Task<RetrieveShortCodeResponse?> Retrieve(string shortCodeId, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"short_codes/{shortCodeId}");
        return await ExecuteAsync<RetrieveShortCodeResponse>(req, cancellationToken);
    }

    public async Task<UpdateShortCodeResponse?> Update(string shortCodeId, UpdateShortCodeRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"short_codes/{shortCodeId}", Method.Patch);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        
        return await ExecuteAsync<UpdateShortCodeResponse>(req, cancellationToken);
    }
}