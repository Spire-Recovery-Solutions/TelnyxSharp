using Moq;
using RestSharp;
using Telnyx.NET.Models;

namespace Telnyx.NET.Tests
{
    public class TelnyxClientTests
    {
        private readonly Mock<RestClient> _mockRestClient = new();
        private readonly TelnyxClient _telnyxClient = new("fakeApiKey");

        [Fact]
        public async Task NumberLookup_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new NumberLookupRequest
            {
                PhoneNumber = "1234567890",
                NumberLookupTypes = new List<NumberLookupType> { NumberLookupType.CallerName }
            };

            var expectedResponse = new NumberLookupResponse
            {
                Data = new NumberLookupDatum
                {
                    PhoneNumber = "1234567890",
                    CallerName = new NumberLookupCallerName
                    {
                        CallerNameCallerName = "John Doe",
                        ErrorCode = null
                    }
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<NumberLookupResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<NumberLookupResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.NumberLookup(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.PhoneNumber, response.Data.PhoneNumber);
            Assert.Equal(expectedResponse.Data.CallerName, response.Data.CallerName);
        }

        [Fact]
        public async Task AvailablePhoneNumbers_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new AvailablePhoneNumbersRequest
            {
                CountryCode = "US",
                Limit = 10
            };

            var expectedResponse = new AvailablePhoneNumbersResponse
            {
                Data = new List<AvailablePhoneNumber>
                {
                    new AvailablePhoneNumber { PhoneNumber = "1234567890" },
                    new AvailablePhoneNumber { PhoneNumber = "0987654321" }
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<AvailablePhoneNumbersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<AvailablePhoneNumbersResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.AvailablePhoneNumbers(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].PhoneNumber, response.Data[0].PhoneNumber);
            Assert.Equal(expectedResponse.Data[1].PhoneNumber, response.Data[1].PhoneNumber);
        }

        [Fact]
        public async Task ListNumberOrders_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new ListNumberOrdersRequest
            {
                Status = "completed",
                PageNumber = 1,
                PageSize = 10
            };

            var expectedResponse = new ListNumberOrdersResponse
            {
                Data = new List<NumberOrder>
                {
                    new NumberOrder { Id = "order1" },
                    new NumberOrder { Id = "order2" }
                },
                Meta = new ListNumberOrdersMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListNumberOrdersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListNumberOrdersResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListNumberOrders(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task Dial_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new DialRequest
            {
                To = "1234567890",
                From = "0987654321",
                ConnectionId = "connection1"
            };

            var expectedResponse = new DialResponse
            {
                Data = new DialResponseData
                {
                    CallControlId = "call1",
                    CallLegId = "leg1",
                    CallSessionId = "session1",
                    RecordType = "call",
                    IsAlive = true
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<DialResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<DialResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.Dial(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.CallControlId, response.Data.CallControlId);
            Assert.Equal(expectedResponse.Data.CallLegId, response.Data.CallLegId);
            Assert.Equal(expectedResponse.Data.CallSessionId, response.Data.CallSessionId);
            Assert.Equal(expectedResponse.Data.RecordType, response.Data.RecordType);
            Assert.Equal(expectedResponse.Data.IsAlive, response.Data.IsAlive);
        }

        [Fact]
        public async Task AnswerCall_ShouldReturnExpectedResponse()
        {
            // Arrange
            var callControlId = "call1";
            var request = new AnswerCallRequest
            {
                ClientState = "state1"
            };

            var expectedResponse = new AnswerCallResponse
            {
                Data = new AnswerCallResponseData
                {
                    Result = "success"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<AnswerCallResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<AnswerCallResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.AnswerCall(callControlId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
        }

        [Fact]
        public async Task GetNumberOrder_ShouldReturnExpectedResponse()
        {
            // Arrange
            var numberOrderId = "order1";

            var expectedResponse = new GetNumberOrderResponse
            {
                Data = new NumberOrder
                {
                    Id = "order1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GetNumberOrderResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GetNumberOrderResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetNumberOrder(numberOrderId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task CreateNumberOrder_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new CreateNumberOrderRequest
            {
                PhoneNumbers = new List<CreateNumberOrderPhoneNumber>
                {
                    new CreateNumberOrderPhoneNumber { PhoneNumber = "1234567890" }
                }
            };

            var expectedResponse = new CreateNumberOrderResponse
            {
                Data = new NumberOrder
                {
                    Id = "order1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<CreateNumberOrderResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<CreateNumberOrderResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.CreateNumberOrder(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task UpdateNumberVoiceSettings_ShouldReturnExpectedResponse()
        {
            // Arrange
            var phoneNumberId = "1234567890";
            var request = new UpdateNumberVoiceSettingsRequest
            {
                TechPrefixEnabled = true
            };

            var expectedResponse = new UpdateNumberVoiceSettingsResponse
            {
                Data = new NumberVoiceSettings
                {
                    TechPrefixEnabled = true
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UpdateNumberVoiceSettingsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UpdateNumberVoiceSettingsResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.UpdateNumberVoiceSettings(phoneNumberId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.TechPrefixEnabled, response.Data.TechPrefixEnabled);
        }

        [Fact]
        public async Task ListNumbers_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new ListNumbersRequest
            {
                PageNumber = 1,
                PageSize = 10
            };

            var expectedResponse = new ListNumbersResponse
            {
                Data = new List<ListNumbersDatum>
                {
                    new ListNumbersDatum { PhoneNumber = "1234567890" },
                    new ListNumbersDatum { PhoneNumber = "0987654321" }
                },
                Meta = new ListNumbersMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListNumbersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListNumbersResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListNumbers(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].PhoneNumber, response.Data[0].PhoneNumber);
            Assert.Equal(expectedResponse.Data[1].PhoneNumber, response.Data[1].PhoneNumber);
        }

        [Fact]
        public async Task ListPortingOrders_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new ListPortingOrdersRequest
            {
                Status = "completed",
                PageNumber = 1,
                PageSize = 10
            };

            var expectedResponse = new ListPortingOrdersResponse
            {
                Data = new List<ListPortingOrdersDatum>
                {
                    new ListPortingOrdersDatum { Id = "order1" },
                    new ListPortingOrdersDatum { Id = "order2" }
                },
                Meta = new ListPortingOrdersMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListPortingOrdersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListPortingOrdersResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListPortingOrders(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task ListPortingPhoneNumbers_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new ListPortingPhoneNumbersRequest
            {
                PageNumber = 1,
                PageSize = 10
            };

            var expectedResponse = new ListPortingPhoneNumbersResponse
            {
                Data = new List<ListPortingPhoneNumbersDatum>
                {
                    new ListPortingPhoneNumbersDatum { PhoneNumber = "1234567890" },
                    new ListPortingPhoneNumbersDatum { PhoneNumber = "0987654321" }
                },
                Meta = new ListPortingPhoneNumbersMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListPortingPhoneNumbersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListPortingPhoneNumbersResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListPortingPhoneNumbers(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].PhoneNumber, response.Data[0].PhoneNumber);
            Assert.Equal(expectedResponse.Data[1].PhoneNumber, response.Data[1].PhoneNumber);
        }

        [Fact]
        public async Task CreateNumberReservation_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new CreateNumberReservationRequest
            {
                PhoneNumbers = new List<string> { "1234567890" }
            };

            var expectedResponse = new CreateNumberReservationResponse
            {
                Data = new NumberReservation
                {
                    Id = "reservation1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<CreateNumberReservationResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<CreateNumberReservationResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.CreateNumberReservation(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task UpdateNumberConfiguration_ShouldReturnExpectedResponse()
        {
            // Arrange
            var phoneNumberId = "1234567890";
            var request = new UpdateNumberConfigurationRequest
            {
                ConnectionId = "connection1"
            };

            var expectedResponse = new UpdateNumberConfigurationResponse
            {
                Data = new NumberConfiguration
                {
                    ConnectionId = "connection1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UpdateNumberConfigurationResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UpdateNumberConfigurationResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.UpdateNumberConfiguration(phoneNumberId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.ConnectionId, response.Data.ConnectionId);
        }

        [Fact]
        public async Task RemoveNumber_ShouldReturnExpectedResponse()
        {
            // Arrange
            var numberOrObjectId = "1234567890";

            _mockRestClient.Setup(client => client.ExecuteAsync(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse { IsSuccessful = true });

            // Act
            var response = await _telnyxClient.RemoveNumber(numberOrObjectId);

            // Assert
            Assert.True(response);
        }

        [Fact]
        public async Task SendMessage_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new SendMessageRequest
            {
                To = "1234567890",
                From = "0987654321",
                Text = "Hello, world!"
            };

            var expectedResponse = new SendMessageResponse
            {
                Data = new Message
                {
                    Id = "message1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<SendMessageResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<SendMessageResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.SendMessage(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task HangupCall_ShouldReturnExpectedResponse()
        {
            // Arrange
            var callControlId = "call1";
            var request = new HangupCallRequest
            {
                ClientState = "state1"
            };

            var expectedResponse = new HangupCallResponse
            {
                Data = new HangupCallResponseData
                {
                    Result = "success"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<HangupCallResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<HangupCallResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.HangupCall(callControlId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
        }

        [Fact]
        public async Task RejectCall_ShouldReturnExpectedResponse()
        {
            // Arrange
            var callControlId = "call1";
            var request = new RejectCallRequest
            {
                ClientState = "state1",
                Cause = RejectCallCause.CALL_REJECTED
            };

            var expectedResponse = new RejectCallResponse
            {
                Data = new RejectCallResponseData
                {
                    Result = "success"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RejectCallResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RejectCallResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.RejectCall(callControlId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
        }

        [Fact]
        public async Task SpeakText_ShouldReturnExpectedResponse()
        {
            // Arrange
            var callControlId = "call1";
            var request = new SpeakTextRequest
            {
                Text = "Hello, world!"
            };

            var expectedResponse = new SpeakTextResponse
            {
                Data = new SpeakTextResponseData
                {
                    Result = "success"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<SpeakTextResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<SpeakTextResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.SpeakText(callControlId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
        }

        [Fact]
        public async Task PlaybackStart_ShouldReturnExpectedResponse()
        {
            // Arrange
            var callControlId = "call1";
            var request = new PlaybackStartRequest
            {
                AudioUrl = "https://example.com/audio.mp3"
            };

            var expectedResponse = new PlaybackStartResponse
            {
                Data = new PlaybackStartResponseData
                {
                    Result = "success"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<PlaybackStartResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<PlaybackStartResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.PlaybackStart(callControlId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
        }

        [Fact]
        public async Task StopAudioPlayback_ShouldReturnExpectedResponse()
        {
            // Arrange
            var callControlId = "call1";
            var request = new StopAudioPlaybackRequest
            {
                Stop = "all"
            };

            var expectedResponse = new StopAudioPlaybackResponse
            {
                Data = new StopAudioPlaybackResponseData
                {
                    Result = "success"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<StopAudioPlaybackResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<StopAudioPlaybackResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.StopAudioPlayback(callControlId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
        }

        [Fact]
        public async Task EnqueueCall_ShouldReturnExpectedResponse()
        {
            // Arrange
            var callControlId = "call1";
            var request = new EnqueueCallRequest
            {
                QueueName = "queue1"
            };

            var expectedResponse = new EnqueueCallResponse
            {
                Data = new EnqueueCallResponseData
                {
                    Result = "success"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<EnqueueCallResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<EnqueueCallResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.EnqueueCall(callControlId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
        }

        [Fact]
        public async Task RemoveCallFromQueue_ShouldReturnExpectedResponse()
        {
            // Arrange
            var callControlId = "call1";
            var request = new RemoveCallFromQueueRequest
            {
                ClientState = "state1"
            };

            var expectedResponse = new RemoveCallFromQueueResponse
            {
                Data = new RemoveCallFromQueueResponseData
                {
                    Result = "success"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RemoveCallFromQueueResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RemoveCallFromQueueResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.RemoveCallFromQueue(callControlId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
        }

        [Fact]
        public async Task TransferCall_ShouldReturnExpectedResponse()
        {
            // Arrange
            var callControlId = "call1";
            var request = new TransferCallRequest
            {
                To = "1234567890"
            };

            var expectedResponse = new TransferCallResponse
            {
                Data = new TransferCallResponseData
                {
                    Result = "success"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<TransferCallResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<TransferCallResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.TransferCall(callControlId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
        }

        [Fact]
        public async Task RetrieveMessagingProfile_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "profile1";

            var expectedResponse = new RetrieveMessagingProfileResponse
            {
                Data = new MessagingProfile
                {
                    Id = "profile1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RetrieveMessagingProfileResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RetrieveMessagingProfileResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.RetrieveMessagingProfile(id);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task GetMessagingProfiles_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new MessagingProfilesRequest
            {
                PageSize = 10
            };

            var expectedResponse = new MessagingProfilesResponse
            {
                Data = new List<MessagingProfile>
                {
                    new MessagingProfile { Id = "profile1" },
                    new MessagingProfile { Id = "profile2" }
                },
                Meta = new MessagingProfilesMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<MessagingProfilesResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<MessagingProfilesResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetMessagingProfiles(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task CreateMessagingProfile_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new CreateMessagingProfileRequest
            {
                Name = "Test Profile"
            };

            var expectedResponse = new CreateMessagingProfileResponse
            {
                Data = new MessagingProfile
                {
                    Id = "profile1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<CreateMessagingProfileResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<CreateMessagingProfileResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.CreateMessagingProfile(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task UpdateMessagingProfile_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "profile1";
            var request = new UpdateMessagingProfileRequest
            {
                Name = "Updated Profile"
            };

            var expectedResponse = new UpdateMessagingProfileResponse
            {
                Data = new MessagingProfile
                {
                    Id = "profile1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UpdateMessagingProfileResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UpdateMessagingProfileResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.UpdateMessagingProfile(id, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task ListMessagingProfilePhoneNumbers_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "profile1";
            var request = new MessagingProfilePhoneNumberRequest
            {
                PageSize = 10
            };

            var expectedResponse = new MessagingProfilePhoneNumberResponse
            {
                Data = new List<MessagingProfilePhoneNumber>
                {
                    new MessagingProfilePhoneNumber { PhoneNumber = "1234567890" },
                    new MessagingProfilePhoneNumber { PhoneNumber = "0987654321" }
                },
                Meta = new MessagingProfilePhoneNumberMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<MessagingProfilePhoneNumberResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<MessagingProfilePhoneNumberResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListMessagingProfilePhoneNumbers(id, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].PhoneNumber, response.Data[0].PhoneNumber);
            Assert.Equal(expectedResponse.Data[1].PhoneNumber, response.Data[1].PhoneNumber);
        }

        [Fact]
        public async Task DeleteMessagingProfile_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "profile1";

            var expectedResponse = new DeleteMessagingProfileResponse
            {
                Data = new MessagingProfile
                {
                    Id = "profile1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<DeleteMessagingProfileResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<DeleteMessagingProfileResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.DeleteMessagingProfile(id);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task ListMessagingProfileShortCodes_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "profile1";
            var request = new MessagingProfileShortCodeRequest
            {
                PageSize = 10
            };

            var expectedResponse = new MessagingProfileShortCodeResponse
            {
                Data = new List<MessagingProfileShortCode>
                {
                    new MessagingProfileShortCode { ShortCode = "12345" },
                    new MessagingProfileShortCode { ShortCode = "67890" }
                },
                Meta = new MessagingProfileShortCodeMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<MessagingProfileShortCodeResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<MessagingProfileShortCodeResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListMessagingProfileShortCodes(id, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].ShortCode, response.Data[0].ShortCode);
            Assert.Equal(expectedResponse.Data[1].ShortCode, response.Data[1].ShortCode);
        }

        [Fact]
        public async Task RetrieveMessagingProfileMetrics_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "profile1";
            var request = new RetrieveMessagingProfileMetricsRequest
            {
                TimeFrame = "last_30_days"
            };

            var expectedResponse = new RetrieveMessagingProfileMetricsResponse
            {
                Data = new MessagingProfileMetrics
                {
                    TotalMessages = 100,
                    TotalErrors = 5
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RetrieveMessagingProfileMetricsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RetrieveMessagingProfileMetricsResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.RetrieveMessagingProfileMetrics(id, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.TotalMessages, response.Data.TotalMessages);
            Assert.Equal(expectedResponse.Data.TotalErrors, response.Data.TotalErrors);
        }

        [Fact]
        public async Task ListMessagingProfileMetrics_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new MessagingProfileMetricsRequest
            {
                PageSize = 10,
                TimeFrame = "last_30_days"
            };

            var expectedResponse = new MessagingProfileMetricsResponse
            {
                Data = new List<MessagingProfileMetrics>
                {
                    new MessagingProfileMetrics { TotalMessages = 100, TotalErrors = 5 },
                    new MessagingProfileMetrics { TotalMessages = 200, TotalErrors = 10 }
                },
                Meta = new MessagingProfileMetricsMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<MessagingProfileMetricsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<MessagingProfileMetricsResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListMessagingProfileMetrics(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].TotalMessages, response.Data[0].TotalMessages);
            Assert.Equal(expectedResponse.Data[0].TotalErrors, response.Data[0].TotalErrors);
            Assert.Equal(expectedResponse.Data[1].TotalMessages, response.Data[1].TotalMessages);
            Assert.Equal(expectedResponse.Data[1].TotalErrors, response.Data[1].TotalErrors);
        }

        [Fact]
        public async Task SendMessageUsingNumberPoolAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new NumberPoolMessageRequest
            {
                To = "1234567890",
                From = "0987654321",
                Text = "Hello, world!"
            };

            var expectedResponse = new NumberPoolMessageResponse
            {
                Data = new Message
                {
                    Id = "message1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<NumberPoolMessageResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<NumberPoolMessageResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.SendMessageUsingNumberPoolAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task SendLongCodeMessage_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new LongCodeMessageRequest
            {
                To = "1234567890",
                From = "0987654321",
                Text = "Hello, world!"
            };

            var expectedResponse = new LongCodeMessageResponse
            {
                Data = new Message
                {
                    Id = "message1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<LongCodeMessageResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<LongCodeMessageResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.SendLongCodeMessage(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task SendShortCodeMessageAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new ShortCodeMessageRequest
            {
                To = "1234567890",
                From = "0987654321",
                Text = "Hello, world!"
            };

            var expectedResponse = new ShortCodeMessageResponse
            {
                Data = new Message
                {
                    Id = "message1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ShortCodeMessageResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ShortCodeMessageResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.SendShortCodeMessageAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task SendGroupMmsMessageAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new GroupMmsMessageRequest
            {
                To = new List<string> { "1234567890", "0987654321" },
                From = "0987654321",
                Text = "Hello, world!"
            };

            var expectedResponse = new GroupMmsMessageResponse
            {
                Data = new Message
                {
                    Id = "message1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GroupMmsMessageResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GroupMmsMessageResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.SendGroupMmsMessageAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task RetrieveMessageAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "message1";

            var expectedResponse = new RetrieveMessageResponse
            {
                Data = new Message
                {
                    Id = "message1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RetrieveMessageResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RetrieveMessageResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.RetrieveMessageAsync(id);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task ListMessagingUrlDomainsAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new ListMessagingUrlDomainsRequest
            {
                PageSize = 10
            };

            var expectedResponse = new ListMessagingUrlDomainsResponse
            {
                Data = new List<MessagingUrlDomain>
                {
                    new MessagingUrlDomain { Id = "domain1" },
                    new MessagingUrlDomain { Id = "domain2" }
                },
                Meta = new ListMessagingUrlDomainsMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListMessagingUrlDomainsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListMessagingUrlDomainsResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListMessagingUrlDomainsAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task ListShortCodesAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new ListShortCodesRequest
            {
                PageSize = 10
            };

            var expectedResponse = new ListShortCodesResponse
            {
                Data = new List<ShortCode>
                {
                    new ShortCode { Id = "shortcode1" },
                    new ShortCode { Id = "shortcode2" }
                },
                Meta = new ListShortCodesMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListShortCodesResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListShortCodesResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListShortCodesAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task RetrieveShortCodeAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var shortCodeId = "shortcode1";

            var expectedResponse = new RetrieveShortCodeResponse
            {
                Data = new ShortCode
                {
                    Id = "shortcode1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RetrieveShortCodeResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RetrieveShortCodeResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.RetrieveShortCodeAsync(shortCodeId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task UpdateShortCodeAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var shortCodeId = "shortcode1";
            var request = new UpdateShortCodeRequest
            {
                ShortCode = "12345"
            };

            var expectedResponse = new UpdateShortCodeResponse
            {
                Data = new ShortCode
                {
                    Id = "shortcode1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UpdateShortCodeResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UpdateShortCodeResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.UpdateShortCodeAsync(shortCodeId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task ListPhoneNumbersWithMessagingSettingsAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new ListPhoneMessageSettingsRequest
            {
                PageSize = 10
            };

            var expectedResponse = new ListPhoneMessageSettingsResponse
            {
                Data = new List<PhoneMessageSettings>
                {
                    new PhoneMessageSettings { PhoneNumber = "1234567890" },
                    new PhoneMessageSettings { PhoneNumber = "0987654321" }
                },
                Meta = new ListPhoneMessageSettingsMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListPhoneMessageSettingsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListPhoneMessageSettingsResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListPhoneNumbersWithMessagingSettingsAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].PhoneNumber, response.Data[0].PhoneNumber);
            Assert.Equal(expectedResponse.Data[1].PhoneNumber, response.Data[1].PhoneNumber);
        }

        [Fact]
        public async Task GetPhoneNumberWithMessagingSettingsAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "phone1";

            var expectedResponse = new RetrievePhoneMessageSettingsResponse
            {
                Data = new PhoneMessageSettings
                {
                    PhoneNumber = "1234567890"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RetrievePhoneMessageSettingsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RetrievePhoneMessageSettingsResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetPhoneNumberWithMessagingSettingsAsync(id);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.PhoneNumber, response.Data.PhoneNumber);
        }

        [Fact]
        public async Task UpdatePhoneNumberMessagingSettingsAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "phone1";
            var request = new UpdatePhoneNumberMessagingRequest
            {
                MessagingProfileId = "profile1"
            };

            var expectedResponse = new UpdatePhoneNumberMessagingResponse
            {
                Data = new PhoneMessageSettings
                {
                    PhoneNumber = "1234567890"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UpdatePhoneNumberMessagingResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UpdatePhoneNumberMessagingResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.UpdatePhoneNumberMessagingSettingsAsync(id, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.PhoneNumber, response.Data.PhoneNumber);
        }

        [Fact]
        public async Task UpdateMessagingProfileForMultipleNumbersAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new UpdateNumbersMessagingBulkRequest
            {
                PhoneNumbers = new List<string> { "1234567890", "0987654321" },
                MessagingProfileId = "profile1"
            };

            var expectedResponse = new UpdateNumbersMessagingBulkResponse
            {
                Data = new List<PhoneMessageSettings>
                {
                    new PhoneMessageSettings { PhoneNumber = "1234567890" },
                    new PhoneMessageSettings { PhoneNumber = "0987654321" }
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UpdateNumbersMessagingBulkResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UpdateNumbersMessagingBulkResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.UpdateMessagingProfileForMultipleNumbersAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].PhoneNumber, response.Data[0].PhoneNumber);
            Assert.Equal(expectedResponse.Data[1].PhoneNumber, response.Data[1].PhoneNumber);
        }

        [Fact]
        public async Task RetrieveBulkUpdateStatusAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var orderId = "order1";

            var expectedResponse = new RetrieveBulkUpdateStatusResponse
            {
                Data = new BulkUpdateStatus
                {
                    Id = "order1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RetrieveBulkUpdateStatusResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RetrieveBulkUpdateStatusResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.RetrieveBulkUpdateStatusAsync(orderId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task DeleteHostedNumberAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "hostednumber1";

            var expectedResponse = new DeleteHostedNumberResponse
            {
                Data = new HostedNumber
                {
                    Id = "hostednumber1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<DeleteHostedNumberResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<DeleteHostedNumberResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.DeleteHostedNumberAsync(id);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task ListHostedNumberOrdersAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new GetHostedNumberOrderRequest
            {
                PageSize = 10
            };

            var expectedResponse = new GetHostedNumberOrderResponse
            {
                Data = new List<HostedNumberOrder>
                {
                    new HostedNumberOrder { Id = "order1" },
                    new HostedNumberOrder { Id = "order2" }
                },
                Meta = new GetHostedNumberOrderMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GetHostedNumberOrderResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GetHostedNumberOrderResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListHostedNumberOrdersAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task CreateHostedNumberOrderAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new CreateHostedNumberOrderRequest
            {
                PhoneNumbers = new List<string> { "1234567890" }
            };

            var expectedResponse = new CreateHostedNumberOrderResponse
            {
                Data = new HostedNumberOrder
                {
                    Id = "order1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<CreateHostedNumberOrderResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<CreateHostedNumberOrderResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.CreateHostedNumberOrderAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task RetrieveHostedNumberOrderAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "order1";

            var expectedResponse = new RetrieveHostedNumberOrderResponse
            {
                Data = new HostedNumberOrder
                {
                    Id = "order1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RetrieveHostedNumberOrderResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RetrieveHostedNumberOrderResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.RetrieveHostedNumberOrderAsync(id);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task UploadFileRequiredForHostedNumberOrderAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "order1";
            var request = new UploadFileHostedNumberOrderRequest
            {
                File = "file1"
            };

            var expectedResponse = new UploadFileHostedNumberOrderResponse
            {
                Data = new HostedNumberOrder
                {
                    Id = "order1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UploadFileHostedNumberOrderResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UploadFileHostedNumberOrderResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.UploadFileRequiredForHostedNumberOrderAsync(id, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task ListAutoResponseSettingsAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var profileId = "profile1";
            var request = new ListAutoResponseSettingsRequest
            {
                PageSize = 10
            };

            var expectedResponse = new ListAutoResponseSettingsResponse
            {
                Data = new List<AutoResponseSetting>
                {
                    new AutoResponseSetting { Id = "setting1" },
                    new AutoResponseSetting { Id = "setting2" }
                },
                Meta = new ListAutoResponseSettingsMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListAutoResponseSettingsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListAutoResponseSettingsResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListAutoResponseSettingsAsync(profileId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task CreateAutoResponseSettingAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var profileId = "profile1";
            var request = new CreateAutoResponseSettingRequest
            {
                Name = "Test Setting"
            };

            var expectedResponse = new CreateAutoResponseSettingResponse
            {
                Data = new AutoResponseSetting
                {
                    Id = "setting1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<CreateAutoResponseSettingResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<CreateAutoResponseSettingResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.CreateAutoResponseSettingAsync(profileId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task GetAutoResponseSettingAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var profileId = "profile1";
            var autorespCfgId = "setting1";

            var expectedResponse = new GetAutoResponseSettingResponse
            {
                Data = new AutoResponseSetting
                {
                    Id = "setting1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GetAutoResponseSettingResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GetAutoResponseSettingResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetAutoResponseSettingAsync(profileId, autorespCfgId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task UpdateAutoResponseSettingAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var profileId = "profile1";
            var autorespCfgId = "setting1";
            var request = new UpdateAutoResponseSettingRequest
            {
                Name = "Updated Setting"
            };

            var expectedResponse = new UpdateAutoResponseSettingResponse
            {
                Data = new AutoResponseSetting
                {
                    Id = "setting1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UpdateAutoResponseSettingResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UpdateAutoResponseSettingResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.UpdateAutoResponseSettingAsync(profileId, autorespCfgId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task DeleteAutoResponseSettingAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var profileId = "profile1";
            var autorespCfgId = "setting1";

            var expectedResponse = new DeleteAutoResponseSettingResponse
            {
                Data = new AutoResponseSetting
                {
                    Id = "setting1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<DeleteAutoResponseSettingResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<DeleteAutoResponseSettingResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.DeleteAutoResponseSettingAsync(profileId, autorespCfgId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task ListVerificationRequestsAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new ListVerificationRequestsRequest
            {
                PageSize = 10
            };

            var expectedResponse = new ListVerificationRequestsResponse
            {
                Data = new List<VerificationRequest>
                {
                    new VerificationRequest { Id = "request1" },
                    new VerificationRequest { Id = "request2" }
                },
                Meta = new ListVerificationRequestsMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListVerificationRequestsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListVerificationRequestsResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListVerificationRequestsAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task SubmitVerificationRequestAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new SubmitVerificationRequestRequest
            {
                PhoneNumber = "1234567890"
            };

            var expectedResponse = new SubmitVerificationRequestResponse
            {
                Data = new VerificationRequest
                {
                    Id = "request1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<SubmitVerificationRequestResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<SubmitVerificationRequestResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.SubmitVerificationRequestAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task GetVerificationRequestAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "request1";

            var expectedResponse = new GetVerificationRequestResponse
            {
                Data = new VerificationRequest
                {
                    Id = "request1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GetVerificationRequestResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GetVerificationRequestResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetVerificationRequestAsync(id);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task DeleteVerificationRequestAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "request1";

            var expectedResponse = new DeleteVerificationRequestResponse
            {
                Data = new VerificationRequest
                {
                    Id = "request1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<DeleteVerificationRequestResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<DeleteVerificationRequestResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.DeleteVerificationRequestAsync(id);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task UpdateVerificationRequestAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var id = "request1";
            var request = new UpdateVerificationRequestRequest
            {
                PhoneNumber = "1234567890"
            };

            var expectedResponse = new UpdateVerificationRequestResponse
            {
                Data = new VerificationRequest
                {
                    Id = "request1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UpdateVerificationRequestResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UpdateVerificationRequestResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.UpdateVerificationRequestAsync(id, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task ListBrandsAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new ListBrandsRequest
            {
                PageSize = 10
            };

            var expectedResponse = new ListBrandsResponse
            {
                Data = new List<Brand>
                {
                    new Brand { Id = "brand1" },
                    new Brand { Id = "brand2" }
                },
                Meta = new ListBrandsMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListBrandsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListBrandsResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListBrandsAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task CreateBrandAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new CreateBrandRequest
            {
                Name = "Test Brand"
            };

            var expectedResponse = new CreateBrandResponse
            {
                Data = new Brand
                {
                    Id = "brand1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<CreateBrandResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<CreateBrandResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.CreateBrandAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task GetBrandAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var brandId = "brand1";

            var expectedResponse = new GetBrandResponse
            {
                Data = new Brand
                {
                    Id = "brand1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GetBrandResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GetBrandResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetBrandAsync(brandId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task UpdateBrandAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var brandId = "brand1";
            var request = new UpdateBrandRequest
            {
                Name = "Updated Brand"
            };

            var expectedResponse = new UpdateBrandResponse
            {
                Data = new Brand
                {
                    Id = "brand1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UpdateBrandResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UpdateBrandResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.UpdateBrandAsync(brandId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task DeleteBrandAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var brandId = "brand1";

            var expectedResponse = new DeleteBrandResponse
            {
                Data = new Brand
                {
                    Id = "brand1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<DeleteBrandResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<DeleteBrandResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.DeleteBrandAsync(brandId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task ResendBrand2FAEmailAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var brandId = "brand1";

            var expectedResponse = new ResendBrand2FAEmailResponse
            {
                Data = new Brand
                {
                    Id = "brand1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ResendBrand2FAEmailResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ResendBrand2FAEmailResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ResendBrand2FAEmailAsync(brandId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task RevetBrandAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var brandId = "brand1";

            var expectedResponse = new RevetBrandResponse
            {
                Data = new Brand
                {
                    Id = "brand1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RevetBrandResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RevetBrandResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.RevetBrandAsync(brandId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task ListExternalVettingAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var brandId = "brand1";

            var expectedResponse = new ListExternalVettingResponse
            {
                Data = new List<ExternalVetting>
                {
                    new ExternalVetting { Id = "vetting1" },
                    new ExternalVetting { Id = "vetting2" }
                },
                Meta = new ListExternalVettingMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListExternalVettingResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListExternalVettingResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListExternalVettingAsync(brandId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task ImportExternalVettingRecordAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var brandId = "brand1";
            var request = new ImportExternalVettingRequest
            {
                VettingId = "vetting1"
            };

            var expectedResponse = new ImportExternalVettingResponse
            {
                Data = new ExternalVetting
                {
                    Id = "vetting1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ImportExternalVettingResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ImportExternalVettingResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ImportExternalVettingRecordAsync(brandId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task OrderExternalVettingAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var brandId = "brand1";
            var request = new OrderExternalVettingRequest
            {
                VettingId = "vetting1"
            };

            var expectedResponse = new OrderExternalVettingResponse
            {
                Data = new ExternalVetting
                {
                    Id = "vetting1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<OrderExternalVettingResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<OrderExternalVettingResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.OrderExternalVettingAsync(brandId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task GetBrandFeedbackAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var brandId = "brand1";

            var expectedResponse = new GetBrandFeedbackResponse
            {
                Data = new BrandFeedback
                {
                    Id = "feedback1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GetBrandFeedbackResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GetBrandFeedbackResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetBrandFeedbackAsync(brandId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task ListCampaignsAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new ListCampaignsRequest
            {
                PageSize = 10
            };

            var expectedResponse = new ListCampaignsResponse
            {
                Data = new List<Campaign>
                {
                    new Campaign { Id = "campaign1" },
                    new Campaign { Id = "campaign2" }
                },
                Meta = new ListCampaignsMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListCampaignsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListCampaignsResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.ListCampaignsAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task GetCampaignAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var campaignId = "campaign1";

            var expectedResponse = new GetCampaignResponse
            {
                Data = new Campaign
                {
                    Id = "campaign1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GetCampaignResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GetCampaignResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetCampaignAsync(campaignId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task UpdateCampaignAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var campaignId = "campaign1";
            var request = new UpdateCampaignRequest
            {
                Name = "Updated Campaign"
            };

            var expectedResponse = new UpdateCampaignResponse
            {
                Data = new Campaign
                {
                    Id = "campaign1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UpdateCampaignResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UpdateCampaignResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.UpdateCampaignAsync(campaignId, request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task DeactivateCampaignAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var campaignId = "campaign1";

            var expectedResponse = new DeactivateCampaignResponse
            {
                Data = new Campaign
                {
                    Id = "campaign1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<DeactivateCampaignResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<DeactivateCampaignResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.DeactivateCampaignAsync(campaignId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task GetCampaignOperationStatusAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var campaignId = "campaign1";

            var expectedResponse = new GetCampaignOperationStatusResponse
            {
                Data = new CampaignOperationStatus
                {
                    Id = "status1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GetCampaignOperationStatusResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GetCampaignOperationStatusResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetCampaignOperationStatusAsync(campaignId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task GetCampaignOsrAttributesAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var campaignId = "campaign1";

            var expectedResponse = new GetCampaignOsrAttributesResponse
            {
                Data = new CampaignOsrAttributes
                {
                    Id = "attributes1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GetCampaignOsrAttributesResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GetCampaignOsrAttributesResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetCampaignOsrAttributesAsync(campaignId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task GetCampaignCostAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new GetCampaignCostRequest
            {
                UseCase = "test_use_case"
            };

            var expectedResponse = new GetCampaignCostResponse
            {
                Data = new CampaignCost
                {
                    Id = "cost1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GetCampaignCostResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GetCampaignCostResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetCampaignCostAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task SubmitCampaignAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new SubmitCampaignRequest
            {
                Name = "Test Campaign"
            };

            var expectedResponse = new SubmitCampaignResponse
            {
                Data = new Campaign
                {
                    Id = "campaign1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<SubmitCampaignResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<SubmitCampaignResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.SubmitCampaignAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task QualifyCampaignByUsecaseAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var brandId = "brand1";
            var usecase = "test_use_case";

            var expectedResponse = new QualifyCampaignByUsecaseResponse
            {
                Data = new CampaignQualification
                {
                    Id = "qualification1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<QualifyCampaignByUsecaseResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<QualifyCampaignByUsecaseResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.QualifyCampaignByUsecaseAsync(brandId, usecase);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task GetCampaignMnoMetadataAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var campaignId = "campaign1";

            var expectedResponse = new GetCampaignMnoMetadataResponse
            {
                Data = new CampaignMnoMetadata
                {
                    Id = "metadata1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<GetCampaignMnoMetadataResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<GetCampaignMnoMetadataResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.GetCampaignMnoMetadataAsync(campaignId);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
        }

        [Fact]
        public async Task RetrievePhoneNumberCampaignsAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new RetrievePhoneNumberCampaignsRequest
            {
                PageSize = 10
            };

            var expectedResponse = new RetrievePhoneNumberCampaignsResponse
            {
                Data = new List<PhoneNumberCampaign>
                {
                    new PhoneNumberCampaign { Id = "campaign1" },
                    new PhoneNumberCampaign { Id = "campaign2" }
                },
                Meta = new RetrievePhoneNumberCampaignsMeta
                {
                    TotalPages = 1,
                    TotalResults = 2,
                    PageNumber = 1,
                    PageSize = 10
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RetrievePhoneNumberCampaignsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RetrievePhoneNumberCampaignsResponse> { Data = expectedResponse });

            // Act
            var response = await _telnyxClient.RetrievePhoneNumberCampaignsAsync(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
            Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
            Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
        }

        [Fact]
        public async Task CreatePhoneNumberCampaignAsync_ShouldReturnExpectedResponse()
        {
            // Arrange
            var request = new CreatePhoneNumberCampaignRequest
            {
                PhoneNumber = "1234567890"
            };

            var expectedResponse = new CreatePhoneNumberCampaignResponse
            {
                Data = new PhoneNumberCampaign
                {
                    Id = "campaign1"
                }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<CreatePhoneNumberCampaignResponse>(It.IsAny
