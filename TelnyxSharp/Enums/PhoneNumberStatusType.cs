using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enumeration for phone number status.
    /// </summary>
    [JsonConverter(typeof(Converters.PhoneNumberStatusTypeConverter))]
    public enum PhoneNumberStatusType
    {
        //NET9UNCOMMENT [JsonStringEnumMemberName("purchase_pending")]
        PurchasePending,

        //NET9UNCOMMENT [JsonStringEnumMemberName("purchase_failed")]
        PurchaseFailed,

        //NET9UNCOMMENT [JsonStringEnumMemberName("port_pending")]
        PortPending,

        //NET9UNCOMMENT [JsonStringEnumMemberName("active")]
        Active,

        //NET9UNCOMMENT [JsonStringEnumMemberName("deleted")]
        Deleted,

        //NET9UNCOMMENT [JsonStringEnumMemberName("port_failed")]
        PortFailed,

        //NET9UNCOMMENT [JsonStringEnumMemberName("emergency_only")]
        EmergencyOnly,

        //NET9UNCOMMENT [JsonStringEnumMemberName("ported_out")]
        PortedOut,

        //NET9UNCOMMENT [JsonStringEnumMemberName("port_out_pending")]
        PortOutPending
    }
}
