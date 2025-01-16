using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for unmuting conference participants.
    /// This is used to unmute one or more participants in a conference call.
    /// </summary>
    public class UnmuteConferenceParticipantsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of call control IDs of the participants to be unmuted.
        /// Each participant identified by their call control ID will be unmuted.
        /// </summary>
        [JsonPropertyName("call_control_ids")]
        public List<string>? CallControlIds { get; set; }
    }
}