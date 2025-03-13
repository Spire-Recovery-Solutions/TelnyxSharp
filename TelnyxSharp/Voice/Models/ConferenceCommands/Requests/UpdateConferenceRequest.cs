using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for updating a conference.
    /// This is used to modify the role or behavior of participants in a conference.
    /// </summary>
    public class UpdateConferenceRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the call control ID of the participant to update in the conference.
        /// This ID uniquely identifies the participant whose role or behavior is to be updated.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public required string CallControlId { get; set; }

        /// <summary>
        /// Gets or sets the optional command ID for this request.
        /// This ID is used for tracking or grouping related requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets the supervisor role for the participant in the conference.
        /// This determines the level of control the participant has over the conference.
        /// </summary>
        [JsonPropertyName("supervisor_role")]
        public required SupervisorRole SupervisorRole { get; set; } = SupervisorRole.None;

        /// <summary>
        /// Gets or sets the list of call control IDs for participants who are to be whispered to.
        /// These participants will hear the supervisor’s whisper during the conference.
        /// </summary>
        [JsonPropertyName("whisper_call_control_ids")]
        public List<string>? WhisperCallControlIds { get; set; }
    }
}