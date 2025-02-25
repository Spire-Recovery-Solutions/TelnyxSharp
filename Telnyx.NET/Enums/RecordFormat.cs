using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the supported formats for recording files.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordFormat
    {
        /// <summary>
        /// Represents a WAV audio format.
        /// </summary>
        Wav,

        /// <summary>
        /// Represents an MP3 audio format.
        /// </summary>
        Mp3
    }
}