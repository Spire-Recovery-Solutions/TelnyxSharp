using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a participant ends speaking in a conference.
    /// </summary>
    public class ConferenceSpeakEndedEvent : BaseEvent
    {
        /// <summary>
        /// Contains the details of the conference speak-ended event.
        /// </summary>
        [JsonPropertyName("payload")]
        public ConferenceSpeakEndedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a conference speak-ended event.
    /// </summary>
    public class ConferenceSpeakEndedPayload
    {
        /// <summary>
        /// Gets or sets the identifier for the connection that ended speaking.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the call session ID of the participant who ended speaking.
        /// </summary>
        [JsonPropertyName("creator_call_session_id")]
        public string Creator_call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the conference.
        /// </summary>
        [JsonPropertyName("conference_id")]
        public string Conference_id { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the speak-ended event occurred.
        /// </summary>
        [JsonPropertyName("occurred_at")]
        public string Occurred_at { get; set; }
    }
}