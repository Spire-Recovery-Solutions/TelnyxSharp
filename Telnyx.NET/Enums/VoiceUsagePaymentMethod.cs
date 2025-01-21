using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enumeration for voice usage payment methods.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VoiceUsagePaymentMethod
    {
        [JsonPropertyName("pay-per-minute")]
        PayPerMinute,

        [JsonPropertyName("channel")]
        Channel
    }
}
