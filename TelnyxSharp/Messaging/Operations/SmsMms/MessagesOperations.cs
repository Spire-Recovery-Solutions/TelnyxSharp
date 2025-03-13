using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.Messages.Requests;
using TelnyxSharp.Messaging.Models.Messages.Responses;

namespace TelnyxSharp.Messaging.Operations.SmsMms;

public class MessagesOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IMessagesOperations
{
    /// <inheritdoc />
    public async Task<SendMessageResponse> Send(SendMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<SendMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LongCodeMessageResponse?> SendLongCode(LongCodeMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/long_code", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<LongCodeMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NumberPoolMessageResponse?> SendUsingNumberPool(NumberPoolMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/number_pool", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<NumberPoolMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ShortCodeMessageResponse?> SendShortCode(ShortCodeMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/short_code", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<ShortCodeMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GroupMmsMessageResponse?> SendGroupMms(GroupMmsMessageRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/group_mms", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<GroupMmsMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrieveMessageResponse?> RetrieveMessage(string id, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messages/{id}");
        return await ExecuteAsync<RetrieveMessageResponse>(req, cancellationToken);
    }
}