using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the transcription engines available for use.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<TranscriptionEngine>))]
    public enum TranscriptionEngine
    {
        /// <summary>
        /// Represents the Google transcription engine.
        /// </summary>
        [JsonStringEnumMemberName("A")]
        Google,

        /// <summary>
        /// Represents the Telnyx transcription engine.
        /// </summary>
        [JsonStringEnumMemberName("B")]
        Telnyx
    }
}