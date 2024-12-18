using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents a request to stop audio playback on a call.
    /// This class contains the parameters required to control the stopping of audio playback.
    /// </summary>
    public class StopAudioPlaybackRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether to stop the audio being played in the overlay queue.
        /// When enabled, it stops the audio currently being played in overlay mode.
        /// </summary>
        [JsonPropertyName("overlay")]
        public bool? Overlay { get; set; }

        /// <summary>
        /// Gets or sets the stop parameter to control which audio playback to stop.
        /// Use 'current' to stop the current audio being played, or 'all' to stop the current audio and clear all audio files from the queue.
        /// The default value is 'all'.
        /// </summary>
        [JsonPropertyName("stop")]
        public string? Stop { get; set; } // Default value is "all".

        /// <summary>
        /// Gets or sets the client state to be included in every subsequent webhook.
        /// The client state must be a valid Base-64 encoded string.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; } // Base-64 encoded string for subsequent webhooks.

        /// <summary>
        /// Gets or sets the command ID to prevent duplicate commands.
        /// Telnyx will ignore any command with the same command_id for the same call_control_id.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; } // To avoid duplicate commands.
    }
}