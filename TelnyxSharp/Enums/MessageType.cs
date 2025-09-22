using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the different types of message types.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<MessageType>))]
    public enum MessageType
    {
        /// <summary>
        /// Represents an unknown message type.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents a long-code message type.
        /// </summary>
        [JsonStringEnumMemberName("long-code")]
        LongCode,

        /// <summary>
        /// Represents a toll-free message type.
        /// </summary>
        [JsonStringEnumMemberName("toll-free")]
        TollFree,

        /// <summary>
        /// Represents a short-code message type.
        /// </summary>
        [JsonStringEnumMemberName("short-code")]
        ShortCode,

        /// <summary>
        /// Represents a longcode message type.
        /// </summary>
        [JsonStringEnumMemberName("longcode")]
        Longcode,

        /// <summary>
        /// Represents a tollfree message type.
        /// </summary>
        [JsonStringEnumMemberName("tollfree")]
        Tollfree,

        /// <summary>
        /// Represents a shortcode message type.
        /// </summary>
        [JsonStringEnumMemberName("shortcode")]
        Shortcode,

        /// <summary>
        /// Represents an SMS message type.
        /// </summary>
        [JsonStringEnumMemberName("SMS")]
        Sms,

        /// <summary>
        /// Represents an MMS message type.
        /// </summary>
        [JsonStringEnumMemberName("MMS")]
        Mms
    }
}