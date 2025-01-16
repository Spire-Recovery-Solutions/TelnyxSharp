using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a media playback ends for a participant in a conference.
    /// </summary>
    public class ConferenceParticipantPlaybackEndedEvent : BaseEvent
    {
        /// <summary>
        /// Contains detailed information about the playback-ended event for the participant.
        /// </summary>
        [JsonPropertyName("payload")]
        public ConferenceParticipantPlaybackEndedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a conference participant playback-ended event.
    /// </summary>
    public class ConferenceParticipantPlaybackEndedPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier for the call control session.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string Call_control_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the call leg.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string Call_leg_id { get; set; }

        /// <summary>
        /// Gets or sets the unique session identifier for the entire call session.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the state of the client involved in the conference.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the connection associated with the conference.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the call session ID of the creator of the playback.
        /// </summary>
        [JsonPropertyName("creator_call_session_id")]
        public string Creator_call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the conference.
        /// </summary>
        [JsonPropertyName("conference_id")]
        public string Conference_id { get; set; }

        /// <summary>
        /// Gets or sets the URL of the media file that was played during the conference.
        /// </summary>
        [JsonPropertyName("media_url")]
        public string Media_url { get; set; }

        /// <summary>
        /// Gets or sets the name of the media file that was played.
        /// </summary>
        [JsonPropertyName("media_name")]
        public string Media_name { get; set; }

        /// <summary>
        /// Gets or sets the timestamp indicating when the playback ended.
        /// </summary>
        [JsonPropertyName("occurred_at")]
        public string Occurred_at { get; set; }
    }
}