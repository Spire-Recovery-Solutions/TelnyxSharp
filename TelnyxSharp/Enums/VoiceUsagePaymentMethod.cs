using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enumeration for voice usage payment methods.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VoiceUsagePaymentMethod
    {
        [JsonStringEnumMemberName("pay-per-minute")]
        PayPerMinute,

        [JsonStringEnumMemberName("channel")]
        Channel
    }
}
