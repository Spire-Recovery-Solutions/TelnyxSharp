using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to start noise suppression on a call.
    /// </summary>
    public class NoiseSuppressionStartRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the client state associated with the noise suppression request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for the noise suppression start request.
        /// This ID can be used for tracking and managing multiple requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets the direction of the call for noise suppression. 
        /// Defaults to 'Inbound'. 
        /// Can be set to 'Outbound' for calls initiated from the client.
        /// </summary>
        [JsonPropertyName("direction")]
        public RecordTrack Direction { get; set; } = RecordTrack.Inbound;
    }
}