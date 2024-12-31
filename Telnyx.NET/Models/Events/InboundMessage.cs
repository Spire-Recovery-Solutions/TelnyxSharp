using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an inbound message event.
    /// </summary>
    public class InboundMessage
    {
        /// <summary>
        /// Gets or sets the data associated with the inbound message.
        /// </summary>
        [JsonPropertyName("data")]
        public InboundMessageData Data { get; set; }
    }

    /// <summary>
    /// Represents the data details of an inbound message.
    /// </summary>
    public class InboundMessageData
    {
        /// <summary>
        /// Gets or sets the type of the record.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; } = "event";

        /// <summary>
        /// Gets or sets the unique identifier of the inbound message.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the type of event associated with the message.
        /// </summary>
        [JsonPropertyName("event_type")]
        public string? EventType { get; set; } = "message.received";

        /// <summary>
        /// Gets or sets the timestamp when the event occurred.
        /// </summary>
        [JsonPropertyName("occurred_at")]
        public DateTimeOffset OccurredAt { get; set; }

        /// <summary>
        /// Gets or sets the payload containing message details.
        /// </summary>
        [JsonPropertyName("payload")]
        public InboundMessagePayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload of an inbound message.
    /// </summary>
    public class InboundMessagePayload : MessageBaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundMessagePayload"/> class 
        /// with default values for direction and record type.
        /// </summary>
        public InboundMessagePayload()
        {
            Direction = MessageDirection.Inbound;
            RecordType = MessageRecordType.Message;
        }

        /// <summary>
        /// Gets or sets the list of recipients (CC) of the message.
        /// </summary>
        [JsonPropertyName("cc")]
        public List<FromTo>? Cc { get; set; }

        /// <summary>
        /// Gets or sets the list of media files associated with the message.
        /// </summary>
        [JsonPropertyName("media")]
        public new List<WebhookMedia>? Media { get; set; }
    }

    /// <summary>
    /// Represents media details included in a webhook message.
    /// </summary>
    public class WebhookMedia
    {
        /// <summary>
        /// Gets or sets the URL of the media file.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the content type of the media file.
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the size of the media file in bytes.
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the SHA-256 hash of the media file.
        /// </summary>
        [JsonPropertyName("hash_sha256")]
        public string HashSha256 { get; set; }
    }
}
