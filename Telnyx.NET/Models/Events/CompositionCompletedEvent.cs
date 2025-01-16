using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a composition (e.g., video or media file) has been completed.
    /// This event provides details about the composition such as its duration, format, and other relevant metadata.
    /// </summary>
    public class CompositionCompletedEvent : BaseEvent
    {
        /// <summary>
        /// Contains detailed information about the completed composition event.
        /// </summary>
        [JsonPropertyName("payload")]
        public CompositionCompletedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a composition completed event.
    /// </summary>
    public class CompositionCompletedPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier for the composition.
        /// </summary>
        [JsonPropertyName("composition_id")]
        public string Composition_id { get; set; }

        /// <summary>
        /// Gets or sets the URL from which the completed composition can be downloaded.
        /// </summary>
        [JsonPropertyName("download_url")]
        public string Download_url { get; set; }

        /// <summary>
        /// Gets or sets the duration of the composition in seconds.
        /// </summary>
        [JsonPropertyName("duration_secs")]
        public int Duration_secs { get; set; }

        /// <summary>
        /// Gets or sets the format of the composition (e.g., MP4, MKV).
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the resolution of the composition (e.g., 1920x1080, 1280x720).
        /// </summary>
        [JsonPropertyName("resolution")]
        public string Resolution { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the room associated with the composition.
        /// </summary>
        [JsonPropertyName("room_id")]
        public string Room_id { get; set; }

        /// <summary>
        /// Gets or sets the unique session identifier for the composition session.
        /// </summary>
        [JsonPropertyName("session_id")]
        public string Session_id { get; set; }

        /// <summary>
        /// Gets or sets the size of the composition file in megabytes.
        /// This property may be null if the size is unknown or not provided.
        /// </summary>
        [JsonPropertyName("size_mb")]
        public object Size_mb { get; set; }
    }
}