using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a session starts.
    /// </summary>
    public class SessionStartedEvent : BaseEvent
    {
        /// <summary>
        /// Contains the details of the session started event.
        /// </summary>
        [JsonPropertyName("payload")]
        public SessionStartedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a session started event.
    /// </summary>
    public class SessionStartedPayload
    {
        /// <summary>
        /// Gets or sets the session ID for the started session.
        /// </summary>
        [JsonPropertyName("session_id")]
        public string Session_id { get; set; }

        /// <summary>
        /// Gets or sets the room ID where the session is being held.
        /// </summary>
        [JsonPropertyName("room_id")]
        public string Room_id { get; set; }
    }
}