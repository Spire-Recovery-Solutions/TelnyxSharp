using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to stop transcription for a call.
    /// This class allows you to specify client state and a unique command ID to track the transcription stop request.
    /// </summary>
    public class TranscriptionStopRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the client state associated with the transcription stop request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for the transcription stop request.
        /// This ID is used for tracking and managing multiple requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}