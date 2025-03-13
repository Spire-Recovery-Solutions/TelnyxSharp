using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for leaving a conference.
    /// This model contains the parameters for a participant to leave a conference call,
    /// including the option to configure beep behavior and track the command.
    /// </summary>
    public class LeaveConferenceRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier for the call control.
        /// This ID is used to identify the participant leaving the conference.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public required string CallControlId { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for tracking this conference leave command.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets the beep behavior when the participant leaves the conference.
        /// BeepEnabled options include settings for always, never, or specific moments like on enter/exit.
        /// </summary>
        [JsonPropertyName("beep_enabled")]
        public BeepEnabled? BeepEnabled { get; set; }
    }
}