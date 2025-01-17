using System.Text.Json.Serialization;
using Telnyx.NET.Models.Events;

namespace Telnyx.NET.Voice.Events
{
    /// <summary>
    /// Represents an event triggered when the playback in a conference ends.
    /// </summary>
    public class ConferencePlaybackEndedEvent : BaseEvent
    {
        /// <summary>
        /// Contains the details of the event when the playback in a conference ends.
        /// </summary>
        [JsonPropertyName("payload")]
        public ConferencePlaybackEndedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a conference playback-ended event.
    /// </summary>
    public class ConferencePlaybackEndedPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier for the connection in the conference.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the session ID of the participant who initiated the playback.
        /// </summary>
        [JsonPropertyName("creator_call_session_id")]
        public string Creator_call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the conference.
        /// </summary>
        [JsonPropertyName("conference_id")]
        public string Conference_id { get; set; }

        /// <summary>
        /// Gets or sets the URL of the media that was played in the conference.
        /// </summary>
        [JsonPropertyName("media_url")]
        public string Media_url { get; set; }

        /// <summary>
        /// Gets or sets the name of the media that was played in the conference.
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