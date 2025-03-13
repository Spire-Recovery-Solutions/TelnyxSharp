using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the available voice types for text-to-speech (TTS) services.
    /// </summary>
    [JsonConverter(typeof(Converters.VoiceTypeConverter))]
    public enum VoiceType
    {
        /// <summary>
        /// Represents the Telnyx LibriTTS voice type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Telnyx.LibriTTS.0")]
        TelnyxLibriTTS,

        /// <summary>
        /// Represents the AWS Polly voice type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("AWS.Polly")]
        AWSPolly,

        /// <summary>
        /// Represents the ElevenLabs voice type.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ElevenLabs")]
        ElevenLabs
    }
}