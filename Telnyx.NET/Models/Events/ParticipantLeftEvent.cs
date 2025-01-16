using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a participant leaves a room.
    /// </summary>
    public class ParticipantLeftEvent : BaseEvent
    {
        /// <summary>
        /// Contains the details of the participant left event.
        /// </summary>
        [JsonPropertyName("payload")]
        public ParticipantLeftPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a participant left event.
    /// </summary>
    public class ParticipantLeftPayload
    {
        /// <summary>
        /// Gets or sets the session ID of the participant.
        /// </summary>
        [JsonPropertyName("session_id")]
        public string Session_id { get; set; }

        /// <summary>
        /// Gets or sets the room ID from which the participant left.
        /// </summary>
        [JsonPropertyName("room_id")]
        public string Room_id { get; set; }

        /// <summary>
        /// Gets or sets the context of the event (e.g., why the participant left).
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the participant who left the room.
        /// </summary>
        [JsonPropertyName("participant_id")]
        public string Participant_id { get; set; }

        /// <summary>
        /// Gets or sets the duration (in seconds) the participant spent in the room before leaving.
        /// </summary>
        [JsonPropertyName("duration_secs")]
        public int Duration_secs { get; set; }

        /// <summary>
        /// Gets or sets the reason the participant left the room (e.g., ended the call, disconnected).
        /// </summary>
        [JsonPropertyName("left_reason")]
        public string Left_reason { get; set; }
    }
}