using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.Messages.Requests;
using TelnyxSharp.Messaging.Models.Messages.Responses;

namespace TelnyxSharp.Messaging.Operations.SmsMms;

public class MessagesOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IMessagesOperations
{
    /// <inheritdoc />
    public async Task<SendMessageResponse> Send(SendMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest("messages", TelnyxMethod.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<SendMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LongCodeMessageResponse?> SendLongCode(LongCodeMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest("messages/long_code", TelnyxMethod.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<LongCodeMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NumberPoolMessageResponse?> SendUsingNumberPool(NumberPoolMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest("messages/number_pool", TelnyxMethod.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<NumberPoolMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ShortCodeMessageResponse?> SendShortCode(ShortCodeMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest("messages/short_code", TelnyxMethod.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<ShortCodeMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GroupMmsMessageResponse?> SendGroupMms(GroupMmsMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest("messages/group_mms", TelnyxMethod.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<GroupMmsMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrieveMessageResponse?> RetrieveMessage(string id, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest($"messages/{id}");
        return await ExecuteAsync<RetrieveMessageResponse>(req, cancellationToken);
    }
}