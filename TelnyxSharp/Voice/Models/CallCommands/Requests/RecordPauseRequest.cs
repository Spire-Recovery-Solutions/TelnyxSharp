using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to pause the recording of a call.
    /// </summary>
    public class RecordPauseRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the client state associated with the recording pause request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for the recording pause request.
        /// This ID can be used for tracking and managing multiple requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}