using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for stopping the recording of a conference.
    /// This is used to stop the recording of an ongoing conference call.
    /// </summary>
    public class StopConferenceRecordingRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the client state that may be associated with the stop recording action.
        /// This is an optional field that can be used to store additional state information.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for the stop recording action.
        /// This can be used to correlate the request with a specific action in the system.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}