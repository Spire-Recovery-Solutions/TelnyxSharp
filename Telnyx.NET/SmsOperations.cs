using System.Text.Json;
using Polly.Retry;
using RestSharp;
using Telnyx.NET.Models;

namespace Telnyx.NET;
public interface ISmsOperations
{
    Task<SendMessageResponse> Send(SendMessageRequest request, CancellationToken cancellationToken = default);
    Task<NumberPoolMessageResponse?> SendUsingNumberPool(NumberPoolMessageRequest request, CancellationToken cancellationToken = default);
    Task<LongCodeMessageResponse?> SendLongCode(LongCodeMessageRequest request, CancellationToken cancellationToken = default);
    Task<ShortCodeMessageResponse?> SendShortCode(ShortCodeMessageRequest request, CancellationToken cancellationToken = default);
    Task<GroupMmsMessageResponse?> SendGroupMms(GroupMmsMessageRequest request, CancellationToken cancellationToken = default);
    Task<RetrieveMessageResponse?> RetrieveMessage(string id, CancellationToken cancellationToken = default);
}
public class SmsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), ISmsOperations
{
    public async Task<SendMessageResponse> Send(SendMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<SendMessageResponse>(req, cancellationToken);
    }

    public async Task<NumberPoolMessageResponse?> SendUsingNumberPool(NumberPoolMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/number_pool", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<NumberPoolMessageResponse>(req, cancellationToken);
    }

    public async Task<LongCodeMessageResponse?> SendLongCode(LongCodeMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/long_code", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<LongCodeMessageResponse>(req, cancellationToken);
    }

    public async Task<ShortCodeMessageResponse?> SendShortCode(ShortCodeMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/short_code", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<ShortCodeMessageResponse>(req, cancellationToken);
    }

    public async Task<GroupMmsMessageResponse?> SendGroupMms(GroupMmsMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/group_mms", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<GroupMmsMessageResponse>(req, cancellationToken);
    }

    public async Task<RetrieveMessageResponse?> RetrieveMessage(string id, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messages/{id}");
        return await ExecuteAsync<RetrieveMessageResponse>(req, cancellationToken);
    }
}