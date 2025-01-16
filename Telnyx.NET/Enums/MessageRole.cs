using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the role of a message sender.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageRole
    {
        /// <summary>
        /// Represents a message from the assistant.
        /// </summary>
        [JsonPropertyName("assistant")]
        Assistant,

        /// <summary>
        /// Represents a message from the user.
        /// </summary>
        [JsonPropertyName("user")]
        User
    }
}