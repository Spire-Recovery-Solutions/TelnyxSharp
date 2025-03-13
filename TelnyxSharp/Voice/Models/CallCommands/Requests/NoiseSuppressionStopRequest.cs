using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to stop noise suppression on a call.
    /// </summary>
    public class NoiseSuppressionStopRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the client state associated with the noise suppression stop request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for the noise suppression stop request.
        /// This ID can be used for tracking and managing multiple requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}