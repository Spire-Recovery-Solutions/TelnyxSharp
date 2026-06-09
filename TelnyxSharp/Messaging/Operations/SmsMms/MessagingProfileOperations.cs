using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Models.MessagesProfile.Requests;
using TelnyxSharp.Messaging.Models.MessagesProfile.Responses;

namespace TelnyxSharp.Messaging.Operations.SmsMms;

public class MessagingProfileOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IMessagingProfileOperations
{
    /// <inheritdoc />
    public async Task<MessagingProfilesResponse?> List(MessagingProfilesRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest("messaging_profiles")
            .AddPagination(request.PageSize)
            .AddFilter("filter[name]", request.NameFilter);

        return await ExecuteAsync<MessagingProfilesResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CreateMessagingProfileResponse?> Create(CreateMessagingProfileRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest("messaging_profiles", TelnyxMethod.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<CreateMessagingProfileResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrieveMessagingProfileResponse> Retrieve(string id, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest($"messaging_profiles/{id}");
        return await ExecuteAsync<RetrieveMessagingProfileResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateMessagingProfileResponse?> Update(string id, UpdateMessagingProfileRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest($"messaging_profiles/{id}", TelnyxMethod.Patch);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateMessagingProfileResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DeleteMessagingProfileResponse?> Delete(string id, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest($"messaging_profiles/{id}", TelnyxMethod.Delete);
        return await ExecuteAsync<DeleteMessagingProfileResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MessagingProfilePhoneNumberResponse?> ListPhoneNumbers(string id, MessagingProfilePhoneNumberRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest($"messaging_profiles/{id}/phone_numbers")
            .AddPagination(request.PageSize);

        return await ExecuteAsync<MessagingProfilePhoneNumberResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MessagingProfileShortCodeResponse?> ListShortCodes(string id, MessagingProfileShortCodeRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest($"messaging_profiles/{id}/short_codes")
            .AddPagination(request.PageSize);

        return await ExecuteAsync<MessagingProfileShortCodeResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrieveMessagingProfileMetricsResponse?> RetrieveMetrics(string id, RetrieveMessagingProfileMetricsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest($"messaging_profiles/{id}/metrics")
            .AddFilter("time_frame", request.TimeFrame);

        return await ExecuteAsync<RetrieveMessagingProfileMetricsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MessagingProfileMetricsResponse?> ListMetrics(MessagingProfileMetricsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new TelnyxRequest("messaging_profile_metrics")
            .AddPagination(request.PageSize)
            .AddFilter("id", request.MessagingProfileId)
            .AddFilter("time_frame", request.TimeFrame);

        return await ExecuteAsync<MessagingProfileMetricsResponse>(req, cancellationToken);
    }
}