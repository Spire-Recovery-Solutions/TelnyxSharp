using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the type of payload.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<PayloadType>))]
    public enum PayloadType
    {
        /// <summary>
        /// Represents a text-based payload.
        /// </summary>
        Text,

        /// <summary>
        /// Represents a Speech Synthesis Markup Language (SSML) payload.
        /// </summary>
        Ssml
    }
}