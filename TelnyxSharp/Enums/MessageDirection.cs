using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the direction of a message.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<MessageDirection>))]
    public enum MessageDirection
    {
        /// <summary>
        /// The direction of the message is unknown or unspecified.
        /// </summary>
        Unknown,

        /// <summary>
        /// The message is sent from the sender to the recipient.
        /// </summary>
        Outbound,

        /// <summary>
        /// The message is received by the recipient.
        /// </summary>
        Inbound
    }
}