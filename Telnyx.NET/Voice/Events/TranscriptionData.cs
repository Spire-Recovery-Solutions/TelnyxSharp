using System.Text.Json.Serialization;

namespace Telnyx.NET.Voice.Events
{
    /// <summary>
    /// Represents transcription data for a speech-to-text conversion.
    /// </summary>
    public class TranscriptionData
    {
        /// <summary>
        /// Gets or sets the confidence level of the transcription result.
        /// </summary>
        [JsonPropertyName("confidence")]
        public double Confidence { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the transcription is final.
        /// </summary>
        [JsonPropertyName("is_final")]
        public bool IsFinal { get; set; }

        /// <summary>
        /// Gets or sets the transcribed text.
        /// </summary>
        [JsonPropertyName("transcript")]
        public string Transcript { get; set; }
    }
}