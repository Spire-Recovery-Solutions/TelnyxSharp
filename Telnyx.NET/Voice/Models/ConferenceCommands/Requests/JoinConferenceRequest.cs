using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for joining a conference.
    /// This model contains various options to configure the participant's behavior when joining a conference,
    /// including mute settings, hold settings, supervisor roles, and more.
    /// </summary>
    public class JoinConferenceRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier for the call control.
        /// This ID is used to identify the participant joining the conference.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public required string CallControlId { get; set; }

        /// <summary>
        /// Gets or sets the client state. This optional field allows you to pass custom information related to the client.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for tracking this conference join command.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets whether the conference should end when the participant exits the conference.
        /// </summary>
        [JsonPropertyName("end_conference_on_exit")]
        public bool? EndConferenceOnExit { get; set; }

        /// <summary>
        /// Gets or sets whether a soft end should be applied when the participant exits the conference.
        /// A soft end may allow some ongoing calls to continue.
        /// </summary>
        [JsonPropertyName("soft_end_conference_on_exit")]
        public bool? SoftEndConferenceOnExit { get; set; }

        /// <summary>
        /// Gets or sets whether the participant should be placed on hold when joining the conference.
        /// </summary>
        [JsonPropertyName("hold")]
        public bool? Hold { get; set; }

        /// <summary>
        /// Gets or sets the URL for hold audio to be played to the participant.
        /// </summary>
        [JsonPropertyName("hold_audio_url")]
        public string? HoldAudioUrl { get; set; }

        /// <summary>
        /// Gets or sets the media name to be played for hold audio.
        /// This is typically a pre-defined media resource.
        /// </summary>
        [JsonPropertyName("hold_media_name")]
        public string? HoldMediaName { get; set; }

        /// <summary>
        /// Gets or sets whether the participant should be muted upon entering the conference.
        /// </summary>
        [JsonPropertyName("mute")]
        public bool? Mute { get; set; }

        /// <summary>
        /// Gets or sets whether the conference should start automatically when the participant enters.
        /// </summary>
        [JsonPropertyName("start_conference_on_enter")]
        public bool? StartConferenceOnEnter { get; set; }

        /// <summary>
        /// Gets or sets the supervisor role for the participant. Supervisors can have specific roles such as barge, whisper, or monitor.
        /// </summary>
        [JsonPropertyName("supervisor_role")]
        public SupervisorRole? SupervisorRole { get; set; }

        /// <summary>
        /// Gets or sets the list of participant call control IDs that the supervisor can whisper to.
        /// This enables supervisors to communicate privately with specific participants in the conference.
        /// </summary>
        [JsonPropertyName("whisper_call_control_ids")]
        public List<string>? WhisperCallControlIds { get; set; }

        /// <summary>
        /// Gets or sets the beep settings for the participant. The beep indicates the state of the participant's actions during conference events.
        /// </summary>
        [JsonPropertyName("beep_enabled")]
        public BeepEnabled? BeepEnabled { get; set; }
    }
}