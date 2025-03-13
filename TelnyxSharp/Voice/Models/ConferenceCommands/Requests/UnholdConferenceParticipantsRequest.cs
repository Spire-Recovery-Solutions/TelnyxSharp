using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for unholding conference participants.
    /// This is used to unhold one or more participants in a conference call.
    /// </summary>
    public class UnholdConferenceParticipantsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of call control IDs of the participants to be unheld.
        /// Each participant identified by their call control ID will be unheld.
        /// </summary>
        [JsonPropertyName("call_control_ids")]
        public required List<string> CallControlIds { get; set; }
    }
}