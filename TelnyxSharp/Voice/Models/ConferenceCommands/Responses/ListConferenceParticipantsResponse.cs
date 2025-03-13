using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Voice.Models.ConferenceCommands.Responses
{
    /// <summary>
    /// Represents the response for listing conference participants.
    /// Contains data about the participants of a specific conference.
    /// </summary>
    public class ListConferenceParticipantsResponse : TelnyxResponse<ListConferenceParticipantsData>
    {
    }

    /// <summary>
    /// Contains the participant data for a conference.
    /// This includes various details like participant's conference status, muting state, and conference-specific information.
    /// </summary>
    public class ListConferenceParticipantsData
    {
        /// <summary>
        /// Gets or sets the record type (e.g., permanent or temporary).
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the participant in the conference.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the call leg ID for the participant, representing a particular call connection.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string CallLegId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the call control ID for managing the participant’s call control actions.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string CallControlId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the conference details related to the participant.
        /// </summary>
        [JsonPropertyName("conference")]
        public Conference Conference { get; set; } = new();

        /// <summary>
        /// Gets or sets the list of call control IDs that are used for whispering (coaching) in the conference.
        /// </summary>
        [JsonPropertyName("whisper_call_control_ids")]
        public List<string> WhisperCallControlIds { get; set; } = new();

        /// <summary>
        /// Gets or sets the creation timestamp for when the participant joined the conference.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the timestamp for the last update made to the participant's details.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a flag indicating if the conference should end when this participant exits.
        /// </summary>
        [JsonPropertyName("end_conference_on_exit")]
        public bool EndConferenceOnExit { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if a soft end should occur when the participant exits.
        /// </summary>
        [JsonPropertyName("soft_end_conference_on_exit")]
        public bool SoftEndConferenceOnExit { get; set; }

        /// <summary>
        /// Gets or sets the status of the participant (e.g., active, disconnected).
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the muted state of the participant.
        /// </summary>
        [JsonPropertyName("muted")]
        public bool Muted { get; set; }

        /// <summary>
        /// Gets or sets the hold state of the participant.
        /// </summary>
        [JsonPropertyName("on_hold")]
        public bool OnHold { get; set; }
    }

    /// <summary>
    /// Represents the conference information related to a participant.
    /// It includes basic details like the conference ID and name.
    /// </summary>
    public class Conference
    {
        /// <summary>
        /// Gets or sets the unique identifier for the conference.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the conference.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}