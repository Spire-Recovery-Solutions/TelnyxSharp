using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the types of recording channels available.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordChannels
    {
        /// <summary>
        /// Represents a single-channel recording.
        /// </summary>
        Single,

        /// <summary>
        /// Represents a dual-channel recording.
        /// </summary>
        Dual
    }
}