using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the available voice types for text-to-speech (TTS) services.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VoiceType
    {
        /// <summary>
        /// Represents the Telnyx LibriTTS voice type.
        /// </summary>
        [JsonPropertyName("Telnyx.LibriTTS.0")]
        TelnyxLibriTTS,

        /// <summary>
        /// Represents the AWS Polly voice type.
        /// </summary>
        [JsonPropertyName("AWS.Polly")]
        AWSPolly,

        /// <summary>
        /// Represents the ElevenLabs voice type.
        /// </summary>
        [JsonPropertyName("ElevenLabs")]
        ElevenLabs
    }
}