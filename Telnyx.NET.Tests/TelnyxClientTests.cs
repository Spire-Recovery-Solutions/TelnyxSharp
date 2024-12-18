using Moq;
using Polly;
using RestSharp;
using Telnyx.NET;
using Telnyx.NET.Interfaces;
using Telnyx.NET.Models;
using Xunit;

namespace Telnyx.NET.Tests
{
    public class TelnyxClientTests
    {
        private readonly Mock<RestClient> _mockRestClient;
        private readonly TelnyxClient _telnyxClient;

        public TelnyxClientTests()
        {
            _mockRestClient = new Mock<RestClient>();
            _telnyxClient = new TelnyxClient("fakeApiKey");
        }

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
                Data = new NumberLookupResponseData
                {
                    PhoneNumber = "1234567890",
                    CallerName = "John Doe"
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
    }
}
