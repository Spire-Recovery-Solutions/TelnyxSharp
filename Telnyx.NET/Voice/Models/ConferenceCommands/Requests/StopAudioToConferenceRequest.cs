using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for stopping audio playback to conference participants.
    /// This is used to stop the audio that is being played to the conference participants.
    /// </summary>
    public class StopAudioToConferenceRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of call control IDs for the participants whose audio playback will be stopped.
        /// This list specifies which participants in the conference will stop receiving the audio.
        /// </summary>
        [JsonPropertyName("call_control_ids")]
        public List<string>? CallControlIds { get; set; }
    }
}