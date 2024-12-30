using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the different types of message types.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageType
    {
        /// <summary>
        /// Represents an unknown message type.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents a long-code message type.
        /// </summary>
        [JsonPropertyName("long-code")]
        LongCode,

        /// <summary>
        /// Represents a toll-free message type.
        /// </summary>
        [JsonPropertyName("toll-free")]
        TollFree,

        /// <summary>
        /// Represents a short-code message type.
        /// </summary>
        [JsonPropertyName("short-code")]
        ShortCode,

        /// <summary>
        /// Represents a longcode message type.
        /// </summary>
        [JsonPropertyName("longcode")]
        Longcode,

        /// <summary>
        /// Represents a tollfree message type.
        /// </summary>
        [JsonPropertyName("tollfree")]
        Tollfree,

        /// <summary>
        /// Represents a shortcode message type.
        /// </summary>
        [JsonPropertyName("shortcode")]
        Shortcode,

        /// <summary>
        /// Represents an SMS message type.
        /// </summary>
        [JsonPropertyName("SMS")]
        Sms,

        /// <summary>
        /// Represents an MMS message type.
        /// </summary>
        [JsonPropertyName("MMS")]
        Mms
    }
}