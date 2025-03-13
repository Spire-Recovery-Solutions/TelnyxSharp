using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
   /// <summary>
    /// Enum representing the transcription engines available for use.
    /// </summary>
    [JsonConverter(typeof(Converters.TranscriptionEngineConverter))]
    public enum TranscriptionEngine
    {
        /// <summary>
        /// Represents the Google transcription engine.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("A")]
        Google,

        /// <summary>
        /// Represents the Telnyx transcription engine.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("B")]
        Telnyx
    }
}