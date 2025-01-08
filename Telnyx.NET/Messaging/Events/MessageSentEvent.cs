using System.Text.Json.Serialization;
using Telnyx.NET.Models.Events;

namespace Telnyx.NET.Messaging.Events
{
    /// <summary>
    /// Represents an event triggered when a message is sent, containing the relevant details 
    /// about the message and its associated data.
    /// </summary>
    public class MessageSentEvent : BaseEvent
    {
        /// <summary>
        /// Gets or sets the payload of the message sent event containing detailed information about the message.
        /// </summary>
        [JsonPropertyName("payload")]
        public MessageSentPayload Payload { get; set; }
    }

    /// <summary>
    /// Contains the payload data for a message sent event, including message metadata, recipient details, 
    /// and media related to the message.
    /// </summary>
    public class MessageSentPayload
    {
        /// <summary>
        /// Gets or sets the type of the record (e.g., "message").
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; }

        /// <summary>
        /// Gets or sets the direction of the message (e.g., "inbound" or "outbound").
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the message.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the message (e.g., "sms", "mms").
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the messaging profile ID associated with the message.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the organization ID associated with the message.
        /// </summary>
        [JsonPropertyName("organization_id")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the sender information for the message.
        /// </summary>
        [JsonPropertyName("from")]
        public MessageFrom From { get; set; }

        /// <summary>
        /// Gets or sets the list of recipients (to) and CCs for the message.
        /// </summary>
        [JsonPropertyName("to")]
        public List<MessageToCc> To { get; set; }

        /// <summary>
        /// Gets or sets the text content of the message (for SMS or MMS).
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the subject of the message (typically used for MMS or email).
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the list of media files associated with the message.
        /// </summary>
        [JsonPropertyName("media")]
        public List<MessageMedia> Media { get; set; }

        /// <summary>
        /// Gets or sets the URL where a webhook will be sent when the message is processed.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the fallback URL for webhook notifications in case the primary webhook URL fails.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Gets or sets the encoding used for the message (e.g., "utf-8").
        /// </summary>
        [JsonPropertyName("encoding")]
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or sets the number of parts the message is split into (if applicable).
        /// </summary>
        [JsonPropertyName("parts")]
        public int Parts { get; set; }

        /// <summary>
        /// Gets or sets the list of tags associated with the message (e.g., for categorization or tracking).
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the cost of sending the message (if applicable).
        /// </summary>
        [JsonPropertyName("cost")]
        public object Cost { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the message was received.
        /// </summary>
        [JsonPropertyName("received_at")]
        public DateTimeOffset? ReceivedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the message was sent.
        /// </summary>
        [JsonPropertyName("sent_at")]
        public object SentAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the message was completed.
        /// </summary>
        [JsonPropertyName("completed_at")]
        public object CompletedAt { get; set; }

        /// <summary>
        /// Gets or sets the expiration timestamp for the message (if applicable).
        /// </summary>
        [JsonPropertyName("valid_until")]
        public object ValidUntil { get; set; }

        /// <summary>
        /// Gets or sets the list of errors related to the message, if any occurred.
        /// </summary>
        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }
    }

    /// <summary>
    /// Represents the media associated with a message, such as images or files.
    /// </summary>
    public class MessageMedia
    {
        /// <summary>
        /// Gets or sets the URL pointing to the media content (e.g., an image or video).
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the content type of the media (e.g., "image/jpeg").
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the SHA-256 hash of the media file, used for verification or integrity checks.
        /// </summary>
        [JsonPropertyName("sha256")]
        public string Sha256 { get; set; }

        /// <summary>
        /// Gets or sets the size of the media file in bytes.
        /// </summary>
        [JsonPropertyName("size")]
        public int? Size { get; set; }
    }
}
