using Polly;
using Polly.RateLimit;
using Polly.Wrap;
using RestSharp;
using RestSharp.Authenticators;
using Telnyx.NET.Interfaces;
using Telnyx.NET.Models;
using System.Text;
using System.Text.Json;

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
            string GetQueryString()
            {
                var queryBuilder = new StringBuilder();

                foreach (var type in request.NumberLookupTypes)
                {
                    if (type == NumberLookupType.CallerName)
                        queryBuilder.Append("&type=caller-name");
                    else if (type == NumberLookupType.Carrier) queryBuilder.Append("&type=carrier");
                }
                return queryBuilder.ToString();
            }

            var req = new RestRequest($"number_lookup/{request.PhoneNumber}?" + GetQueryString());
            return await _policies[request.GetType()].ExecuteAsync(token => ExecuteAsync<NumberLookupResponse>(req, token), cancellationToken);
        }

         /// <inheritdoc />
        public async Task<AvailablePhoneNumbersResponse?> AvailablePhoneNumbers(AvailablePhoneNumbersRequest request, CancellationToken cancellationToken = default)
        {
            string GetQueryString()
            {
                var queryBuilder = new StringBuilder();

                if (!string.IsNullOrEmpty(request.AdministrativeArea))
                    queryBuilder.Append($"&filter[administrative_area]={request.AdministrativeArea}");
                if (!string.IsNullOrEmpty(request.Contains))
                    queryBuilder.Append($"&filter[contains]={request.Contains}");
                if (!string.IsNullOrEmpty(request.CountryCode))
                    queryBuilder.Append($"&filter[country_code]={request.CountryCode}");
                if (!string.IsNullOrEmpty(request.EndsWith))
                    queryBuilder.Append($"&filter[ends_with]={request.EndsWith}");
                if (!string.IsNullOrEmpty(request.Features))
                    queryBuilder.Append($"&filter[features]={request.Features}");
                if (!string.IsNullOrEmpty(request.Locality))
                    queryBuilder.Append($"&filter[locality]={request.Locality}");
                if (!string.IsNullOrEmpty(request.PhoneNumberType))
                    queryBuilder.Append($"&filter[phone_number_type]={request.PhoneNumberType}");
                if (!string.IsNullOrEmpty(request.RateCenter))
                    queryBuilder.Append($"&filter[rate_center]={request.RateCenter}");
                if (!string.IsNullOrEmpty(request.StartsWith))
                    queryBuilder.Append($"&filter[starts_with]={request.StartsWith}");

                queryBuilder.Append($"&filter[limit]={request.Limit}");

                if (request.NationalDestinationCode != null)
                    queryBuilder.Append($"&filter[national_destination_code]={request.NationalDestinationCode}");
                if (request.Quickship != null)
                    queryBuilder.Append($"&filter[quickship]={request.Quickship}");
                if (request.BestEffort != null)
                    queryBuilder.Append($"&filter[best_effort]={request.BestEffort}");
                if (request.Reservable != null)
                    queryBuilder.Append($"&filter[reservable]={request.Reservable}");
                if (request.ExcludeHeldNumbers != null)
                    queryBuilder.Append($"&filter[exclude_held_numbers]={request.ExcludeHeldNumbers}");

                //They do not support pagination on phone number searches
                //if (request.PageNumber != null)
                //    queryBuilder.Append($"&page[number]={request.PageNumber}");

                //if (request.PageSize != null)
                //{
                //    if (request.PageSize > 250)
                //        request.PageSize = 250;
                //    queryBuilder.Append($"&page[size]={request.PageSize}");
                //}

                return queryBuilder.ToString();
            }

            var req = new RestRequest("available_phone_numbers?" + GetQueryString());
            return await _policies[request.GetType()].ExecuteAsync(token => ExecuteAsync<AvailablePhoneNumbersResponse>(req, token), cancellationToken);

        }

         /// <inheritdoc />
        public async Task<ListNumberOrdersResponse?> ListNumberOrders(ListNumberOrdersRequest request, CancellationToken cancellationToken = default)
        {
            string GetQueryString()
            {
                var queryBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(request.Status)) queryBuilder.Append($"&filter[status]={request.Status}");
                if (!string.IsNullOrEmpty(request.CreatedAfter))
                    queryBuilder.Append($"&filter[created_at][gt]={request.CreatedAfter}");
                if (!string.IsNullOrEmpty(request.CreatedBefore))
                    queryBuilder.Append($"&filter[created_at][lt]={request.CreatedBefore}");
                if (!string.IsNullOrEmpty(request.CustomerReference))
                    queryBuilder.Append($"&filter[customer_reference][lt]={request.CustomerReference}");


                if (request.PhoneNumberCount != null)
                    queryBuilder.Append($"&filter[phone_numbers_count]={request.PhoneNumberCount}");
                if (request.RequirementsMet != null)
                    queryBuilder.Append($"&filter[requirements_met]={request.RequirementsMet}");
                if (request.PageNumber != null) queryBuilder.Append($"&page[number]={request.PageNumber}");

                if (request.PageSize != null)
                {
                    if (request.PageSize > 250) request.PageSize = 250;
                    queryBuilder.Append($"&page[size]={request.PageSize}");
                }

                return queryBuilder.ToString();
            }

            var req = new RestRequest("number_orders?" + GetQueryString());
            var response = await _policies[request.GetType().BaseType!]
                .ExecuteAsync(token => ExecuteAsync<ListNumberOrdersResponse>(req, token), cancellationToken);

            if (response == null) return response;

            var innerResults = new List<NumberOrder>(response.Data);

            while (response!.Meta.PageNumber < response.Meta.TotalPages)
            {
                request.PageNumber++;
                req = new RestRequest("number_orders?" + GetQueryString());
                response = await _policies[request.GetType().BaseType!]
                    .ExecuteAsync(token => ExecuteAsync<ListNumberOrdersResponse>(req, token), cancellationToken);
                if (response != null) innerResults.AddRange(response.Data);
            }

            response.Data = innerResults;

            return response;
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
            string GetQueryString()
            {
                var queryBuilder = new StringBuilder();

                if (request.Tags?.Count > 0)
                {
                    request.Tags.ForEach(t =>
                    {
                        queryBuilder.Append($"&filter[tag]={t}");
                    });
                }

                if (!string.IsNullOrEmpty(request.PhoneNumber))
                    queryBuilder.Append($"&filter[phone_number]={request.PhoneNumber}");
                if (!string.IsNullOrEmpty(request.Status)) queryBuilder.Append($"&filter[status]={request.Status}");
                if (!string.IsNullOrEmpty(request.ConnectionId))
                    queryBuilder.Append($"&filter[connection_id]={request.ConnectionId}");
                if (!string.IsNullOrEmpty(request.VoiceConnectionNameContains))
                    queryBuilder.Append(
                        $"&filter[voice.connection_name][contains]={request.VoiceConnectionNameContains}");
                if (!string.IsNullOrEmpty(request.VoiceConnectionNameStartsWith))
                    queryBuilder.Append(
                        $"&filter[voice.connection_name][starts_with]={request.VoiceConnectionNameStartsWith}");
                if (!string.IsNullOrEmpty(request.VoiceConnectionNameEndsWith))
                    queryBuilder.Append(
                        $"&filter[voice.connection_name][ends_with]={request.VoiceConnectionNameEndsWith}");
                if (!string.IsNullOrEmpty(request.VoiceConnectionNameEquals))
                    queryBuilder.Append($"&filter[voice.connection_name][eq]={request.VoiceConnectionNameEquals}");
                if (!string.IsNullOrEmpty(request.UsagePaymentMethod))
                    queryBuilder.Append($"&filter[usage_payment_method]={request.UsagePaymentMethod}");
                if (!string.IsNullOrEmpty(request.BillingGroupId))
                    queryBuilder.Append($"&filter[billing_group_id]={request.BillingGroupId}");
                if (!string.IsNullOrEmpty(request.EmergencyAddressId))
                    queryBuilder.Append($"&filter[emergency_address_id]={request.EmergencyAddressId}");
                if (!string.IsNullOrEmpty(request.CustomerReference))
                    queryBuilder.Append($"&filter[customer_reference]={request.CustomerReference}");
                if (!string.IsNullOrEmpty(request.Sort))
                    queryBuilder.Append($"&sort={request.Sort}");

                if (request.PageNumber != null) queryBuilder.Append($"&page[number]={request.PageNumber}");

                if (request.PageSize != null)
                {
                    if (request.PageSize > 250) request.PageSize = 250;
                    queryBuilder.Append($"&page[size]={request.PageSize}");
                }

                return queryBuilder.ToString();
            }

            var req = new RestRequest("phone_numbers?" + GetQueryString());
            var response = await _policies[request.GetType().BaseType!]
                .ExecuteAsync(token => ExecuteAsync<ListNumbersResponse>(req, token), cancellationToken);

            if (response == null) return response;

            var innerResults = new List<ListNumbersDatum>(response.Data);

            while (response!.Meta.PageNumber < response.Meta.TotalPages)
            {
                request.PageNumber++;
                req = new RestRequest("phone_numbers?" + GetQueryString());
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
            string GetQueryString()
            {
                var queryBuilder = new StringBuilder();

                if (!string.IsNullOrEmpty(request.Status))
                    queryBuilder.Append($"&filter[status]={request.Status}");
                if (request.IncludePhoneNumbers.HasValue && request.IncludePhoneNumbers.Value)
                    queryBuilder.Append($"&include_phone_numbers={request.IncludePhoneNumbers.Value.ToString().ToLower()}");
                if (!string.IsNullOrEmpty(request.CustomerReference))
                    queryBuilder.Append($"&filter[customer_reference]={request.CustomerReference}");
                if (!string.IsNullOrEmpty(request.Sort))
                    queryBuilder.Append($"&sort={request.Sort}");


                if (request.PageNumber != null)
                    queryBuilder.Append($"&page[number]={request.PageNumber}");

                if (request.PageSize != null)
                {
                    if (request.PageSize > 250) request.PageSize = 250;
                    queryBuilder.Append($"&page[size]={request.PageSize}");
                }

                return queryBuilder.ToString();
            }

            var req = new RestRequest("porting_orders?" + GetQueryString());
            var response = await _policies[request.GetType().BaseType!]
                .ExecuteAsync(token => ExecuteAsync<ListPortingOrdersResponse>(req, token), cancellationToken);

            if (response == null) return response;

            var innerResults = new List<ListPortingOrdersDatum>(response.Data);

            while (response!.Meta.PageNumber < response.Meta.TotalPages)
            {
                request.PageNumber++;
                req = new RestRequest("porting_orders?" + GetQueryString());
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
            string GetQueryString()
            {
                var queryBuilder = new StringBuilder();

                if (request.PortingOrderId != null)
                    queryBuilder.Append($"&filter[porting_order_id]={request.PortingOrderId}");
                if (request.PortingOrderIds?.Count > 0)
                {
                    request.PortingOrderIds.ForEach(id =>
                    {
                        queryBuilder.Append($"&filter[porting_order_id][in][]={id}");
                    });
                }

                if (!string.IsNullOrEmpty(request.SupportKeyEq))
                    queryBuilder.Append($"&filter[support_key][eq]={request.SupportKeyEq}");
                if (request.SupportKeyIn?.Count > 0)
                {
                    request.SupportKeyIn.ForEach(key => { queryBuilder.Append($"&filter[support_key][in][]={key}"); });
                }

                if (!string.IsNullOrEmpty(request.PhoneNumber))
                    queryBuilder.Append($"&filter[phone_number]={request.PhoneNumber}");
                if (request.PhoneNumberIn?.Count > 0)
                {
                    request.PhoneNumberIn.ForEach(number =>
                    {
                        queryBuilder.Append($"&filter[phone_number][in][]={number}");
                    });
                }

                if (!string.IsNullOrEmpty(request.PortingOrderStatus))
                    queryBuilder.Append($"&filter[porting_order_status]={request.PortingOrderStatus}");
                if (!string.IsNullOrEmpty(request.ActivationStatus))
                    queryBuilder.Append($"&filter[activation_status]={request.ActivationStatus}");
                if (!string.IsNullOrEmpty(request.PortabilityStatus))
                    queryBuilder.Append($"&filter[portability_status]={request.PortabilityStatus}");

                if (request.PageNumber != null) queryBuilder.Append($"&page[number]={request.PageNumber}");
                if (request.PageSize != null)
                {
                    if (request.PageSize > 250) request.PageSize = 250;
                    queryBuilder.Append($"&page[size]={request.PageSize}");
                }

                return queryBuilder.ToString();
            }

            var req = new RestRequest($"porting_phone_numbers?{GetQueryString()}");
            var response = await _policies[request.GetType().BaseType!]
                .ExecuteAsync(token => ExecuteAsync<ListPortingPhoneNumbersResponse>(req, token), cancellationToken);

            if (response == null) return response;

            var innerResults = new List<ListPortingPhoneNumbersDatum>(response.Data);

            while (response!.Meta.PageNumber < response.Meta.TotalPages)
            {
                request.PageNumber = response.Meta.PageNumber + 1;
                req = new RestRequest($"porting_phone_numbers?{GetQueryString()}");
                response = await _policies[request.GetType().BaseType!]
                    .ExecuteAsync(token => ExecuteAsync<ListPortingPhoneNumbersResponse>(req, token),
                        cancellationToken);
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