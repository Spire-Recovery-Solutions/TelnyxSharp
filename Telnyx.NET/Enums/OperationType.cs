using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the possible operation types.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationType
    {
        /// <summary>
        /// Represents an unknown operation type.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents the "start" operation type.
        /// </summary>
        [JsonPropertyName("start")]
        Start,

        /// <summary>
        /// Represents the "stop" operation type.
        /// </summary>
        [JsonPropertyName("stop")]
        Stop,

        /// <summary>
        /// Represents the "info" operation type.
        /// </summary>
        [JsonPropertyName("info")]
        Info
    }
}