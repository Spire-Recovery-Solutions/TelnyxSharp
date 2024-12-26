using Polly;
using Polly.RateLimit;
using Polly.Wrap;
using RestSharp;
using RestSharp.Authenticators;
using System.Text.Json;
using Telnyx.NET.Interfaces;
using Telnyx.NET.Models;

namespace Telnyx.NET
{
    public class TelnyxClient : ITelnyxClient, IDisposable
    {
        private readonly RestClient _client;
        private readonly Dictionary<Type, AsyncPolicyWrap> _policies;


        //Global API Limit 200 Requests Per Second
        public TelnyxClient(string apiKey, TelnyxRateLimitConfiguration? rateLimitConfiguration = null)
        {
            var options = new RestClientOptions
            {
                Authenticator = new JwtAuthenticator(apiKey),
                BaseUrl = new Uri("https://api.telnyx.com/v2/"),
                ThrowOnDeserializationError = false,
                FailOnDeserializationError = false,
                ThrowOnAnyError = false,
            };
            _client = new RestClient(options)
            {
                AcceptedContentTypes = new string[]
                {
                    "application/json"
                },
            };

            var rateLimitRetryPolicy = Policy
                .Handle<RateLimitRejectedException>()
                .WaitAndRetryForeverAsync(sleepDurationProvider: (a, b, c) =>
                    {
                        var ex = b as RateLimitRejectedException;
                        return ex!.RetryAfter;
                    },
                    (a, b, c) => Task.CompletedTask);

            rateLimitConfiguration ??= new TelnyxRateLimitConfiguration();

            _policies = new Dictionary<Type, AsyncPolicyWrap>
            {
                { typeof(NumberLookupRequest),  rateLimitRetryPolicy.WrapAsync(Policy.RateLimitAsync(rateLimitConfiguration.NumberLookups, TimeSpan.FromSeconds(1)))},
                { typeof(AvailablePhoneNumbersRequest),  rateLimitRetryPolicy.WrapAsync(Policy.RateLimitAsync(rateLimitConfiguration.NumberSearch, TimeSpan.FromSeconds(1)))},
                { typeof(NumberOrdersRequest),  rateLimitRetryPolicy.WrapAsync(Policy.RateLimitAsync(rateLimitConfiguration.NumberOrders, TimeSpan.FromSeconds(1)))},
                { typeof(PhoneNumbersRequest),  rateLimitRetryPolicy.WrapAsync(Policy.RateLimitAsync(rateLimitConfiguration.PhoneNumbers, TimeSpan.FromSeconds(1)))},
                { typeof(NumberReservationRequest),  rateLimitRetryPolicy.WrapAsync(Policy.RateLimitAsync(rateLimitConfiguration.NumberReservations, TimeSpan.FromSeconds(1)))},
                { typeof(PortingOrdersRequest),  rateLimitRetryPolicy.WrapAsync(Policy.RateLimitAsync(rateLimitConfiguration.PortNumbers, TimeSpan.FromSeconds(1)))},
                { typeof(SendMessageRequest), rateLimitRetryPolicy.WrapAsync(Policy.RateLimitAsync(rateLimitConfiguration.SendMessage, TimeSpan.FromSeconds(1))) },
                { typeof(DialRequest), rateLimitRetryPolicy.WrapAsync(Policy.RateLimitAsync(rateLimitConfiguration.Calls, TimeSpan.FromSeconds(1))) }

            };
        }

        /// <inheritdoc />
        public async Task<NumberLookupResponse?> NumberLookup(NumberLookupRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder();

            foreach (var type in request.NumberLookupTypes)
            {
                if (type == NumberLookupType.CallerName)
                    query.AddFilter("type", "caller-name");
                else if (type == NumberLookupType.Carrier)
                    query.AddFilter("type", "carrier");
            }

            var req = new RestRequest($"number_lookup/{request.PhoneNumber}?{query}");
            return await _policies[request.GetType()].ExecuteAsync(token => ExecuteAsync<NumberLookupResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<AvailablePhoneNumbersResponse?> AvailablePhoneNumbers(AvailablePhoneNumbersRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
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

            //They do not support pagination on phone number searches
            //if (request.PageNumber != null)
            //    queryBuilder.Append($"&page[number]={request.PageNumber}");

            //if (request.PageSize != null)
            //{
            //    if (request.PageSize > 250)
            //        request.PageSize = 250;
            //    queryBuilder.Append($"&page[size]={request.PageSize}");
            //}

            var req = new RestRequest("available_phone_numbers?" + query);

            return await _policies[request.GetType()].ExecuteAsync(token => ExecuteAsync<AvailablePhoneNumbersResponse>(req, token), cancellationToken);
        }


        /// <inheritdoc />
        public async Task<ListNumberOrdersResponse?> ListNumberOrders(ListNumberOrdersRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddFilter("status", request.Status)
                .AddFilter("created_at[gt]", request.CreatedAfter)
                .AddFilter("created_at[lt]", request.CreatedBefore)
                .AddFilter("customer_reference", request.CustomerReference)
                .AddFilter("phone_numbers_count", request.PhoneNumberCount?.ToString())
                .AddFilter("requirements_met", request.RequirementsMet.ToString())
                .AddPagination(request.PageNumber, request.PageSize);

            var req = new RestRequest("number_orders?" + query);
            var response = await _policies[request.GetType().BaseType!]
                .ExecuteAsync(token => ExecuteAsync<ListNumberOrdersResponse>(req, token), cancellationToken);

            if (response == null) return response;

            var innerResults = new List<NumberOrder>(response.Data);

            while (response!.Meta.PageNumber < response.Meta.TotalPages)
            {
                request.PageNumber++;
                req = new RestRequest("number_orders?" + query);
                response = await _policies[request.GetType().BaseType!]
                    .ExecuteAsync(token => ExecuteAsync<ListNumberOrdersResponse>(req, token), cancellationToken);
                if (response != null) innerResults.AddRange(response.Data);
            }

            response.Data = innerResults;

            return response;
        }

        /// <inheritdoc />
        public async Task<RetrieveMessagingProfileResponse?> RetrieveMessagingProfile(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_profiles/{id}");
            return await _policies[typeof(RetrieveMessagingProfileRequest)].ExecuteAsync(
                token => ExecuteAsync<RetrieveMessagingProfileResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetNumberOrderResponse?> GetNumberOrder(string numberOrderId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_orders/{numberOrderId}");
            return await _policies[typeof(NumberOrdersRequest)].ExecuteAsync(token => ExecuteAsync<GetNumberOrderResponse>(req, token), cancellationToken);
        }

        public async Task<CreateNumberOrderResponse?> CreateNumberOrder(CreateNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            try
            {
                var req = new RestRequest($"number_orders", Method.Post);
                req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
                var result = await _policies[request.GetType().BaseType!]
                    .ExecuteAsync(token => ExecuteAsync<CreateNumberOrderResponse>(req, token), cancellationToken);
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <inheritdoc />
        public async Task<UpdateNumberVoiceSettingsResponse?> UpdateNumberVoiceSettings(string phoneNumberId,
            UpdateNumberVoiceSettingsRequest request, CancellationToken cancellationToken = default)
        {
            var success = false;
            var tries = 0;
            while (!success && tries < 5)
            {
                try
                {
                    tries++;
                    //TODO: Deal with failures!
                    var req = new RestRequest($"phone_numbers/{phoneNumberId}/voice", Method.Patch);
                    req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
                    return await _policies[request.GetType().BaseType!]
                        .ExecuteAsync(token => _client.PatchAsync<UpdateNumberVoiceSettingsResponse>(req, cancellationToken: token), cancellationToken);
                }
                catch (Exception)
                {
                    //TODO: Make this better...
                    //Ignore
                }
            }

            return null;
        }

        /// <inheritdoc />
        public async Task<ListNumbersResponse?> ListNumbers(ListNumbersRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddFilterList("tag", request.Tags)
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
                .AddPagination(request.PageNumber, request.PageSize)
                .ToString();

            var req = new RestRequest("phone_numbers?" + query);
            var response = await _policies[request.GetType().BaseType!]
                .ExecuteAsync(token => ExecuteAsync<ListNumbersResponse>(req, token), cancellationToken);

            if (response == null) return response;

            var innerResults = new List<ListNumbersDatum>(response.Data);

            while (response!.Meta.PageNumber < response.Meta.TotalPages)
            {
                request.PageNumber++;
                req = new RestRequest("phone_numbers?" + query);
                response = await _policies[request.GetType().BaseType!]
                    .ExecuteAsync(token => ExecuteAsync<ListNumbersResponse>(req, token), cancellationToken);
                if (response != null) innerResults.AddRange(response.Data);
            }

            response.Data = innerResults;

            return response;
        }

        /// <inheritdoc />
        public async Task<ListPortingOrdersResponse?> ListPortingOrders(ListPortingOrdersRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddFilter("status", request.Status)
                .AddFilter("include_phone_numbers", request.IncludePhoneNumbers.ToString())
                .AddFilter("customer_reference", request.CustomerReference)
                .AddFilter("sort", request.Sort)
                .AddPagination(request.PageNumber, request.PageSize);

            var req = new RestRequest("porting_orders?" + query);
            var response = await _policies[request.GetType().BaseType!]
                .ExecuteAsync(token => ExecuteAsync<ListPortingOrdersResponse>(req, token), cancellationToken);

            if (response == null) return response;

            var innerResults = new List<ListPortingOrdersDatum>(response.Data);

            while (response!.Meta.PageNumber < response.Meta.TotalPages)
            {
                request.PageNumber++;
                req = new RestRequest("porting_orders?" + query);
                response = await _policies[request.GetType().BaseType!]
                    .ExecuteAsync(token => ExecuteAsync<ListPortingOrdersResponse>(req, token), cancellationToken);
                if (response != null) innerResults.AddRange(response.Data);
            }

            response.Data = innerResults;

            return response;
        }

        /// <inheritdoc />
        public async Task<ListPortingPhoneNumbersResponse?> ListPortingPhoneNumbers(
        ListPortingPhoneNumbersRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddFilter("porting_order_id", request.PortingOrderId?.ToString())
                .AddFilterList("porting_order_id", request.PortingOrderIds?.Select(id => id.ToString()))
                .AddFilter("support_key[eq]", request.SupportKeyEq)
                .AddFilterList("support_key[in]", request.SupportKeyIn)
                .AddFilter("phone_number", request.PhoneNumber)
                .AddFilterList("phone_number[in]", request.PhoneNumberIn)
                .AddFilter("porting_order_status", request.PortingOrderStatus)
                .AddFilter("activation_status", request.ActivationStatus)
                .AddFilter("portability_status", request.PortabilityStatus)
                .AddPagination(request.PageNumber, request.PageSize);

            var req = new RestRequest($"porting_phone_numbers?{query}");
            var response = await _policies[request.GetType().BaseType!]
                .ExecuteAsync(token => ExecuteAsync<ListPortingPhoneNumbersResponse>(req, token), cancellationToken);

            if (response == null) return response;

            var innerResults = new List<ListPortingPhoneNumbersDatum>(response.Data);

            while (response!.Meta.PageNumber < response.Meta.TotalPages)
            {
                request.PageNumber = response.Meta.PageNumber + 1;
                req = new RestRequest($"porting_phone_numbers?{query}");
                response = await _policies[request.GetType().BaseType!]
                    .ExecuteAsync(token => ExecuteAsync<ListPortingPhoneNumbersResponse>(req, token), cancellationToken);
                if (response != null) innerResults.AddRange(response.Data);
            }

            response.Data = innerResults;

            return response;
        }

        /// <inheritdoc />
        public async Task<CreateNumberReservationResponse?> CreateNumberReservation(
            CreateNumberReservationRequest request, CancellationToken cancellationToken = default)
        {
            try
            {
                var req = new RestRequest($"number_reservations", Method.Post);
                req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
                return await _policies[request.GetType().BaseType!].ExecuteAsync(async token =>
                    await ExecuteAsync<CreateNumberReservationResponse>(req, token), cancellationToken);
            }
            catch (HttpRequestException ex)
            {
                if (ex.StatusCode == System.Net.HttpStatusCode.UnprocessableEntity)
                {
                    //Fack
                    return null;
                }

                return null;
            }
        }

        /// <inheritdoc />
        public async Task<UpdateNumberConfigurationResponse?> UpdateNumberConfiguration(string phoneNumberId,
            UpdateNumberConfigurationRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{phoneNumberId}", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await _policies[request.GetType().BaseType!]
                .ExecuteAsync(token => _client.PatchAsync<UpdateNumberConfigurationResponse>(req, cancellationToken: token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<bool> RemoveNumber(string numberOrObjectId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{numberOrObjectId}", Method.Delete);

            var response = await _policies[typeof(PhoneNumbersRequest)]
                .ExecuteAsync(token => _client.DeleteAsync(req, cancellationToken: token), cancellationToken);

            return response.IsSuccessful;
        }

        /// <inheritdoc />
        public async Task<SendMessageResponse?> SendMessage(SendMessageRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messages", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            var response = await _policies[request.GetType()]
                .ExecuteAsync(token => ExecuteAsync<SendMessageResponse>(req, token), cancellationToken);

            return response;
        }

        /// <inheritdoc />
        public async Task<DialResponse?> Dial(DialRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("calls", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await _policies[typeof(DialRequest)]
                .ExecuteAsync(token => ExecuteAsync<DialResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<AnswerCallResponse?> AnswerCall(string callControlId, AnswerCallRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/answer", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await _policies[typeof(AnswerCallRequest)]
                .ExecuteAsync(token => ExecuteAsync<AnswerCallResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<HangupCallResponse?> HangupCall(string callControlId, HangupCallRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/hangup", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await _policies[typeof(HangupCallRequest)]
                .ExecuteAsync(token => ExecuteAsync<HangupCallResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RejectCallResponse?> RejectCall(string callControlId, RejectCallRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/reject", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await _policies[typeof(RejectCallRequest)]
                .ExecuteAsync(token => ExecuteAsync<RejectCallResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SpeakTextResponse?> SpeakText(string callControlId, SpeakTextRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/speak", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            var response = await _policies[request.GetType()]
                .ExecuteAsync(token => ExecuteAsync<SpeakTextResponse>(req, token), cancellationToken);

            return response;
        }

        /// <inheritdoc />
        public async Task<PlaybackStartResponse?> PlaybackStart(string callControlId, PlaybackStartRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/playback_start", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(PlaybackStartRequest)]
                .ExecuteAsync(token => ExecuteAsync<PlaybackStartResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<StopAudioPlaybackResponse?> StopAudioPlayback(string callControlId, StopAudioPlaybackRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/playback_stop", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(StopAudioPlaybackRequest)]
                .ExecuteAsync(token => ExecuteAsync<StopAudioPlaybackResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<EnqueueCallResponse?> EnqueueCall(string callControlId, EnqueueCallRequest request, CancellationToken cancellationToken = default)
        {

            var req = new RestRequest($"calls/{callControlId}/actions/enqueue", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            var result = await _policies[request.GetType()]
                .ExecuteAsync(token => ExecuteAsync<EnqueueCallResponse>(req, token), cancellationToken);
            return result;
        }

        /// <inheritdoc />
        public async Task<RemoveCallFromQueueResponse?> RemoveCallFromQueue(string callControlId, RemoveCallFromQueueRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/leave_queue", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[request.GetType()]
                .ExecuteAsync(token => ExecuteAsync<RemoveCallFromQueueResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<TransferCallResponse?> TransferCall(string callControlId, TransferCallRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"calls/{callControlId}/actions/transfer", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(TransferCallRequest)].ExecuteAsync(
                token => ExecuteAsync<TransferCallResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<MessagingProfilesResponse?> GetMessagingProfiles(MessagingProfilesRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddPagination(request.PageNumber, request.PageSize)
                .AddFilter("name", request.NameFilter);

            var req = new RestRequest($"messaging_profiles?{query}");
            return await _policies[request.GetType()].ExecuteAsync(token => ExecuteAsync<MessagingProfilesResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateMessagingProfileResponse?> CreateMessagingProfile(CreateMessagingProfileRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messaging_profiles", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[request.GetType()].ExecuteAsync(token => ExecuteAsync<CreateMessagingProfileResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateMessagingProfileResponse?> UpdateMessagingProfile(string id, UpdateMessagingProfileRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_profiles/{id}", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<UpdateMessagingProfileResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<MessagingProfilePhoneNumberResponse?> ListMessagingProfilePhoneNumbers(
            string id,
            MessagingProfilePhoneNumberRequest request,
            CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddPagination(request.PageNumber, request.PageSize);

            var req = new RestRequest($"messaging_profiles/{id}/phone_numbers?{query}");
            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<MessagingProfilePhoneNumberResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteMessagingProfileResponse?> DeleteMessagingProfile(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_profiles/{id}", Method.Delete);

            return await _policies[typeof(DeleteMessagingProfileRequest)].ExecuteAsync(
                token => ExecuteAsync<DeleteMessagingProfileResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<MessagingProfileShortCodeResponse?> ListMessagingProfileShortCodes(string id, MessagingProfileShortCodeRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddPagination(request.PageNumber, request.PageSize);

            var req = new RestRequest($"messaging_profiles/{id}/short_codes?{query}");
            return await _policies[typeof(MessagingProfileShortCodeRequest)].ExecuteAsync(
                token => ExecuteAsync<MessagingProfileShortCodeResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveMessagingProfileMetricsResponse?> RetrieveMessagingProfileMetrics(string id, RetrieveMessagingProfileMetricsRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddFilter("time_frame", request.TimeFrame);

            var req = new RestRequest($"messaging_profiles/{id}/metrics?{query}");
            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<RetrieveMessagingProfileMetricsResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<MessagingProfileMetricsResponse?> ListMessagingProfileMetrics(MessagingProfileMetricsRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddPagination(request.PageNumber, request.PageSize)
                .AddFilter("id", request.MessagingProfileId.ToString())
                .AddFilter("time_frame", request.TimeFrame);

            var req = new RestRequest($"messaging_profile_metrics?{query}");

            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<MessagingProfileMetricsResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<NumberPoolMessageResponse?> SendMessageUsingNumberPoolAsync(NumberPoolMessageRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messages/number_pool", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<NumberPoolMessageResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<LongCodeMessageResponse?> SendLongCodeMessage(LongCodeMessageRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messages/long_code", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<LongCodeMessageResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ShortCodeMessageResponse?> SendShortCodeMessageAsync(ShortCodeMessageRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messages/short_code", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<ShortCodeMessageResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GroupMmsMessageResponse?> SendGroupMmsMessageAsync(GroupMmsMessageRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messages/group_mms", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<GroupMmsMessageResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveMessageResponse?> RetrieveMessageAsync(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messages/{id}");

            return await _policies[typeof(RetrieveMessageRequest)].ExecuteAsync(
                token => ExecuteAsync<RetrieveMessageResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListMessagingUrlDomainsResponse?> ListMessagingUrlDomainsAsync(ListMessagingUrlDomainsRequest request,
            CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddPagination(request.PageNumber, request.PageSize);

            var req = new RestRequest($"messaging_url_domains?{query}");

            return await _policies[typeof(ListMessagingUrlDomainsRequest)].ExecuteAsync(token => ExecuteAsync<ListMessagingUrlDomainsResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListShortCodesResponse?> ListShortCodesAsync(ListShortCodesRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddPagination(request.PageNumber, request.PageSize)
                .AddFilter("filter[messaging_profile_id]", request.MessagingProfileId);

            var req = new RestRequest($"short_codes?{query}");

            return await _policies[request.GetType()].ExecuteAsync(token => ExecuteAsync<ListShortCodesResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveShortCodeResponse?> RetrieveShortCodeAsync(string shortCodeId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"short_codes/{shortCodeId}");

            return await _policies[typeof(RetrieveShortCodeRequest)].ExecuteAsync(token => ExecuteAsync<RetrieveShortCodeResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateShortCodeResponse?> UpdateShortCodeAsync(string shortCodeId, UpdateShortCodeRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"short_codes/{shortCodeId}", Method.Patch);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<UpdateShortCodeResponse>(req, token), cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPhoneMessageSettingsResponse?> ListPhoneNumbersWithMessagingSettingsAsync(ListPhoneMessageSettingsRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddPagination(request.PageNumber, request.PageSize);

            var req = new RestRequest($"phone_numbers/messaging?{query}");

            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<ListPhoneMessageSettingsResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrievePhoneMessageSettingsResponse?> GetPhoneNumberWithMessagingSettingsAsync(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{id}/messaging");

            return await _policies[typeof(RetrievePhoneMessageSettingsRequest)].ExecuteAsync(
                token => ExecuteAsync<RetrievePhoneMessageSettingsResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdatePhoneNumberMessagingResponse?> UpdatePhoneNumberMessagingSettingsAsync(string id, UpdatePhoneNumberMessagingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{id}/messaging", Method.Patch);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<UpdatePhoneNumberMessagingResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateNumbersMessagingBulkResponse?> UpdateMessagingProfileForMultipleNumbersAsync(UpdateNumbersMessagingBulkRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messaging_numbers_bulk_updates", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<UpdateNumbersMessagingBulkResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveBulkUpdateStatusResponse?> RetrieveBulkUpdateStatusAsync(string orderId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_numbers_bulk_updates/{orderId}");

            return await _policies[typeof(RetrieveBulkUpdateStatusRequest)].ExecuteAsync(
                token => ExecuteAsync<RetrieveBulkUpdateStatusResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteHostedNumberResponse?> DeleteHostedNumberAsync(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_hosted_numbers/{id}", Method.Delete);

            return await _policies[typeof(DeleteHostedNumberRequest)].ExecuteAsync(
                token => ExecuteAsync<DeleteHostedNumberResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetHostedNumberOrderResponse?> ListHostedNumberOrdersAsync(GetHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
               .AddPagination(request.PageNumber, request.PageSize);

            var req = new RestRequest($"messaging_hosted_number_orders?{query}");

            return await _policies[typeof(GetHostedNumberOrderRequest)].ExecuteAsync(
                token => ExecuteAsync<GetHostedNumberOrderResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateHostedNumberOrderResponse?> CreateHostedNumberOrderAsync(CreateHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messaging_hosted_number_orders", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(CreateHostedNumberOrderRequest)].ExecuteAsync(
                token => ExecuteAsync<CreateHostedNumberOrderResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveHostedNumberOrderResponse?> RetrieveHostedNumberOrderAsync(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_hosted_number_orders/{id}");

            return await _policies[typeof(RetrieveHostedNumberOrderRequest)].ExecuteAsync(
                token => ExecuteAsync<RetrieveHostedNumberOrderResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UploadFileHostedNumberOrderResponse?> UploadFileRequiredForHostedNumberOrderAsync(string id, UploadFileHostedNumberOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_hosted_number_orders/{id}/actions/file_upload", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(UploadFileHostedNumberOrderRequest)].ExecuteAsync(
                token => ExecuteAsync<UploadFileHostedNumberOrderResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListAutoResponseSettingsResponse?> ListAutoResponseSettingsAsync(string profileId, ListAutoResponseSettingsRequest request, CancellationToken cancellationToken = default)
        {
            string? createdAtGteFormatted = request.CreatedAtGte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");
            string? createdAtLteFormatted = request.CreatedAtLte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");
            string? updatedAtGteFormatted = request.UpdatedAtGte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");
            string? updatedAtLteFormatted = request.UpdatedAtLte?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz");

            var query = new QueryBuilder()
                               .AddFilter("country_code", request.CountryCode)
                               .AddFilter("created_at[gte]", createdAtGteFormatted)
                               .AddFilter("created_at[lte]", createdAtLteFormatted)
                               .AddFilter("updated_at[gte]", updatedAtGteFormatted)
                               .AddFilter("updated_at[lte]", updatedAtLteFormatted);

            var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs?{query}");
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(ListAutoResponseSettingsRequest)].ExecuteAsync(
                token => ExecuteAsync<ListAutoResponseSettingsResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateAutoResponseSettingResponse?> CreateAutoResponseSettingAsync(string profileId, CreateAutoResponseSettingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(CreateAutoResponseSettingRequest)].ExecuteAsync(
                token => ExecuteAsync<CreateAutoResponseSettingResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetAutoResponseSettingResponse?> GetAutoResponseSettingAsync(string profileId, string autorespCfgId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs/{autorespCfgId}");

            return await _policies[typeof(GetAutoResponseSettingRequest)].ExecuteAsync(
                token => ExecuteAsync<GetAutoResponseSettingResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateAutoResponseSettingResponse?> UpdateAutoResponseSettingAsync(string profileId, string autorespCfgId, UpdateAutoResponseSettingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs/{autorespCfgId}", Method.Put);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(UpdateAutoResponseSettingRequest)].ExecuteAsync(
                token => ExecuteAsync<UpdateAutoResponseSettingResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteAutoResponseSettingResponse?> DeleteAutoResponseSettingAsync(string profileId, string autorespCfgId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_profiles/{profileId}/autoresp_configs/{autorespCfgId}", Method.Delete);

            return await _policies[typeof(DeleteAutoResponseSettingRequest)].ExecuteAsync(
                token => ExecuteAsync<DeleteAutoResponseSettingResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListVerificationRequestsResponse?> ListVerificationRequestsAsync(ListVerificationRequestsRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                            .AddPagination(request.Page, request.PageSize)
                            .AddFilter("date_start", request.DateStart?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz"))
                            .AddFilter("date_end", request.DateEnd?.ToString("yyyy-MM-ddTHH:mm:ss.ffffffzzz"))
                            .AddFilter("status", request.Status?.ToString())
                            .AddFilter("phone_number", request.PhoneNumber);

            var req = new RestRequest($"messaging_tollfree/verification/requests?{query}");

            return await _policies[typeof(ListVerificationRequestsRequest)].ExecuteAsync(
                token => ExecuteAsync<ListVerificationRequestsResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SubmitVerificationRequestResponse?> SubmitVerificationRequestAsync(SubmitVerificationRequestRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("messaging_tollfree/verification/requests", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(SubmitVerificationRequestRequest)].ExecuteAsync(
                token => ExecuteAsync<SubmitVerificationRequestResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetVerificationRequestResponse?> GetVerificationRequestAsync(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_tollfree/verification/requests/{id}");

            return await _policies[typeof(GetVerificationRequestRequest)].ExecuteAsync(
                token => ExecuteAsync<GetVerificationRequestResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteVerificationRequestResponse?> DeleteVerificationRequestAsync(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_tollfree/verification/requests/{id}", Method.Delete);

            return await _policies[typeof(DeleteVerificationRequestRequest)].ExecuteAsync(
                token => ExecuteAsync<DeleteVerificationRequestResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateVerificationRequestResponse?> UpdateVerificationRequestAsync(string id, UpdateVerificationRequestRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"messaging_tollfree/verification/requests/{id}", Method.Patch);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(UpdateVerificationRequestRequest)].ExecuteAsync(
                token => ExecuteAsync<UpdateVerificationRequestResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListBrandsResponse?> ListBrandsAsync(ListBrandsRequest request, CancellationToken cancellationToken = default)
        {
            var query = new QueryBuilder()
                .AddPagination(request.Page, request.RecordsPerPage)
                .AddFilter("sort", request.Sort.ToString())
                .AddFilter("displayName", request.DisplayName)
                .AddFilter("entityType", request.EntityType)
                .AddFilter("state", request.State)
                .AddFilter("country", request.Country)
                .AddFilter("brandId", request.BrandId)
                .AddFilter("tcrBrandId", request.TcrBrandId);

            var req = new RestRequest($"10dlc/brand?{query}");

            return await _policies[typeof(ListBrandsRequest)].ExecuteAsync(
                token => ExecuteAsync<ListBrandsResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateBrandResponse?> CreateBrandAsync(CreateBrandRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("10dlc/brand", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[request.GetType()].ExecuteAsync(
                token => ExecuteAsync<CreateBrandResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetBrandResponse?> GetBrandAsync(string brandId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}");

            return await _policies[typeof(GetBrandRequest)].ExecuteAsync(
                token => ExecuteAsync<GetBrandResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateBrandResponse?> UpdateBrandAsync(string brandId, UpdateBrandRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}", Method.Put);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(UpdateBrandRequest)].ExecuteAsync(
                token => ExecuteAsync<UpdateBrandResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteBrandResponse?> DeleteBrandAsync(string brandId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}", Method.Delete);

            return await _policies[typeof(DeleteBrandRequest)].ExecuteAsync(
                token => ExecuteAsync<DeleteBrandResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ResendBrand2FAEmailResponse?> ResendBrand2FAEmailAsync(string brandId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}/2faEmail", Method.Post);

            return await _policies[typeof(ResendBrand2FAEmailRequest)].ExecuteAsync(
                token => ExecuteAsync<ResendBrand2FAEmailResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RevetBrandResponse?> RevetBrandAsync(string brandId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}/revet", Method.Put);

            return await _policies[typeof(RevetBrandRequest)].ExecuteAsync(
                token => ExecuteAsync<RevetBrandResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListExternalVettingResponse?> ListExternalVettingAsync(string brandId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}/externalVetting");

            return await _policies[typeof(ListExternalVettingRequest)].ExecuteAsync(
                token => ExecuteAsync<ListExternalVettingResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ImportExternalVettingResponse?> ImportExternalVettingRecordAsync(string brandId, ImportExternalVettingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}/externalVetting", Method.Put);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(ImportExternalVettingRequest)].ExecuteAsync(
                token => ExecuteAsync<ImportExternalVettingResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        public async Task<OrderExternalVettingResponse?> OrderExternalVettingAsync(string brandId, OrderExternalVettingRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/{brandId}/externalVetting", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await _policies[typeof(OrderExternalVettingRequest)].ExecuteAsync(
                token => ExecuteAsync<OrderExternalVettingResponse>(req, token),
                cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<GetBrandFeedbackResponse?> GetBrandFeedbackAsync(string brandId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"10dlc/brand/feedback/{brandId}");

            return await _policies[typeof(GetBrandFeedbackRequest)].ExecuteAsync(
                token => ExecuteAsync<GetBrandFeedbackResponse>(req, token),
                cancellationToken);
        }

        /// <inheritdoc />
        private async Task<T1?> ExecuteAsync<T1>(RestRequest request, CancellationToken cancellationToken = default)
            where T1 : ITelnyxResponse
        {

            var response = await _client.ExecuteAsync(request, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(
                    $"Request Unsuccessful: ({response.StatusCode}) {response.Content}\n" +
                    $"Request URL: {_client.BuildUri(request)}\n" +
                    $"Request Body: {request.Parameters
                        .FirstOrDefault(p => p.Type == ParameterType.RequestBody)?.Value}");
                //if (response is { ContentType: "application/problem+json", Content: not null })
                //{
                //    //TODO: Update this to use the final ProblemDetails object being produced by Terminus
                //    var problemDetails = JsonSerializer.Deserialize<ProblemDetails>(response.Content);
                //    // Handle the problem details as needed
                //}

                // You might want to throw an exception or handle the error appropriately here
                if (response.ErrorException != null)
                    throw response.ErrorException;
            }

            if (response.Content == null) return default;
            var result = JsonSerializer.Deserialize<T1>(response.Content, TelnyxJsonSerializerContext.Default.Options);
            return result;

        }

        /// <inheritdoc />
        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}