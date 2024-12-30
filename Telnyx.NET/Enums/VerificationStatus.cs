using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VerificationStatus
    {
        Unknown,

        [JsonPropertyName("Verified")]
        Verified,

        [JsonPropertyName("Rejected")]
        Rejected,

        [JsonPropertyName("Waiting For Vendor")]
        WaitingForVendor,

        [JsonPropertyName("Waiting For Customer")]
        WaitingForCustomer,

        [JsonPropertyName("In Progress")]
        InProgress
    }
}
