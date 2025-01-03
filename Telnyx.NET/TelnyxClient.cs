using Polly;
using Polly.RateLimit;
using Polly.Retry;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections;
using System.Net;
using System.Text.Json;
using Telnyx.NET.Enums;
using Telnyx.NET.Interfaces;
using Telnyx.NET.Models;

namespace Telnyx.NET;

public class TelnyxClient : ITelnyxClient, IDisposable
{
    private readonly IRestClient _client;
    private static readonly string DefaultLogPath = Path.Combine(Path.GetTempPath(), "TelnyxSDK", "logs");
    private readonly StreamWriter? _logWriter;
    private readonly FileStream? _logFileStream;
    private readonly AsyncRetryPolicy _rateLimitRetryPolicy;

    // Constructor chaining for backwards compatibility

    public TelnyxClient(string apiKey)
    {
        if (!string.IsNullOrEmpty(apiKey)) // Check if we're in test mode
        {
            Directory.CreateDirectory(DefaultLogPath);
            var logFileName = $"telnyx-debug-{DateTime.Now:yyyy-MM-dd}.log";
            var logFilePath = Path.Combine(DefaultLogPath, logFileName);

            _logFileStream = new FileStream(logFilePath, FileMode.Append, FileAccess.Write, FileShare.Read);
            _logWriter = new StreamWriter(_logFileStream) { AutoFlush = true };

            _logWriter.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] TelnyxSDK Debug Log File: {logFilePath}");
            _logWriter.WriteLine(
                $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] Session Started: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        }

        var options = new RestClientOptions("https://api.telnyx.com/v2/")
        {
            Authenticator = new JwtAuthenticator(apiKey),
            ThrowOnDeserializationError = false,
            ThrowOnAnyError = false,
        };

        // Only add logging interceptor if not in test mode
        if (_logWriter != null)
        {
            options.Interceptors = [new TelnyxLoggingInterceptor(_logWriter)];
        }

        _rateLimitRetryPolicy = Policy
            .Handle<RateLimitRejectedException>()
            .WaitAndRetryAsync(
                retryCount: 3, // Or could be infinite with WaitAndRetryForeverAsync
                sleepDurationProvider: (attempt, exception, context) =>
                {
                    var ex = exception as RateLimitRejectedException;
                    // Get the delay from the exception which will contain our header value
                    return ex?.RetryAfter ?? TimeSpan.FromSeconds(1);
                },
                onRetryAsync: (exception, timeSpan, attempt, context) => Task.CompletedTask);

        _client = new RestClient(options);
    }

    /// <inheritdoc />
    public async Task<NumberLookupResponse> NumberLookup(NumberLookupRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"number_lookup/{request.PhoneNumber}");

        foreach (var type in request.NumberLookupTypes)
        {
            switch (type)
            {
                case NumberLookupType.CallerName:
                    req.AddFilter("type", "caller-name");
                    break;
                case NumberLookupType.Carrier:
                    req.AddFilter("type", "carrier");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        return await ExecuteAsync<NumberLookupResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AvailablePhoneNumbersResponse> AvailablePhoneNumbers(AvailablePhoneNumbersRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("available_phone_numbers")
            .AddFilter("administrative_area", request.AdministrativeArea)
            .AddFilter("contains", request.Contains)
            .AddFilter("country_code", request.CountryCode)
            .AddFilter("ends_with", request.EndsWith)
            .AddFilter("features", request.Features)
            .AddFilter("locality", request.Locality)
            .AddFilter("phone_number_type", request.PhoneNumberType)
            .AddFilter("rate_center", request.RateCenter)
            .AddFilter("starts_with", request.StartsWith)
            .AddFilter("limit", request.Limit.ToString())
            .AddFilter("national_destination_code", request.NationalDestinationCode?.ToString())
            .AddFilter("quickship", request.Quickship.ToString())
            .AddFilter("best_effort", request.BestEffort.ToString())
            .AddFilter("reservable", request.Reservable.ToString())
            .AddFilter("exclude_held_numbers", request.ExcludeHeldNumbers.ToString());

        return await ExecuteAsync<AvailablePhoneNumbersResponse>(req, cancellationToken);
    }


    /// <inheritdoc />
    public async Task<ListNumberOrdersResponse> ListNumberOrders(ListNumberOrdersRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("number_orders")
            .AddFilter("status", request.Status)
            .AddFilter("created_at[gt]", request.CreatedAfter)
            .AddFilter("created_at[lt]", request.CreatedBefore)
            .AddFilter("customer_reference", request.CustomerReference)
            .AddFilter("phone_numbers_count", request.PhoneNumberCount?.ToString())
            .AddFilter("requirements_met", request.RequirementsMet.ToString())
            .AddPagination(request.PageSize);
        return await ExecuteAsync<ListNumberOrdersResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrieveMessagingProfileResponse> RetrieveMessagingProfile(string id,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}");
        return await ExecuteAsync<RetrieveMessagingProfileResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetNumberOrderResponse> GetNumberOrder(string numberOrderId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"number_orders/{numberOrderId}");
        return await ExecuteAsync<GetNumberOrderResponse>(req, cancellationToken);
    }

    public async Task<CreateNumberOrderResponse> CreateNumberOrder(CreateNumberOrderRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("number_orders", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<CreateNumberOrderResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateNumberVoiceSettingsResponse> UpdateNumberVoiceSettings(string phoneNumberId,
        UpdateNumberVoiceSettingsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"phone_numbers/{phoneNumberId}/voice", Method.Patch);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateNumberVoiceSettingsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListNumbersResponse> ListNumbers(ListNumbersRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("phone_numbers").AddFilterList("tag", request.Tags)
            .AddFilter("phone_number", request.PhoneNumber)
            .AddFilter("status", request.Status)
            .AddFilter("connection_id", request.ConnectionId)
            .AddFilter("voice.connection_name[contains]", request.VoiceConnectionNameContains)
            .AddFilter("voice.connection_name[starts_with]", request.VoiceConnectionNameStartsWith)
            .AddFilter("voice.connection_name[ends_with]", request.VoiceConnectionNameEndsWith)
            .AddFilter("voice.connection_name[eq]", request.VoiceConnectionNameEquals)
            .AddFilter("usage_payment_method", request.UsagePaymentMethod)
            .AddFilter("billing_group_id", request.BillingGroupId)
            .AddFilter("emergency_address_id", request.EmergencyAddressId)
            .AddFilter("customer_reference", request.CustomerReference)
            .AddFilter("sort", request.Sort)
            .AddPagination(request.PageSize);

        return await ExecuteAsync<ListNumbersResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListPortingOrdersResponse> ListPortingOrders(ListPortingOrdersRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("porting_orders")
            .AddFilter("status", request.Status)
            .AddFilter("include_phone_numbers", request.IncludePhoneNumbers.ToString())
            .AddFilter("customer_reference", request.CustomerReference)
            .AddFilter("sort", request.Sort)
            .AddPagination(request.PageSize);

        return await ExecuteAsync<ListPortingOrdersResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListPortingPhoneNumbersResponse> ListPortingPhoneNumbers(
        ListPortingPhoneNumbersRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"porting_phone_numbers")
            .AddFilter("porting_order_id", request.PortingOrderId?.ToString())
            .AddFilterList("porting_order_id", request.PortingOrderIds)
            .AddFilter("support_key[eq]", request.SupportKeyEq)
            .AddFilterList("support_key[in]", request.SupportKeyIn)
            .AddFilter("phone_number", request.PhoneNumber)
            .AddFilterList("phone_number[in]", request.PhoneNumberIn)
            .AddFilter("porting_order_status", request.PortingOrderStatus)
            .AddFilter("activation_status", request.ActivationStatus)
            .AddFilter("portability_status", request.PortabilityStatus)
            .AddPagination(request.PageSize);

        return await ExecuteAsync<ListPortingPhoneNumbersResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CreateNumberReservationResponse> CreateNumberReservation(
        CreateNumberReservationRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"number_reservations", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<CreateNumberReservationResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateNumberConfigurationResponse> UpdateNumberConfiguration(string phoneNumberId,
        UpdateNumberConfigurationRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"phone_numbers/{phoneNumberId}", Method.Patch);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateNumberConfigurationResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DeletePhoneNumberResponse> RemoveNumber(string numberOrObjectId, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"phone_numbers/{numberOrObjectId}", Method.Delete);

        return await ExecuteAsync<DeletePhoneNumberResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SendMessageResponse> SendMessage(SendMessageRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<SendMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DialResponse> Dial(DialRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("calls", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<DialResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AnswerCallResponse> AnswerCall(string callControlId, AnswerCallRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"calls/{callControlId}/actions/answer", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<AnswerCallResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<HangupCallResponse> HangupCall(string callControlId, HangupCallRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"calls/{callControlId}/actions/hangup", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<HangupCallResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RejectCallResponse> RejectCall(string callControlId, RejectCallRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"calls/{callControlId}/actions/reject", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        return await ExecuteAsync<RejectCallResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SpeakTextResponse?> SpeakText(string callControlId, SpeakTextRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"calls/{callControlId}/actions/speak", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<SpeakTextResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<PlaybackStartResponse?> PlaybackStart(string callControlId, PlaybackStartRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"calls/{callControlId}/actions/playback_start", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<PlaybackStartResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<StopAudioPlaybackResponse?> StopAudioPlayback(string callControlId,
        StopAudioPlaybackRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"calls/{callControlId}/actions/playback_stop", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<StopAudioPlaybackResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<EnqueueCallResponse?> EnqueueCall(string callControlId, EnqueueCallRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"calls/{callControlId}/actions/enqueue", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
        var result = await ExecuteAsync<EnqueueCallResponse>(req, cancellationToken);
        return result;
    }

    /// <inheritdoc />
    public async Task<RemoveCallFromQueueResponse?> RemoveCallFromQueue(string callControlId,
        RemoveCallFromQueueRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"calls/{callControlId}/actions/leave_queue", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<RemoveCallFromQueueResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TransferCallResponse?> TransferCall(string callControlId, TransferCallRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"calls/{callControlId}/actions/transfer", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<TransferCallResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MessagingProfilesResponse?> GetMessagingProfiles(MessagingProfilesRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles").AddPagination(request.PageSize)
            .AddFilter("name", request.NameFilter);
        return await ExecuteAsync<MessagingProfilesResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CreateMessagingProfileResponse?> CreateMessagingProfile(CreateMessagingProfileRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messaging_profiles", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<CreateMessagingProfileResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateMessagingProfileResponse?> UpdateMessagingProfile(string id,
        UpdateMessagingProfileRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}", Method.Patch);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateMessagingProfileResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MessagingProfilePhoneNumberResponse?> ListMessagingProfilePhoneNumbers(
        string id,
        MessagingProfilePhoneNumberRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}/phone_numbers").AddPagination(request.PageSize);
        return await ExecuteAsync<MessagingProfilePhoneNumberResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DeleteMessagingProfileResponse?> DeleteMessagingProfile(string id,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}", Method.Delete);

        return await ExecuteAsync<DeleteMessagingProfileResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MessagingProfileShortCodeResponse?> ListMessagingProfileShortCodes(string id,
        MessagingProfileShortCodeRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}/short_codes").AddPagination(request.PageSize);
        return await ExecuteAsync<MessagingProfileShortCodeResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrieveMessagingProfileMetricsResponse?> RetrieveMessagingProfileMetrics(string id,
        RetrieveMessagingProfileMetricsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{id}/metrics").AddFilter("time_frame", request.TimeFrame);

        return await ExecuteAsync<RetrieveMessagingProfileMetricsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<MessagingProfileMetricsResponse?> ListMessagingProfileMetrics(
        MessagingProfileMetricsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profile_metrics").AddPagination(request.PageSize)
            .AddFilter("id", request.MessagingProfileId.ToString())
            .AddFilter("time_frame", request.TimeFrame);


        return await ExecuteAsync<MessagingProfileMetricsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<NumberPoolMessageResponse?> SendMessageUsingNumberPoolAsync(NumberPoolMessageRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/number_pool", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<NumberPoolMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<LongCodeMessageResponse?> SendLongCodeMessage(LongCodeMessageRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/long_code", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<LongCodeMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ShortCodeMessageResponse?> SendShortCodeMessageAsync(ShortCodeMessageRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/short_code", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<ShortCodeMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GroupMmsMessageResponse?> SendGroupMmsMessageAsync(GroupMmsMessageRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messages/group_mms", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<GroupMmsMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrieveMessageResponse?> RetrieveMessageAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messages/{id}");

        return await ExecuteAsync<RetrieveMessageResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListMessagingUrlDomainsResponse?> ListMessagingUrlDomainsAsync(
        ListMessagingUrlDomainsRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_url_domains").AddPagination(request.PageSize);

        return await ExecuteAsync<ListMessagingUrlDomainsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListShortCodesResponse?> ListShortCodesAsync(ListShortCodesRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"short_codes").AddPagination(request.PageSize)
            .AddFilter("messaging_profile_id", request.MessagingProfileId);

        return await ExecuteAsync<ListShortCodesResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrieveShortCodeResponse?> RetrieveShortCodeAsync(string shortCodeId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"short_codes/{shortCodeId}");

        return await ExecuteAsync<RetrieveShortCodeResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateShortCodeResponse?> UpdateShortCodeAsync(string shortCodeId,
        UpdateShortCodeRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"short_codes/{shortCodeId}", Method.Patch);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateShortCodeResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListPhoneMessageSettingsResponse?> ListPhoneNumbersWithMessagingSettingsAsync(
        ListPhoneMessageSettingsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"phone_numbers/messaging").AddPagination(request.PageSize);

        return await ExecuteAsync<ListPhoneMessageSettingsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrievePhoneMessageSettingsResponse?> GetPhoneNumberWithMessagingSettingsAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"phone_numbers/{id}/messaging");

        return await ExecuteAsync<RetrievePhoneMessageSettingsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdatePhoneNumberMessagingResponse?> UpdatePhoneNumberMessagingSettingsAsync(string id,
        UpdatePhoneNumberMessagingRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"phone_numbers/{id}/messaging", Method.Patch);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdatePhoneNumberMessagingResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateNumbersMessagingBulkResponse?> UpdateMessagingProfileForMultipleNumbersAsync(
        UpdateNumbersMessagingBulkRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messaging_numbers_bulk_updates", Method.Post);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateNumbersMessagingBulkResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrieveBulkUpdateStatusResponse?> RetrieveBulkUpdateStatusAsync(string orderId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_numbers_bulk_updates/{orderId}");

        return await ExecuteAsync<RetrieveBulkUpdateStatusResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DeleteHostedNumberResponse?> DeleteHostedNumberAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_hosted_numbers/{id}", Method.Delete);

        return await ExecuteAsync<DeleteHostedNumberResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetHostedNumberOrderResponse?> ListHostedNumberOrdersAsync(
        GetHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_hosted_number_orders").AddPagination(request.PageSize);

        return await ExecuteAsync<GetHostedNumberOrderResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CreateHostedNumberOrderResponse?> CreateHostedNumberOrderAsync(
        CreateHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messaging_hosted_number_orders", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<CreateHostedNumberOrderResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrieveHostedNumberOrderResponse?> RetrieveHostedNumberOrderAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_hosted_number_orders/{id}");

        return await ExecuteAsync<RetrieveHostedNumberOrderResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UploadFileHostedNumberOrderResponse?> UploadFileRequiredForHostedNumberOrderAsync(string id,
        UploadFileHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_hosted_number_orders/{id}/actions/file_upload", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UploadFileHostedNumberOrderResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListAutoResponseSettingsResponse?> ListAutoResponseSettingsAsync(string profileId,
        ListAutoResponseSettingsRequest request, CancellationToken cancellationToken = default)
    {
        var createdAtGteFormatted = request.CreatedAtGte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");
        var createdAtLteFormatted = request.CreatedAtLte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");
        var updatedAtGteFormatted = request.UpdatedAtGte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");
        var updatedAtLteFormatted = request.UpdatedAtLte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");

        var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs")
            .AddFilter("country_code", request.CountryCode)
            .AddFilter("created_at[gte]", createdAtGteFormatted)
            .AddFilter("created_at[lte]", createdAtLteFormatted)
            .AddFilter("updated_at[gte]", updatedAtGteFormatted)
            .AddFilter("updated_at[lte]", updatedAtLteFormatted);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<ListAutoResponseSettingsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CreateAutoResponseSettingResponse?> CreateAutoResponseSettingAsync(string profileId,
        CreateAutoResponseSettingRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs", Method.Post);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<CreateAutoResponseSettingResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetAutoResponseSettingResponse?> GetAutoResponseSettingAsync(string profileId,
        string autorespCfgId, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs/{autorespCfgId}");

        return await ExecuteAsync<GetAutoResponseSettingResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateAutoResponseSettingResponse?> UpdateAutoResponseSettingAsync(string profileId,
        string autorespCfgId, UpdateAutoResponseSettingRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs/{autorespCfgId}", Method.Put);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateAutoResponseSettingResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DeleteAutoResponseSettingResponse?> DeleteAutoResponseSettingAsync(string profileId,
        string autorespCfgId, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs/{autorespCfgId}",
            Method.Delete);

        return await ExecuteAsync<DeleteAutoResponseSettingResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListVerificationRequestsResponse?> ListVerificationRequestsAsync(
        ListVerificationRequestsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_tollfree/verification/requests").AddPagination(request.PageSize)
            .AddFilter("date_start", request.DateStart?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz"))
            .AddFilter("date_end", request.DateEnd?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz"))
            .AddFilter("status", request.Status?.ToString())
            .AddFilter("phone_number", request.PhoneNumber);

        return await ExecuteAsync<ListVerificationRequestsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SubmitVerificationRequestResponse?> SubmitVerificationRequestAsync(
        SubmitVerificationRequestRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messaging_tollfree/verification/requests", Method.Post);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<SubmitVerificationRequestResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetVerificationRequestResponse?> GetVerificationRequestAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_tollfree/verification/requests/{id}");

        return await ExecuteAsync<GetVerificationRequestResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DeleteVerificationRequestResponse?> DeleteVerificationRequestAsync(string id,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_tollfree/verification/requests/{id}", Method.Delete);

        return await ExecuteAsync<DeleteVerificationRequestResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateVerificationRequestResponse?> UpdateVerificationRequestAsync(string id,
        UpdateVerificationRequestRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"messaging_tollfree/verification/requests/{id}", Method.Patch);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateVerificationRequestResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListBrandsResponse?> ListBrandsAsync(ListBrandsRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/brand").AddPagination(request.PageSize)
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
    public async Task<CreateBrandResponse?> CreateBrandAsync(CreateBrandRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("10dlc/brand", Method.Post);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<CreateBrandResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetBrandResponse?> GetBrandAsync(string brandId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/brand/{brandId}");

        return await ExecuteAsync<GetBrandResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateBrandResponse?> UpdateBrandAsync(string brandId, UpdateBrandRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/brand/{brandId}", Method.Put);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateBrandResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DeleteBrandResponse?> DeleteBrandAsync(string brandId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/brand/{brandId}", Method.Delete);

        return await ExecuteAsync<DeleteBrandResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ResendBrand2FAEmailResponse?> ResendBrand2FAEmailAsync(string brandId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/brand/{brandId}/2faEmail", Method.Post);

        return await ExecuteAsync<ResendBrand2FAEmailResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RevetBrandResponse?> RevetBrandAsync(string brandId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/brand/{brandId}/revet", Method.Put);

        return await ExecuteAsync<RevetBrandResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListExternalVettingResponse?> ListExternalVettingAsync(string brandId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/brand/{brandId}/externalVetting");

        return await ExecuteAsync<ListExternalVettingResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ImportExternalVettingResponse?> ImportExternalVettingRecordAsync(string brandId,
        ImportExternalVettingRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/brand/{brandId}/externalVetting", Method.Put);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<ImportExternalVettingResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<OrderExternalVettingResponse?> OrderExternalVettingAsync(string brandId,
        OrderExternalVettingRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/brand/{brandId}/externalVetting", Method.Post);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<OrderExternalVettingResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetBrandFeedbackResponse?> GetBrandFeedbackAsync(string brandId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/brand/feedback/{brandId}");

        return await ExecuteAsync<GetBrandFeedbackResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListCampaignsResponse?> ListCampaignsAsync(ListCampaignsRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/campaign").AddPagination(request.PageSize)
            .AddFilter("sort", request.Sort)
            .AddFilter("brandId", request.BrandId);
        return await ExecuteAsync<ListCampaignsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetCampaignResponse?> GetCampaignAsync(string campaignId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/campaign/{campaignId}");

        return await ExecuteAsync<GetCampaignResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateCampaignResponse?> UpdateCampaignAsync(string campaignId, UpdateCampaignRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/campaign/{campaignId}", Method.Put);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateCampaignResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DeactivateCampaignResponse?> DeactivateCampaignAsync(string campaignId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/campaign/{campaignId}", Method.Delete);

        return await ExecuteAsync<DeactivateCampaignResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetCampaignOperationStatusResponse?> GetCampaignOperationStatusAsync(string campaignId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/campaign/{campaignId}/operationStatus");

        return await ExecuteAsync<GetCampaignOperationStatusResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetCampaignOsrAttributesResponse?> GetCampaignOsrAttributesAsync(string campaignId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/campaign/{campaignId}/osr/attributes");

        return await ExecuteAsync<GetCampaignOsrAttributesResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetCampaignCostResponse?> GetCampaignCostAsync(GetCampaignCostRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/campaign/usecase/cost").AddFilter("usecase", request.UseCase);

        return await ExecuteAsync<GetCampaignCostResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<SubmitCampaignResponse?> SubmitCampaignAsync(SubmitCampaignRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("10dlc/campaignBuilder", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<SubmitCampaignResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<QualifyCampaignByUsecaseResponse?> QualifyCampaignByUsecaseAsync(string brandId,
        string usecase, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/campaignBuilder/brand/{brandId}/usecase/{usecase}");

        return await ExecuteAsync<QualifyCampaignByUsecaseResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetCampaignMnoMetadataResponse?> GetCampaignMnoMetadataAsync(string campaignId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/campaign/{campaignId}/mnoMetadata");

        return await ExecuteAsync<GetCampaignMnoMetadataResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<RetrievePhoneNumberCampaignsResponse?> RetrievePhoneNumberCampaignsAsync(
        RetrievePhoneNumberCampaignsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/phone_number_campaigns")
            .AddFilter("telnyx_campaign_id", request.FilterTelnyxCampaignId)
            .AddFilter("telnyx_brand_id", request.FilterTelnyxBrandId)
            .AddFilter("tcr_campaign_id", request.FilterTcrCampaignId)
            .AddFilter("tcr_brand_id", request.FilterTcrBrandId)
            .AddFilter("sort", request.Sort)
            .AddPagination(request.PageSize);

        return await ExecuteAsync<RetrievePhoneNumberCampaignsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<CreatePhoneNumberCampaignResponse?> CreatePhoneNumberCampaignAsync(
        CreatePhoneNumberCampaignRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("10dlc/phone_number_campaigns", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<CreatePhoneNumberCampaignResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetPhoneNumberCampaignResponse?> GetPhoneNumberCampaignAsync(string phoneNumber,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/phone_number_campaigns/{phoneNumber}");

        return await ExecuteAsync<GetPhoneNumberCampaignResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdatePhoneNumberCampaignResponse?> UpdatePhoneNumberCampaignAsync(string phoneNumber,
        UpdatePhoneNumberCampaignRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/phone_number_campaigns/{phoneNumber}", Method.Put);

        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdatePhoneNumberCampaignResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<DeletePhoneNumberCampaignResponse?> DeletePhoneNumberCampaignAsync(string phoneNumber,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/phone_number_campaigns/{phoneNumber}", Method.Delete);

        return await ExecuteAsync<DeletePhoneNumberCampaignResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<AssignMessagingProfileToCampaignResponse?> AssignMessagingProfileToCampaignAsync(
        AssignMessagingProfileToCampaignRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("10dlc/phoneNumberAssignmentByProfile", Method.Post);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<AssignMessagingProfileToCampaignResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetAssignmentTaskStatusResponse?> GetAssignmentTaskStatusAsync(string taskId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/phoneNumberAssignmentByProfile/{taskId}");

        return await ExecuteAsync<GetAssignmentTaskStatusResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetPhoneNumberStatusResponse?> GetPhoneNumberStatusAsync(string taskId,
        GetPhoneNumberStatusRequest request, CancellationToken cancellationToken = default)
    {
        var req =
            new RestRequest($"10dlc/phoneNumberAssignmentByProfile/{taskId}/phoneNumbers").AddPagination(
                request.PageSize);

        return await ExecuteAsync<GetPhoneNumberStatusResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListSharedCampaignsResponse?> ListSharedCampaignsAsync(ListSharedCampaignsRequest request,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/partner_campaigns").AddPagination(request.PageSize)
            .AddFilter("sort", request.Sort);

        return await ExecuteAsync<ListSharedCampaignsResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetSharedCampaignRecordResponse?> GetSingleSharedCampaignAsync(string campaignId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/partner_campaigns/{campaignId}");

        return await ExecuteAsync<GetSharedCampaignRecordResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<UpdateSingleSharedCampaignResponse?> UpdateSingleSharedCampaignAsync(string campaignId,
        UpdateSingleSharedCampaignRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/partner_campaigns/{campaignId}", Method.Patch);
        req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

        return await ExecuteAsync<UpdateSingleSharedCampaignResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetSharingStatusResponse?> GetSharingStatusAsync(string campaignId,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/partnerCampaign/{campaignId}/sharing");

        return await ExecuteAsync<GetSharingStatusResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetPartnerCampaignsSharedByUserResponse?> GetPartnerCampaignsSharedByUserAsync(
        GetPartnerCampaignsSharedByUserRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/partnerCampaign/sharedByMe").AddPagination(request.PageSize);
        return await ExecuteAsync<GetPartnerCampaignsSharedByUserResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<GetEnumResponse?> GetEnumAsync(EnumEndpoint endpoint,
        CancellationToken cancellationToken = default)
    {
        var req = new RestRequest($"10dlc/enum/{endpoint.ToString().ToLower()}");

        return await ExecuteAsync<GetEnumResponse>(req, cancellationToken);
    }

    /// <inheritdoc />
    private async Task<T1> ExecuteAsync<T1>(RestRequest request, CancellationToken cancellationToken = default)
        where T1 : ITelnyxResponse, new()
    {
        request.AddOrUpdateHeader("X-Correlation-ID", Guid.NewGuid());
        var response = await _client.ExecuteAsync(request, cancellationToken);

        var result = new T1
        {
            StatusCode = response.StatusCode,
            IsSuccessful = response.IsSuccessful,
            ErrorMessage = response.ErrorMessage
        };

        // Handle rate limiting
        if (response.StatusCode == HttpStatusCode.TooManyRequests)
        {
            var resetSeconds = response.Headers?
                .FirstOrDefault(h => h.Name.Equals("x-ratelimit-reset", StringComparison.OrdinalIgnoreCase))?
                .Value?.ToString();

            if (int.TryParse(resetSeconds, out var delay))
            {
                throw new RateLimitRejectedException(TimeSpan.FromSeconds(delay));
            }

            throw new RateLimitRejectedException(TimeSpan.FromSeconds(1));
        }

        // If we have content and the request was successful, try to deserialize
        if (response is not { IsSuccessful: true, Content: not null }) return result;

        var deserializedResult =
            JsonSerializer.Deserialize<T1>(response.Content, TelnyxJsonSerializerContext.Default.Options);

        if (deserializedResult == null) return result;

        result = deserializedResult;
        result.StatusCode = response.StatusCode;
        result.IsSuccessful = response.IsSuccessful;
        result.ErrorMessage = response.ErrorMessage;

        // Handle pagination if necessary
        var pageParam = request.Parameters.FirstOrDefault(p => p.Name == "page[number]");
        var metaProperty = typeof(T1).GetProperty("Meta");
        var dataProperty = typeof(T1).GetProperty("Data");

        if (metaProperty?.GetValue(result) is not PaginationMeta meta || dataProperty == null ||
            meta.PageNumber >= meta.TotalPages) return result;

        var dataType = dataProperty.PropertyType.GetGenericArguments()[0];
        var listType = typeof(List<>).MakeGenericType(dataType);
        var allData = (IList)Activator.CreateInstance(listType);

        if (dataProperty.GetValue(result) is IEnumerable initialData)
            foreach (var item in initialData)
                allData.Add(item);

        while (meta.PageNumber < meta.TotalPages)
        {
            request.AddOrUpdateHeader("X-Correlation-ID", Guid.NewGuid());
            request.RemoveParameter(pageParam);
            request.AddParameter("page[number]", meta.PageNumber + 1);
            response = await _client.ExecuteAsync(request, cancellationToken);

            if (response.StatusCode == HttpStatusCode.TooManyRequests)
            {
                var resetSeconds = response.Headers?
                    .FirstOrDefault(h =>
                        h.Name.Equals("x-ratelimit-reset", StringComparison.OrdinalIgnoreCase))?
                    .Value?.ToString();

                if (int.TryParse(resetSeconds, out var delay))
                {
                    throw new RateLimitRejectedException(TimeSpan.FromSeconds(delay));
                }

                throw new RateLimitRejectedException(TimeSpan.FromSeconds(1));
            }

            if (!response.IsSuccessful || response.Content == null)
            {
                result.IsSuccessful = false;
                result.StatusCode = response.StatusCode;
                result.ErrorMessage = response.ErrorMessage;
                break;
            }

            var nextResult = JsonSerializer.Deserialize<T1>(response.Content,
                TelnyxJsonSerializerContext.Default.Options);
            if (nextResult == null) break;

            var nextData = dataProperty.GetValue(nextResult);
            if (nextData is IEnumerable pageData)
                foreach (var item in pageData)
                    allData.Add(item);

            metaProperty.SetValue(result, metaProperty.GetValue(nextResult));
            meta = (PaginationMeta)metaProperty.GetValue(result);
            pageParam = request.Parameters.FirstOrDefault(p => p.Name == "page[number]");
        }

        dataProperty.SetValue(result, allData);

        return result;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        _logWriter?.Dispose();
        _logFileStream?.Dispose();
        _client?.Dispose();
        GC.SuppressFinalize(this);
    }
}