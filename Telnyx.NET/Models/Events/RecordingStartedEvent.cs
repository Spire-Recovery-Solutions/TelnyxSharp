using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a recording starts.
    /// </summary>
    public class RecordingStartedEvent : BaseEvent
    {
        /// <summary>
        /// Contains the details of the recording started event.
        /// </summary>
        [JsonPropertyName("payload")]
        public RecordingStartedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a recording started event.
    /// </summary>
    public class RecordingStartedPayload
    {
        /// <summary>
        /// Gets or sets the session ID for the recording.
        /// </summary>
        [JsonPropertyName("session_id")]
        public string Session_id { get; set; }

        /// <summary>
        /// Gets or sets the room ID where the recording started.
        /// </summary>
        [JsonPropertyName("room_id")]
        public string Room_id { get; set; }

        /// <summary>
        /// Gets or sets the participant ID associated with the recording.
        /// </summary>
        [JsonPropertyName("participant_id")]
        public string Participant_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the recording.
        /// </summary>
        [JsonPropertyName("recording_id")]
        public string Recording_id { get; set; }

        /// <summary>
        /// Gets or sets the type of the recording (e.g., audio, video).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}