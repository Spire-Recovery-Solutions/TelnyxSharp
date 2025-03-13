using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for muting participants in a conference.
    /// This model allows muting multiple participants based on their call control IDs.
    /// </summary>
    public class MuteConferenceParticipantsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of call control IDs for the participants to be muted.
        /// Each ID represents a participant in the conference.
        /// </summary>
        [JsonPropertyName("call_control_ids")]
        public List<string>? CallControlIds { get; set; }
    }
}