using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enumeration for phone number status.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhoneNumberStatusType
    {
        [JsonStringEnumMemberName("purchase_pending")]
        PurchasePending,

        [JsonStringEnumMemberName("purchase_failed")]
        PurchaseFailed,

        [JsonStringEnumMemberName("port_pending")]
        PortPending,

        [JsonStringEnumMemberName("active")]
        Active,

        [JsonStringEnumMemberName("deleted")]
        Deleted,

        [JsonStringEnumMemberName("port_failed")]
        PortFailed,

        [JsonStringEnumMemberName("emergency_only")]
        EmergencyOnly,

        [JsonStringEnumMemberName("ported_out")]
        PortedOut,

        [JsonStringEnumMemberName("port_out_pending")]
        PortOutPending
    }
}
