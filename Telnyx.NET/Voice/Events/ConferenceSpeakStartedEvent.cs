using System.Text.Json.Serialization;
using Telnyx.NET.Models.Events;

namespace Telnyx.NET.Voice.Events
{
    /// <summary>
    /// Represents an event triggered when a participant starts speaking in a conference.
    /// </summary>
    public class ConferenceSpeakStartedEvent : BaseEvent
    {
        /// <summary>
        /// Contains the details of the conference speak-started event.
        /// </summary>
        [JsonPropertyName("payload")]
        public ConferenceSpeakStartedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a conference speak-started event.
    /// </summary>
    public class ConferenceSpeakStartedPayload
    {
        /// <summary>
        /// Gets or sets the identifier for the connection that started speaking.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the call session ID of the participant who started speaking.
        /// </summary>
        [JsonPropertyName("creator_call_session_id")]
        public string Creator_call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the conference.
        /// </summary>
        [JsonPropertyName("conference_id")]
        public string Conference_id { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the speak-started event occurred.
        /// </summary>
        [JsonPropertyName("occurred_at")]
        public string Occurred_at { get; set; }
    }
}