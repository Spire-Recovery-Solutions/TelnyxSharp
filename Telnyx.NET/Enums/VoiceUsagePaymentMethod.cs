using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enumeration for voice usage payment methods.
    /// </summary>
    [JsonConverter(typeof(Converters.VoiceUsagePaymentMethodConverter))]
    public enum VoiceUsagePaymentMethod
    {
        //NET9UNCOMMENT [JsonStringEnumMemberName("pay-per-minute")]
        PayPerMinute,

        //NET9UNCOMMENT [JsonStringEnumMemberName("channel")]
        Channel
    }
}
