// using Moq;
// using RestSharp;
// using Telnyx.NET.Models;
//
// namespace Telnyx.NET.Tests
// {
//     public class TelnyxClientTests
//     {
//         private readonly Mock<RestClient> _mockRestClient = new();
//         private readonly TelnyxClient _telnyxClient = new("fakeApiKey");
//
//         [Fact]
//         public async Task NumberLookup_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var request = new NumberLookupRequest
//             {
//                 PhoneNumber = "1234567890",
//                 NumberLookupTypes = new List<NumberLookupType> { NumberLookupType.CallerName }
//             };
//
//             var expectedResponse = new NumberLookupResponse
//             {
//                 Data = new NumberLookupDatum
//                 {
//                     PhoneNumber = "1234567890",
//                     CallerName = new NumberLookupCallerName
//                     {
//                         CallerNameCallerName = "John Doe",
//                         ErrorCode = null
//                     }
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<NumberLookupResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<NumberLookupResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.NumberLookup(request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.PhoneNumber, response.Data.PhoneNumber);
//             Assert.Equal(expectedResponse.Data.CallerName, response.Data.CallerName);
//         }
//
//         [Fact]
//         public async Task AvailablePhoneNumbers_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var request = new AvailablePhoneNumbersRequest
//             {
//                 CountryCode = "US",
//                 Limit = 10
//             };
//
//             var expectedResponse = new AvailablePhoneNumbersResponse
//             {
//                 Data = new List<AvailablePhoneNumber>
//                 {
//                     new AvailablePhoneNumber { PhoneNumber = "1234567890" },
//                     new AvailablePhoneNumber { PhoneNumber = "0987654321" }
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<AvailablePhoneNumbersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<AvailablePhoneNumbersResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.AvailablePhoneNumbers(request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
//             Assert.Equal(expectedResponse.Data[0].PhoneNumber, response.Data[0].PhoneNumber);
//             Assert.Equal(expectedResponse.Data[1].PhoneNumber, response.Data[1].PhoneNumber);
//         }
//
//         [Fact]
//         public async Task ListNumberOrders_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var request = new ListNumberOrdersRequest
//             {
//                 Status = "completed",
//                 PageNumber = 1,
//                 PageSize = 10
//             };
//
//             var expectedResponse = new ListNumberOrdersResponse
//             {
//                 Data = new List<NumberOrder>
//                 {
//                     new NumberOrder { Id = "order1" },
//                     new NumberOrder { Id = "order2" }
//                 },
//                 Meta = new ListNumberOrdersMeta
//                 {
//                     TotalPages = 1,
//                     TotalResults = 2,
//                     PageNumber = 1,
//                     PageSize = 10
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<ListNumberOrdersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<ListNumberOrdersResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.ListNumberOrders(request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
//             Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
//             Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
//         }
//
//         [Fact]
//         public async Task Dial_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var request = new DialRequest
//             {
//                 To = "1234567890",
//                 From = "0987654321",
//                 ConnectionId = "connection1"
//             };
//
//             var expectedResponse = new DialResponse
//             {
//                 Data = new DialResponseData
//                 {
//                     CallControlId = "call1",
//                     CallLegId = "leg1",
//                     CallSessionId = "session1",
//                     RecordType = "call",
//                     IsAlive = true
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<DialResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<DialResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.Dial(request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.CallControlId, response.Data.CallControlId);
//             Assert.Equal(expectedResponse.Data.CallLegId, response.Data.CallLegId);
//             Assert.Equal(expectedResponse.Data.CallSessionId, response.Data.CallSessionId);
//             Assert.Equal(expectedResponse.Data.RecordType, response.Data.RecordType);
//             Assert.Equal(expectedResponse.Data.IsAlive, response.Data.IsAlive);
//         }
//
//         [Fact]
//         public async Task AnswerCall_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var callControlId = "call1";
//             var request = new AnswerCallRequest
//             {
//                 ClientState = "state1"
//             };
//
//             var expectedResponse = new AnswerCallResponse
//             {
//                 Data = new AnswerCallResponseData
//                 {
//                     Result = "success"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<AnswerCallResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<AnswerCallResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.AnswerCall(callControlId, request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
//         }
//
//         [Fact]
//         public async Task GetNumberOrder_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var numberOrderId = "order1";
//
//             var expectedResponse = new GetNumberOrderResponse
//             {
//                 Data = new NumberOrder
//                 {
//                     Id = "order1"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<GetNumberOrderResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<GetNumberOrderResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.GetNumberOrder(numberOrderId);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
//         }
//
//         [Fact]
//         public async Task CreateNumberOrder_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var request = new CreateNumberOrderRequest
//             {
//                 PhoneNumbers = new List<CreateNumberOrderPhoneNumber>
//                 {
//                     new CreateNumberOrderPhoneNumber { PhoneNumber = "1234567890" }
//                 }
//             };
//
//             var expectedResponse = new CreateNumberOrderResponse
//             {
//                 Data = new NumberOrder
//                 {
//                     Id = "order1"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<CreateNumberOrderResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<CreateNumberOrderResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.CreateNumberOrder(request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
//         }
//
//         [Fact]
//         public async Task UpdateNumberVoiceSettings_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var phoneNumberId = "1234567890";
//             var request = new UpdateNumberVoiceSettingsRequest
//             {
//                 TechPrefixEnabled = true
//             };
//
//             var expectedResponse = new UpdateNumberVoiceSettingsResponse
//             {
//                 Data = new NumberVoiceSettings
//                 {
//                     TechPrefixEnabled = true
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<UpdateNumberVoiceSettingsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<UpdateNumberVoiceSettingsResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.UpdateNumberVoiceSettings(phoneNumberId, request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.TechPrefixEnabled, response.Data.TechPrefixEnabled);
//         }
//
//         [Fact]
//         public async Task ListNumbers_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var request = new ListNumbersRequest
//             {
//                 PageNumber = 1,
//                 PageSize = 10
//             };
//
//             var expectedResponse = new ListNumbersResponse
//             {
//                 Data = new List<ListNumbersDatum>
//                 {
//                     new ListNumbersDatum { PhoneNumber = "1234567890" },
//                     new ListNumbersDatum { PhoneNumber = "0987654321" }
//                 },
//                 Meta = new ListNumbersMeta
//                 {
//                     TotalPages = 1,
//                     TotalResults = 2,
//                     PageNumber = 1,
//                     PageSize = 10
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<ListNumbersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<ListNumbersResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.ListNumbers(request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
//             Assert.Equal(expectedResponse.Data[0].PhoneNumber, response.Data[0].PhoneNumber);
//             Assert.Equal(expectedResponse.Data[1].PhoneNumber, response.Data[1].PhoneNumber);
//         }
//
//         [Fact]
//         public async Task ListPortingOrders_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var request = new ListPortingOrdersRequest
//             {
//                 Status = "completed",
//                 PageNumber = 1,
//                 PageSize = 10
//             };
//
//             var expectedResponse = new ListPortingOrdersResponse
//             {
//                 Data = new List<ListPortingOrdersDatum>
//                 {
//                     new ListPortingOrdersDatum { Id = "order1" },
//                     new ListPortingOrdersDatum { Id = "order2" }
//                 },
//                 Meta = new ListPortingOrdersMeta
//                 {
//                     TotalPages = 1,
//                     TotalResults = 2,
//                     PageNumber = 1,
//                     PageSize = 10
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<ListPortingOrdersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<ListPortingOrdersResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.ListPortingOrders(request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
//             Assert.Equal(expectedResponse.Data[0].Id, response.Data[0].Id);
//             Assert.Equal(expectedResponse.Data[1].Id, response.Data[1].Id);
//         }
//
//         [Fact]
//         public async Task ListPortingPhoneNumbers_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var request = new ListPortingPhoneNumbersRequest
//             {
//                 PageNumber = 1,
//                 PageSize = 10
//             };
//
//             var expectedResponse = new ListPortingPhoneNumbersResponse
//             {
//                 Data = new List<ListPortingPhoneNumbersDatum>
//                 {
//                     new ListPortingPhoneNumbersDatum { PhoneNumber = "1234567890" },
//                     new ListPortingPhoneNumbersDatum { PhoneNumber = "0987654321" }
//                 },
//                 Meta = new ListPortingPhoneNumbersMeta
//                 {
//                     TotalPages = 1,
//                     TotalResults = 2,
//                     PageNumber = 1,
//                     PageSize = 10
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<ListPortingPhoneNumbersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<ListPortingPhoneNumbersResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.ListPortingPhoneNumbers(request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Count, response.Data.Count);
//             Assert.Equal(expectedResponse.Data[0].PhoneNumber, response.Data[0].PhoneNumber);
//             Assert.Equal(expectedResponse.Data[1].PhoneNumber, response.Data[1].PhoneNumber);
//         }
//
//         [Fact]
//         public async Task CreateNumberReservation_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var request = new CreateNumberReservationRequest
//             {
//                 PhoneNumbers = new List<string> { "1234567890" }
//             };
//
//             var expectedResponse = new CreateNumberReservationResponse
//             {
//                 Data = new NumberReservation
//                 {
//                     Id = "reservation1"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<CreateNumberReservationResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<CreateNumberReservationResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.CreateNumberReservation(request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
//         }
//
//         [Fact]
//         public async Task UpdateNumberConfiguration_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var phoneNumberId = "1234567890";
//             var request = new UpdateNumberConfigurationRequest
//             {
//                 ConnectionId = "connection1"
//             };
//
//             var expectedResponse = new UpdateNumberConfigurationResponse
//             {
//                 Data = new NumberConfiguration
//                 {
//                     ConnectionId = "connection1"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<UpdateNumberConfigurationResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<UpdateNumberConfigurationResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.UpdateNumberConfiguration(phoneNumberId, request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.ConnectionId, response.Data.ConnectionId);
//         }
//
//         [Fact]
//         public async Task RemoveNumber_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var numberOrObjectId = "1234567890";
//
//             _mockRestClient.Setup(client => client.ExecuteAsync(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse { IsSuccessful = true });
//
//             // Act
//             var response = await _telnyxClient.RemoveNumber(numberOrObjectId);
//
//             // Assert
//             Assert.True(response);
//         }
//
//         [Fact]
//         public async Task SendMessage_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var request = new SendMessageRequest
//             {
//                 To = "1234567890",
//                 From = "0987654321",
//                 Text = "Hello, world!"
//             };
//
//             var expectedResponse = new SendMessageResponse
//             {
//                 Data = new Message
//                 {
//                     Id = "message1"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<SendMessageResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<SendMessageResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.SendMessage(request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Id, response.Data.Id);
//         }
//
//         [Fact]
//         public async Task HangupCall_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var callControlId = "call1";
//             var request = new HangupCallRequest
//             {
//                 ClientState = "state1"
//             };
//
//             var expectedResponse = new HangupCallResponse
//             {
//                 Data = new HangupCallResponseData
//                 {
//                     Result = "success"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<HangupCallResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<HangupCallResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.HangupCall(callControlId, request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
//         }
//
//         [Fact]
//         public async Task RejectCall_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var callControlId = "call1";
//             var request = new RejectCallRequest
//             {
//                 ClientState = "state1",
//                 Cause = RejectCallCause.CALL_REJECTED
//             };
//
//             var expectedResponse = new RejectCallResponse
//             {
//                 Data = new RejectCallResponseData
//                 {
//                     Result = "success"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<RejectCallResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<RejectCallResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.RejectCall(callControlId, request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
//         }
//
//         [Fact]
//         public async Task SpeakText_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var callControlId = "call1";
//             var request = new SpeakTextRequest
//             {
//                 Text = "Hello, world!"
//             };
//
//             var expectedResponse = new SpeakTextResponse
//             {
//                 Data = new SpeakTextResponseData
//                 {
//                     Result = "success"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<SpeakTextResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<SpeakTextResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.SpeakText(callControlId, request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
//         }
//
//         [Fact]
//         public async Task PlaybackStart_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var callControlId = "call1";
//             var request = new PlaybackStartRequest
//             {
//                 AudioUrl = "https://example.com/audio.mp3"
//             };
//
//             var expectedResponse = new PlaybackStartResponse
//             {
//                 Data = new PlaybackStartResponseData
//                 {
//                     Result = "success"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<PlaybackStartResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<PlaybackStartResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.PlaybackStart(callControlId, request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
//         }
//
//         [Fact]
//         public async Task StopAudioPlayback_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var callControlId = "call1";
//             var request = new StopAudioPlaybackRequest
//             {
//                 Stop = "all"
//             };
//
//             var expectedResponse = new StopAudioPlaybackResponse
//             {
//                 Data = new StopAudioPlaybackResponseData
//                 {
//                     Result = "success"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<StopAudioPlaybackResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<StopAudioPlaybackResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.StopAudioPlayback(callControlId, request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
//         }
//
//         [Fact]
//         public async Task EnqueueCall_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var callControlId = "call1";
//             var request = new EnqueueCallRequest
//             {
//                 QueueName = "queue1"
//             };
//
//             var expectedResponse = new EnqueueCallResponse
//             {
//                 Data = new EnqueueCallResponseData
//                 {
//                     Result = "success"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<EnqueueCallResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<EnqueueCallResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.EnqueueCall(callControlId, request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
//         }
//
//         [Fact]
//         public async Task RemoveCallFromQueue_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var callControlId = "call1";
//             var request = new RemoveCallFromQueueRequest
//             {
//                 ClientState = "state1"
//             };
//
//             var expectedResponse = new RemoveCallFromQueueResponse
//             {
//                 Data = new RemoveCallFromQueueResponseData
//                 {
//                     Result = "success"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<RemoveCallFromQueueResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<RemoveCallFromQueueResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.RemoveCallFromQueue(callControlId, request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
//         }
//
//         [Fact]
//         public async Task TransferCall_ShouldReturnExpectedResponse()
//         {
//             // Arrange
//             var callControlId = "call1";
//             var request = new TransferCallRequest
//             {
//                 To = "1234567890"
//             };
//
//             var expectedResponse = new TransferCallResponse
//             {
//                 Data = new TransferCallResponseData
//                 {
//                     Result = "success"
//                 }
//             };
//
//             _mockRestClient.Setup(client => client.ExecuteAsync<TransferCallResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//                 .ReturnsAsync(new RestResponse<TransferCallResponse> { Data = expectedResponse });
//
//             // Act
//             var response = await _telnyxClient.TransferCall(callControlId, request);
//
//             // Assert
//             Assert.NotNull(response);
//             Assert.Equal(expectedResponse.Data.Result, response.Data.Result);
//         }
//     }
// }
