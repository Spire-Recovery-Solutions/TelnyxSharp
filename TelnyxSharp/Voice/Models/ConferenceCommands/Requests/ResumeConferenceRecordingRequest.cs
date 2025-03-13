using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for resuming a conference recording.
    /// This model includes the command ID and recording ID for identifying the specific recording to resume.
    /// </summary>
    public class ResumeConferenceRecordingRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the unique command ID for this recording resume request.
        /// This ID is used to identify and manage the request.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets the unique recording ID for the conference recording that is to be resumed.
        /// This ID identifies the specific recording that will be resumed.
        /// </summary>
        [JsonPropertyName("recording_id")]
        public string? RecordingId { get; set; }
    }
}