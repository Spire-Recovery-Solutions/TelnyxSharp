using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enumeration for phone number status.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhoneNumberStatusType
    {
        [JsonPropertyName("purchase_pending")]
        PurchasePending,

        [JsonPropertyName("purchase_failed")]
        PurchaseFailed,

        [JsonPropertyName("port_pending")]
        PortPending,

        [JsonPropertyName("active")]
        Active,

        [JsonPropertyName("deleted")]
        Deleted,

        [JsonPropertyName("port_failed")]
        PortFailed,

        [JsonPropertyName("emergency_only")]
        EmergencyOnly,

        [JsonPropertyName("ported_out")]
        PortedOut,

        [JsonPropertyName("port_out_pending")]
        PortOutPending
    }
}
