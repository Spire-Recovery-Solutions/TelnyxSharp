using Telnyx.NET.Models;

namespace Telnyx.NET.Tests
{
    public class TelnyxClientTests
    {
        private readonly TelnyxClient _telnyxClient = new("KEY HERE");

        [Fact]
        public async Task NumberLookup_ShouldReturnExpectedResponse()
        {
            var listNumbers = await _telnyxClient.ListNumbers(new ListNumbersRequest
            {
                // PageNumber = null,
                // PageSize = null,
                // Tags = null,
                // PhoneNumber = null,
                // Status = null,
                // ConnectionId = null,
                // VoiceConnectionNameContains = null,
                // VoiceConnectionNameStartsWith = null,
                // VoiceConnectionNameEndsWith = null,
                // VoiceConnectionNameEquals = null,
                // UsagePaymentMethod = null,
                // BillingGroupId = null,
                // EmergencyAddressId = null,
                // CustomerReference = null,
                // Sort = null
            });
            var foo = "bar";
            Assert.NotNull(listNumbers.Data);

        }
    }
}