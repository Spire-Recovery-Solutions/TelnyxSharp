using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to convert text to speech and play it back on a call.
    /// This class contains the parameters required to configure the speech synthesis.
    /// The request requires a payload, voice, and may include optional parameters like payload_type, service_level, stop, language, client_state, and command_id.
    /// </summary>
    public class SpeakTextRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the text or SSML to be converted into speech.
        /// This field is required and has a 3,000 character limit.
        /// </summary>
        [JsonPropertyName("payload")]
        public required string Payload { get; set; }

        /// <summary>
        /// Gets or sets the type of the provided payload.
        /// Possible values are 'text' or 'ssml'. Defaults to 'text'.
        /// </summary>
        [JsonPropertyName("payload_type")]
        public string? PayloadType { get; set; } // Optional, defaults to "text".

        /// <summary>
        /// Gets or sets the service level for speech quality and language options.
        /// Possible values are 'basic' or 'premium'. Defaults to 'premium'.
        /// When using 'basic', only the en-US language and payload type 'text' are allowed.
        /// </summary>
        [JsonPropertyName("service_level")]
        public string? ServiceLevel { get; set; } // Optional, defaults to "premium".

        /// <summary>
        /// Gets or sets the stop parameter to control audio playback.
        /// Specify 'current' to stop the current audio and play the next in the queue,
        /// or 'all' to stop the current audio and clear all audio files from the queue.
        /// </summary>
        [JsonPropertyName("stop")]
        public string? Stop { get; set; } // Optional, stops current audio or clears the queue.

        /// <summary>
        /// Gets or sets the voice to be used for speech.
        /// This can specify the gender (male or female) or the specific Amazon Polly voice (e.g., Polly.Brian).
        /// This field is required.
        /// </summary>
        [JsonPropertyName("voice")]
        public required string Voice { get; set; }

        /// <summary>
        /// Gets or sets the language for the speech.
        /// This parameter is ignored when a Polly.* voice is specified.
        /// Possible values include various language codes (e.g., en-US, fr-FR).
        /// </summary>
        [JsonPropertyName("language")]
        public string? Language { get; set; } // Optional, specifies the language to be spoken.

        /// <summary>
        /// Gets or sets the client state for subsequent webhooks.
        /// This must be a valid Base-64 encoded string.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; } // Optional, Base-64 encoded state for subsequent webhooks.

        /// <summary>
        /// Gets or sets the command ID to avoid duplicate commands.
        /// Telnyx will ignore any command with the same command_id for the same call_control_id.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; } // Optional, to avoid duplicate commands.
    }
}