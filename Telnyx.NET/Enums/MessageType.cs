using System.Text.Json.Serialization;
using Telnyx.NET.Converters;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the different types of message types.
    /// </summary>
    [JsonConverter(typeof(MessageTypeConverter))]
    public enum MessageType
    {
        /// <summary>
        /// Represents an unknown message type.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents a long-code message type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("long-code")]
        LongCode,

        /// <summary>
        /// Represents a toll-free message type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("toll-free")]
        TollFree,

        /// <summary>
        /// Represents a short-code message type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("short-code")]
        ShortCode,

        /// <summary>
        /// Represents a longcode message type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("longcode")]
        Longcode,

        /// <summary>
        /// Represents a tollfree message type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("tollfree")]
        Tollfree,

        /// <summary>
        /// Represents a shortcode message type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("shortcode")]
        Shortcode,

        /// <summary>
        /// Represents an SMS message type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("SMS")]
        Sms,

        /// <summary>
        /// Represents an MMS message type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("MMS")]
        Mms
    }
}