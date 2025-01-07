// using System.Net;
// using System.Text.Json;
// using Moq;
// using RestSharp;
// using Telnyx.NET.Models;
//
// namespace Telnyx.NET.Tests;
// public class TestTelnyxClient : TelnyxClient
// {
//     private readonly Mock<IRestClient> _mockRestClient;
//
//     public TestTelnyxClient() : base("TEST_KEY_123456789")
//     {
//         _mockRestClient = new Mock<IRestClient>();
//
//         // Replace the RestClient with our mock
//         var field = typeof(TelnyxClient).GetField("_client", 
//             System.Reflection.BindingFlags.NonPublic | 
//             System.Reflection.BindingFlags.Instance);
//             
//         field?.SetValue(this, _mockRestClient.Object);
//     }
//
//     public Mock<IRestClient> MockRestClient => _mockRestClient;
// }
//
// public class TelnyxClientTests : IDisposable
// {
//     private readonly TestTelnyxClient _sut = new();
//
//     [Fact]
//     public async Task GetSharingStatus_Success_ReturnsParsedResponse()
//     {
//         // Arrange
//         const string campaignId = "test_campaign";
//         var expectedResponse = new GetSharingStatusResponse
//         {
//             DownstreamCnpId = "CNP123",
//             SharedDate = "2025-01-02T10:00:00Z",
//             SharingStatus = "SHARED",
//             StatusDate = "2025-01-02T10:00:00Z",
//             UpstreamCnpId = "CNP456"
//         };
//
//         var response = new RestResponse
//         {
//             StatusCode = HttpStatusCode.OK,
//             IsSuccessStatusCode = true,
//             Content = JsonSerializer.Serialize(expectedResponse, TelnyxJsonSerializerContext.Default.Options)
//         };
//
//         _sut.MockRestClient
//             .Setup(x => x.ExecuteAsync(
//                 It.Is<RestRequest>(r =>
//                     r.Resource == $"10dlc/partnerCampaign/{campaignId}/sharing"),
//                 It.IsAny<CancellationToken>()))
//             .ReturnsAsync(response);
//
//         // Act
//         var result = await _sut.GetSharingStatusAsync(campaignId);
//
//         // Assert
//         Assert.NotNull(result);
//         Assert.Equal("CNP123", result.DownstreamCnpId);
//         Assert.Equal("SHARED", result.SharingStatus);
//         Assert.Equal("CNP456", result.UpstreamCnpId);
//     }
//
//     [Fact]
//     public async Task GetSharingStatus_ValidationError_ReturnsErrorDetails()
//     {
//         // Arrange
//         var campaignId = "invalid_campaign";
//         var expectedResponse = new GetSharingStatusResponse
//         {
//             Detail = new List<ValidationErrorDetail>
//             {
//                 new()
//                 {
//                     Location = new List<string> { "path", "campaignId" },
//                     Message = "Campaign ID not found",
//                     Type = "value_error.not_found"
//                 }
//             }
//         };
//
//         var response = new RestResponse
//         {
//             StatusCode = HttpStatusCode.BadRequest,
//             IsSuccessStatusCode = false,
//             Content = JsonSerializer.Serialize(expectedResponse)
//         };
//
//         _sut.MockRestClient
//             .Setup(x => x.ExecuteAsync(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//             .ReturnsAsync(response);
//
//         // Act
//         var result = await _sut.GetSharingStatusAsync(campaignId);
//
//         // Assert
//         Assert.NotNull(result);
//         Assert.NotNull(result.Detail);
//         Assert.Single(result.Detail);
//         var error = result.Detail[0];
//         Assert.Equal(2, error.Location.Count);
//         Assert.Equal("path", error.Location[0]);
//         Assert.Equal("campaignId", error.Location[1]);
//         Assert.Equal("Campaign ID not found", error.Message);
//         Assert.Equal("value_error.not_found", error.Type);
//     }
//
//     [Fact]
//     public async Task GetSharingStatus_RateLimitExceeded_Retries()
//     {
//         // Arrange
//         var campaignId = "test_campaign";
//         var rateLimitResponse = new RestResponse
//         {
//             StatusCode = HttpStatusCode.TooManyRequests,
//             IsSuccessStatusCode = false,
//             Headers = new List<HeaderParameter>
//             {
//                 new("Retry-After", "1")
//             }
//         };
//
//         var successResponse = new RestResponse
//         {
//             StatusCode = HttpStatusCode.OK,
//             IsSuccessStatusCode = true,
//             Content = JsonSerializer.Serialize(new GetSharingStatusResponse
//             {
//                 SharingStatus = "SHARED"
//             })
//         };
//
//         var requestCount = 0;
//         _sut.MockRestClient
//             .Setup(x => x.ExecuteAsync(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//             .ReturnsAsync(() => requestCount++ == 0 ? rateLimitResponse : successResponse);
//
//         // Act
//         var result = await _sut.GetSharingStatusAsync(campaignId);
//
//         // Assert
//         Assert.NotNull(result);
//         Assert.Equal("SHARED", result.SharingStatus);
//         _sut.MockRestClient.Verify(x =>
//                 x.ExecuteAsync(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()),
//             Times.Exactly(2));
//     }
//
//     [Fact]
//     public async Task GetSharingStatus_ServerError_ReturnsNull()
//     {
//         // Arrange
//         var campaignId = "test_campaign";
//         var response = new RestResponse
//         {
//             StatusCode = HttpStatusCode.InternalServerError,
//             IsSuccessStatusCode = false,
//             ErrorException = new HttpRequestException("Internal Server Error")
//         };
//
//         _sut.MockRestClient
//             .Setup(x => x.ExecuteAsync(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
//             .ReturnsAsync(response);
//
//         // Act
//         var result = await _sut.GetSharingStatusAsync(campaignId);
//
//         // Assert
//         Assert.Null(result);
//     }
//
//     public void Dispose()
//     {
//         _sut?.Dispose();
//     }
// }