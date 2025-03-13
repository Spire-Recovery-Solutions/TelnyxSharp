using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for placing participants on hold in a conference.
    /// This model allows you to specify which participants to place on hold and provide audio settings for the hold.
    /// </summary>
    public class HoldConferenceParticipantsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of call control IDs for the participants to be placed on hold.
        /// Each participant in the conference is identified by a unique call control ID.
        /// </summary>
        [JsonPropertyName("call_control_ids")]
        public List<string>? CallControlIds { get; set; }

        /// <summary>
        /// Gets or sets the URL for the hold audio. 
        /// This audio will be played to the participants who are placed on hold.
        /// </summary>
        [JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Gets or sets the name of the media to be played to participants on hold.
        /// This could refer to a predefined media resource used for hold audio.
        /// </summary>
        [JsonPropertyName("media_name")]
        public string? MediaName { get; set; }
    }
}