using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a participant joins a room.
    /// </summary>
    public class ParticipantJoinedEvent : BaseEvent
    {
        /// <summary>
        /// Contains the details of the participant joined event.
        /// </summary>
        [JsonPropertyName("payload")]
        public ParticipantJoinedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a participant joined event.
    /// </summary>
    public class ParticipantJoinedPayload
    {
        /// <summary>
        /// Gets or sets the session ID of the participant.
        /// </summary>
        [JsonPropertyName("session_id")]
        public string Session_id { get; set; }

        /// <summary>
        /// Gets or sets the room ID where the participant joined.
        /// </summary>
        [JsonPropertyName("room_id")]
        public string Room_id { get; set; }

        /// <summary>
        /// Gets or sets the context of the event (e.g., the reason or action that triggered the join).
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the participant who joined the room.
        /// </summary>
        [JsonPropertyName("participant_id")]
        public string Participant_id { get; set; }
    }
}