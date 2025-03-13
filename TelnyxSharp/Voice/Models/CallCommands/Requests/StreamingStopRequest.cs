using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to stop an ongoing media stream for a call, including options for tracking
    /// the stream's state via `stream_id` and identifying the specific request via `command_id`.
    /// </summary>
    public class StreamingStopRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the client state associated with the streaming stop request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for the streaming stop request.
        /// This ID is used for tracking and managing multiple requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets the unique stream ID associated with the media stream that should be stopped.
        /// This is used to identify the specific stream to stop.
        /// </summary>
        [JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }
    }
}