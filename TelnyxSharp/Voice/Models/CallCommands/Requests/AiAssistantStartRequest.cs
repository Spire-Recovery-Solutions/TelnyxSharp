using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Request model for starting an AI assistant in a Telnyx call command.
    /// </summary>
    public class AiAssistantStartRequest : ITelnyxRequest
    {
        /// <summary>
        /// Configuration for the AI assistant.
        /// </summary>
        [JsonPropertyName("assistant")]
        public required AssistantConfig Assistant { get; set; }

        /// <summary>
        /// The voice to be used for the AI assistant. Default is "Telnyx.LibriTTS.0".
        /// </summary>
        [JsonPropertyName("voice")]
        public VoiceType Voice { get; set; } = VoiceType.TelnyxLibriTTS;

        /// <summary>
        /// Optional settings for the voice of the AI assistant.
        /// </summary>
        [JsonPropertyName("voice_settings")]
        public VoiceSettings? VoiceSettings { get; set; }

        /// <summary>
        /// Optional greeting message to be spoken by the AI assistant at the start.
        /// </summary>
        [JsonPropertyName("greeting")]
        public string? Greeting { get; set; }

        /// <summary>
        /// Optional settings for how the AI assistant handles interruptions during speech.
        /// </summary>
        [JsonPropertyName("interruption_settings")]
        public InterruptionSettings? InterruptionSettings { get; set; }

        /// <summary>
        /// Optional configuration for transcription of the AI assistant's speech.
        /// </summary>
        [JsonPropertyName("transcription")]
        public TranscriptionConfig? Transcription { get; set; }

        /// <summary>
        /// Optional client state information that can be passed along with the request.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Optional unique identifier for the command to track it.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}