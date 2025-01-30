using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the available features for a phone number.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhoneNumberFeature
    {
        /// <summary>
        /// Short Message Service (SMS) support.
        /// </summary>
        [JsonPropertyName("sms")]
        Sms,

        /// <summary>
        /// Multimedia Messaging Service (MMS) support.
        /// </summary>
        [JsonPropertyName("mms")]
        Mms,

        /// <summary>
        /// Voice calling support.
        /// </summary>
        [JsonPropertyName("voice")]
        Voice,

        /// <summary>
        /// Fax communication support.
        /// </summary>
        [JsonPropertyName("fax")]
        Fax,

        /// <summary>
        /// Emergency calling support.
        /// </summary>
        [JsonPropertyName("emergency")]
        Emergency,

        /// <summary>
        /// High-definition voice calling support.
        /// </summary>
        [JsonPropertyName("hd_voice")]
        HdVoice,

        /// <summary>
        /// International SMS messaging support.
        /// </summary>
        [JsonPropertyName("international_sms")]
        InternationalSms,

        /// <summary>
        /// Local calling support.
        /// </summary>
        [JsonPropertyName("local_calling")]
        LocalCalling
    }
}
