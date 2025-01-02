using Moq;
using RestSharp;
using System.Text.Json;
using Telnyx.NET;
using Telnyx.NET.Models;
using Xunit;

namespace Telnyx.NET.Tests
{
    public class TelnyxClientTest
    {
        private readonly Mock<RestClient> _mockRestClient;
        private readonly TelnyxClient _telnyxClient;

        public TelnyxClientTest()
        {
            _mockRestClient = new Mock<RestClient>();
            _telnyxClient = new TelnyxClient("fakeApiKey")
            {
                Client = _mockRestClient.Object
            };
        }

        [Fact]
        public async Task NumberLookup_ShouldReturnResponse()
        {
            var request = new NumberLookupRequest
            {
                PhoneNumber = "1234567890",
                NumberLookupTypes = new List<NumberLookupType> { NumberLookupType.CallerName }
            };

            var response = new NumberLookupResponse
            {
                PhoneNumber = "1234567890",
                CallerName = "John Doe"
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<NumberLookupResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<NumberLookupResponse> { Data = response });

            var result = await _telnyxClient.NumberLookup(request);

            Assert.NotNull(result);
            Assert.Equal("1234567890", result.PhoneNumber);
            Assert.Equal("John Doe", result.CallerName);
        }

        [Fact]
        public async Task AvailablePhoneNumbers_ShouldReturnResponse()
        {
            var request = new AvailablePhoneNumbersRequest
            {
                CountryCode = "US",
                Limit = 10
            };

            var response = new AvailablePhoneNumbersResponse
            {
                PhoneNumbers = new List<string> { "1234567890", "0987654321" }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<AvailablePhoneNumbersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<AvailablePhoneNumbersResponse> { Data = response });

            var result = await _telnyxClient.AvailablePhoneNumbers(request);

            Assert.NotNull(result);
            Assert.Equal(2, result.PhoneNumbers.Count);
            Assert.Contains("1234567890", result.PhoneNumbers);
            Assert.Contains("0987654321", result.PhoneNumbers);
        }

        [Fact]
        public async Task ListNumberOrders_ShouldReturnResponse()
        {
            var request = new ListNumberOrdersRequest
            {
                Status = "completed"
            };

            var response = new ListNumberOrdersResponse
            {
                NumberOrders = new List<NumberOrder> { new NumberOrder { Id = "order1" }, new NumberOrder { Id = "order2" } }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListNumberOrdersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListNumberOrdersResponse> { Data = response });

            var result = await _telnyxClient.ListNumberOrders(request);

            Assert.NotNull(result);
            Assert.Equal(2, result.NumberOrders.Count);
            Assert.Contains(result.NumberOrders, o => o.Id == "order1");
            Assert.Contains(result.NumberOrders, o => o.Id == "order2");
        }

        [Fact]
        public async Task RetrieveMessagingProfile_ShouldReturnResponse()
        {
            var response = new RetrieveMessagingProfileResponse
            {
                Id = "profile1",
                Name = "Test Profile"
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<RetrieveMessagingProfileResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<RetrieveMessagingProfileResponse> { Data = response });

            var result = await _telnyxClient.RetrieveMessagingProfile("profile1");

            Assert.NotNull(result);
            Assert.Equal("profile1", result.Id);
            Assert.Equal("Test Profile", result.Name);
        }

        [Fact]
        public async Task CreateNumberOrder_ShouldReturnResponse()
        {
            var request = new CreateNumberOrderRequest
            {
                PhoneNumbers = new List<string> { "1234567890" }
            };

            var response = new CreateNumberOrderResponse
            {
                Id = "order1"
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<CreateNumberOrderResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<CreateNumberOrderResponse> { Data = response });

            var result = await _telnyxClient.CreateNumberOrder(request);

            Assert.NotNull(result);
            Assert.Equal("order1", result.Id);
        }

        [Fact]
        public async Task UpdateNumberVoiceSettings_ShouldReturnResponse()
        {
            var request = new UpdateNumberVoiceSettingsRequest
            {
                ConnectionId = "conn1"
            };

            var response = new UpdateNumberVoiceSettingsResponse
            {
                Id = "phone1"
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<UpdateNumberVoiceSettingsResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<UpdateNumberVoiceSettingsResponse> { Data = response });

            var result = await _telnyxClient.UpdateNumberVoiceSettings("phone1", request);

            Assert.NotNull(result);
            Assert.Equal("phone1", result.Id);
        }

        [Fact]
        public async Task ListPortingOrders_ShouldReturnResponse()
        {
            var request = new ListPortingOrdersRequest
            {
                Status = "completed"
            };

            var response = new ListPortingOrdersResponse
            {
                PortingOrders = new List<PortingOrder> { new PortingOrder { Id = "order1" }, new PortingOrder { Id = "order2" } }
            };

            _mockRestClient.Setup(client => client.ExecuteAsync<ListPortingOrdersResponse>(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new RestResponse<ListPortingOrdersResponse> { Data = response });

            var result = await _telnyxClient.ListPortingOrders(request);

            Assert.NotNull(result);
            Assert.Equal(2, result.PortingOrders.Count);
            Assert.Contains(result.PortingOrders, o => o.Id == "order1");
            Assert.Contains(result.PortingOrders, o => o.Id == "order2");
        }

        // Add unit tests for all remaining methods in TelnyxClient.cs
        // Use Moq to mock dependencies and simulate API responses
        // Ensure all methods in TelnyxClient.cs are covered by unit tests
        // Verify that all tests pass successfully
    }
}
