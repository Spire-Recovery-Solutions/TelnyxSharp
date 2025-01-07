using System.Text.Json;
using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Messaging.Models;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging;
public interface IMessagingProfileOperations
{
    Task<MessagingProfilesResponse?> List(MessagingProfilesRequest request, CancellationToken cancellationToken = default);
    Task<CreateMessagingProfileResponse?> Create(CreateMessagingProfileRequest request, CancellationToken cancellationToken = default);
    Task<RetrieveMessagingProfileResponse> Retrieve(string id, CancellationToken cancellationToken = default);
    Task<UpdateMessagingProfileResponse?> Update(string id, UpdateMessagingProfileRequest request, CancellationToken cancellationToken = default);
    Task<DeleteMessagingProfileResponse?> Delete(string id, CancellationToken cancellationToken = default);
    Task<MessagingProfilePhoneNumberResponse?> ListPhoneNumbers(string id, MessagingProfilePhoneNumberRequest request, CancellationToken cancellationToken = default);
    Task<MessagingProfileShortCodeResponse?> ListShortCodes(string id, MessagingProfileShortCodeRequest request, CancellationToken cancellationToken = default);
    Task<RetrieveMessagingProfileMetricsResponse?> RetrieveMetrics(string id, RetrieveMessagingProfileMetricsRequest request, CancellationToken cancellationToken = default);
    Task<MessagingProfileMetricsResponse?> ListMetrics(MessagingProfileMetricsRequest request, CancellationToken cancellationToken = default);
}
public class MessagingProfileOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IMessagingProfileOperations
{
    public async Task<MessagingProfilesResponse?> List(MessagingProfilesRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messaging_profiles")
            .AddPagination(request.PageSize)
            .AddFilter("name", request.NameFilter);
            
        return await ExecuteAsync<MessagingProfilesResponse>(req, cancellationToken);
    }

    public async Task<CreateMessagingProfileResponse?> Create(CreateMessagingProfileRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messaging_profiles", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        
        return await ExecuteAsync<CreateMessagingProfileResponse>(req, cancellationToken);
    }

    public async Task<RetrieveMessagingProfileResponse> Retrieve(string id, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}");
        return await ExecuteAsync<RetrieveMessagingProfileResponse>(req, cancellationToken);
    }

    public async Task<UpdateMessagingProfileResponse?> Update(string id, UpdateMessagingProfileRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}", Method.Patch);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        
        return await ExecuteAsync<UpdateMessagingProfileResponse>(req, cancellationToken);
    }

    public async Task<DeleteMessagingProfileResponse?> Delete(string id, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}", Method.Delete);
        return await ExecuteAsync<DeleteMessagingProfileResponse>(req, cancellationToken);
    }

    public async Task<MessagingProfilePhoneNumberResponse?> ListPhoneNumbers(string id, MessagingProfilePhoneNumberRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}/phone_numbers")
            .AddPagination(request.PageSize);
            
        return await ExecuteAsync<MessagingProfilePhoneNumberResponse>(req, cancellationToken);
    }

    public async Task<MessagingProfileShortCodeResponse?> ListShortCodes(string id, MessagingProfileShortCodeRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}/short_codes")
            .AddPagination(request.PageSize);
            
        return await ExecuteAsync<MessagingProfileShortCodeResponse>(req, cancellationToken);
    }

    public async Task<RetrieveMessagingProfileMetricsResponse?> RetrieveMetrics(string id, RetrieveMessagingProfileMetricsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}/metrics")
            .AddFilter("time_frame", request.TimeFrame);
            
        return await ExecuteAsync<RetrieveMessagingProfileMetricsResponse>(req, cancellationToken);
    }

    public async Task<MessagingProfileMetricsResponse?> ListMetrics(MessagingProfileMetricsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profile_metrics")
            .AddPagination(request.PageSize)
            .AddFilter("id", request.MessagingProfileId.ToString())
            .AddFilter("time_frame", request.TimeFrame);
            
        return await ExecuteAsync<MessagingProfileMetricsResponse>(req, cancellationToken);
    }
}