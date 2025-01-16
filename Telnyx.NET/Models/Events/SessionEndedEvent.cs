using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a session ends.
    /// </summary>
    public class SessionEndedEvent : BaseEvent
    {
        /// <summary>
        /// Contains the details of the session ended event.
        /// </summary>
        [JsonPropertyName("payload")]
        public SessionEndedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a session ended event.
    /// </summary>
    public class SessionEndedPayload
    {
        /// <summary>
        /// Gets or sets the session ID for the ended session.
        /// </summary>
        [JsonPropertyName("session_id")]
        public string Session_id { get; set; }

        /// <summary>
        /// Gets or sets the room ID where the session ended.
        /// </summary>
        [JsonPropertyName("room_id")]
        public string Room_id { get; set; }

        /// <summary>
        /// Gets or sets the duration of the session in seconds.
        /// </summary>
        [JsonPropertyName("duration_secs")]
        public int Duration_secs { get; set; }

        /// <summary>
        /// Gets or sets the reason for the session ending.
        /// </summary>
        [JsonPropertyName("ended_reason")]
        public string Ended_reason { get; set; }
    }
}