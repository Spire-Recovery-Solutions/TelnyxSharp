using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the supported formats for recording files.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<RecordFormat>))]
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