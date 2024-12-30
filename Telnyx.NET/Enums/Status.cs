using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status
    {
        Unknown,

        [JsonPropertyName("deleted")]
        Deleted, // Corresponds to "deleted"

        [JsonPropertyName("failed")]
        Failed, // Corresponds to "failed"

        [JsonPropertyName("pending")]
        Pending, // Corresponds to "pending"

        [JsonPropertyName("successful")]
        Successful, // Corresponds to "successful"

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
