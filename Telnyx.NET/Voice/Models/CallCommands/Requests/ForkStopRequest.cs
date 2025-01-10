using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request model for stopping call forking.
    /// </summary>
    public class ForkStopRequest : ITelnyxRequest
    {
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

        /// <summary>
        /// Gets or sets the stream type to stop. This should match the stream type used in the fork_start command.
        /// Default is "raw".
        /// </summary>
        [JsonPropertyName("stream_type")]
        public StreamType? StreamType { get; set; } = Enums.StreamType.Raw;
    }
}
