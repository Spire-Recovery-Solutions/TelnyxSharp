using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the possible operation types.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<OperationType>))]
    public enum OperationType
    {
        /// <summary>
        /// Represents an unknown operation type.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents the "start" operation type.
        /// </summary>
        Start,

        /// <summary>
        /// Represents the "stop" operation type.
        /// </summary>
        Stop,

        /// <summary>
        /// Represents the "info" operation type.
        /// </summary>
        Info
    }
}