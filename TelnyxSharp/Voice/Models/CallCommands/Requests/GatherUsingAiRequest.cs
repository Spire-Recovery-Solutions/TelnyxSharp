using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to gather user input using AI in a Telnyx voice call.
    /// </summary>
    public class GatherUsingAiRequest : ITelnyxRequest
    {
        /// <summary>
        /// The parameters for the AI-based gathering process. This is a required property.
        /// </summary>
        [JsonPropertyName("parameters")]
        public required object Parameters { get; set; }

        /// <summary>
        /// Transcription configuration for converting speech to text.
        /// </summary>
        [JsonPropertyName("transcription")]
        public Transcription? Transcription { get; set; }

        /// <summary>
        /// The voice type to use for the assistant. Defaults to TelnyxLibriTTS.
        /// </summary>
        [JsonPropertyName("voice")]
        public VoiceType? Voice { get; set; } = VoiceType.TelnyxLibriTTS;

        /// <summary>
        /// Settings for adjusting the voice output during the call.
        /// </summary>
        [JsonPropertyName("voice_settings")]
        public VoiceSettings? VoiceSettings { get; set; }

        /// <summary>
        /// An optional greeting message to be played at the start of the interaction.
        /// </summary>
        [JsonPropertyName("greeting")]
        public string? Greeting { get; set; }

        /// <summary>
        /// Flag to indicate whether to send partial transcription results during the call.
        /// </summary>
        [JsonPropertyName("send_partial_results")]
        public bool? SendPartialResults { get; set; }

        /// <summary>
        /// Configuration for the AI assistant, including model and instructions.
        /// </summary>
        [JsonPropertyName("assistant")]
        public AssistantConfig? Assistant { get; set; }

        /// <summary>
        /// A list of previous messages in the conversation for context.
        /// </summary>
        [JsonPropertyName("message_history")]
        public List<MessageHistory>? MessageHistory { get; set; }

        /// <summary>
        /// An optional field for passing along client-specific state data.
        /// This can be used for tracking the state of the request on the client side.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// An optional unique identifier for the command to track it.
        /// This helps correlate the request to other related actions or commands.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Settings to configure interruption behavior during the AI call.
        /// </summary>
        [JsonPropertyName("interruption_settings")]
        public InterruptionSettings? InterruptionSettings { get; set; }
    }

    /// <summary>
    /// Configuration for transcription services, such as models used for speech-to-text conversion.
    /// </summary>
    public class Transcription
    {
        /// <summary>
        /// The model used for transcription. Defaults to "distil-whisper/distil-large-v2".
        /// </summary>
        [JsonPropertyName("model")]
        public string TranscriptionModel { get; set; } = "distil-whisper/distil-large-v2";
    }

    /// <summary>
    /// Base class for voice settings that can be customized for different voice providers.
    /// </summary>
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(ElevenLabsVoiceSettings), "elevenlabs")]
    [JsonDerivedType(typeof(TelnyxVoiceSettings), "telnyx")]
    [JsonDerivedType(typeof(AWSVoiceSettings), "aws")]
    public abstract class VoiceSettings { }

    /// <summary>
    /// Voice settings specific to Telnyx voice.
    /// </summary>
    public class TelnyxVoiceSettings : VoiceSettings
    {
        /// <summary>
        /// The speed of the voice. The value ranges from 0.1 to 2.0, with a default of 1.0.
        /// </summary>
        [JsonPropertyName("voice_speed")]
        [Range(0.1, 2.0)]
        public float VoiceSpeed { get; set; } = 1.0f;
    }

    /// <summary>
    /// Voice settings specific to Eleven Labs voice provider.
    /// </summary>
    public class ElevenLabsVoiceSettings : VoiceSettings
    {
        /// <summary>
        /// Reference to the API key used for ElevenLabs voice service.
        /// </summary>
        [JsonPropertyName("api_key_ref")]
        public string ApiKeyRef { get; set; }
    }

    /// <summary>
    /// Voice settings specific to AWS Polly voice service.
    /// </summary>
    public class AWSVoiceSettings : VoiceSettings { }

    /// <summary>
    /// Configuration for the AI assistant, including model and instructions for interaction.
    /// </summary>
    public class AssistantConfig
    {
        /// <summary>
        /// The model used for the AI assistant. Defaults to "meta-llama/Meta-Llama-3.1-70B-Instruct".
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; } = "meta-llama/Meta-Llama-3.1-70B-Instruct";

        /// <summary>
        /// Optional instructions to guide the AI assistant's behavior during the interaction.
        /// </summary>
        [JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// An optional reference to the OpenAI API key for configuring the AI model.
        /// </summary>
        [JsonPropertyName("openai_api_key_ref")]
        public string? OpenAIApiKeyRef { get; set; }
    }

    /// <summary>
    /// Represents a single message in the AI assistant's message history.
    /// </summary>
    public class MessageHistory
    {
        /// <summary>
        /// The content of the message.
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The role of the entity who sent the message (e.g., "user" or "assistant").
        /// </summary>
        [JsonPropertyName("role")]
        public MessageRole? Role { get; set; }
    }

    /// <summary>
    /// Configuration for interruption behavior in the AI assistant call.
    /// </summary>
    public class InterruptionSettings
    {
        /// <summary>
        /// A flag to enable or disable interruptions during the AI assistant's response.
        /// Defaults to true, allowing interruptions.
        /// </summary>
        [JsonPropertyName("enable")]
        public bool Enable { get; set; } = true;
    }
}