using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the type of payload.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PayloadType
    {
        /// <summary>
        /// Represents a text-based payload.
        /// </summary>
        [JsonPropertyName("text")]
        Text,

        /// <summary>
        /// Represents a Speech Synthesis Markup Language (SSML) payload.
        /// </summary>
        [JsonPropertyName("ssml")]
        Ssml
    }
}