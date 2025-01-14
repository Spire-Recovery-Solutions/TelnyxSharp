using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for pausing the recording of a conference.
    /// This model allows for the identification of the recording to pause using the recording ID.
    /// </summary>
    public class PauseConferenceRecordingRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the command ID for this request.
        /// The command ID helps identify the specific request when processing.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets the recording ID to pause.
        /// The recording ID identifies the specific conference recording to pause.
        /// </summary>
        [JsonPropertyName("recording_id")]
        public string? RecordingId { get; set; }
    }
}