using System.Text.Json.Serialization;

namespace TelnyxSharp.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a recording is completed.
    /// </summary>
    public class RecordingCompletedEvent : BaseEvent
    {
        /// <summary>
        /// Contains the details of the recording completed event.
        /// </summary>
        [JsonPropertyName("payload")]
        public RecordingCompletedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a completed recording event.
    /// </summary>
    public class RecordingCompletedPayload
    {
        /// <summary>
        /// Gets or sets the session ID for the recording.
        /// </summary>
        [JsonPropertyName("session_id")]
        public string Session_id { get; set; }

        /// <summary>
        /// Gets or sets the room ID where the recording occurred.
        /// </summary>
        [JsonPropertyName("room_id")]
        public string Room_id { get; set; }

        /// <summary>
        /// Gets or sets the participant ID associated with the recording.
        /// </summary>
        [JsonPropertyName("participant_id")]
        public string Participant_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the completed recording.
        /// </summary>
        [JsonPropertyName("recording_id")]
        public string Recording_id { get; set; }

        /// <summary>
        /// Gets or sets the type of the recording (e.g., audio, video).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the size of the recording in megabytes.
        /// </summary>
        [JsonPropertyName("size_mb")]
        public object Size_mb { get; set; }

        /// <summary>
        /// Gets or sets the URL where the recording can be downloaded.
        /// </summary>
        [JsonPropertyName("download_url")]
        public string Download_url { get; set; }

        /// <summary>
        /// Gets or sets the codec used for the recording.
        /// </summary>
        [JsonPropertyName("codec")]
        public string Codec { get; set; }

        /// <summary>
        /// Gets or sets the duration of the recording in seconds.
        /// </summary>
        [JsonPropertyName("duration_secs")]
        public int Duration_secs { get; set; }
    }
}