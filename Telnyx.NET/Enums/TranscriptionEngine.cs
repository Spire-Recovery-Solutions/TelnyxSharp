using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the transcription engines available for use.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TranscriptionEngine
    {
        /// <summary>
        /// Represents the Google transcription engine.
        /// </summary>
        [JsonPropertyName("A")]
        Google,

        /// <summary>
        /// Represents the Telnyx transcription engine.
        /// </summary>
        [JsonPropertyName("B")]
        Telnyx
    }
}