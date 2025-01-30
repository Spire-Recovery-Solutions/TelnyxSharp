using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the different types of features available for a phone number.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FeatureType
    {
        /// <summary>
        /// Short Message Service (SMS) feature.
        /// </summary>
        [JsonPropertyName("sms")]
        Sms,

        /// <summary>
        /// Multimedia Messaging Service (MMS) feature.
        /// </summary>
        [JsonPropertyName("mms")]
        Mms,

        /// <summary>
        /// Voice call feature.
        /// </summary>
        [JsonPropertyName("voice")]
        Voice,

        /// <summary>
        /// Fax communication feature.
        /// </summary>
        [JsonPropertyName("fax")]
        Fax,

        /// <summary>
        /// Emergency services feature.
        /// </summary>
        [JsonPropertyName("emergency")]
        Emergency
    }
}