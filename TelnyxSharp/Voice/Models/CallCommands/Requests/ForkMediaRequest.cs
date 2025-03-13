using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request model for initiating call forking.
    /// </summary>
    public class ForkMediaRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the network target for incoming RTP media packets (rx).
        /// </summary>
        [JsonPropertyName("rx")]
        public string? Rx { get; set; }

        /// <summary>
        /// Gets or sets the network target for outgoing RTP media packets (tx).
        /// </summary>
        [JsonPropertyName("tx")]
        public string? Tx { get; set; }

        /// <summary>
        /// Gets or sets the media type to stream, such as "decrypted".
        /// Default is "decrypted".
        /// </summary>
        [JsonPropertyName("stream_type")]
        public string? StreamType { get; set; } = "decrypted";

        /// <summary>
        /// Gets or sets the client state to include in subsequent webhooks.
        /// Must be a valid Base-64 encoded string.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the command ID to prevent duplicate commands.
        /// Telnyx ignores commands with the same command_id for the same call_control_id.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}
