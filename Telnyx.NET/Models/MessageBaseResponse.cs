using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the base response model for messages, containing common properties for various message types.
    /// </summary>
    public abstract class MessageBaseResponse
    {
        /// <summary>
        /// Gets or sets the record type, representing the type of the message record.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the direction of the message, indicating whether it is inbound or outbound.
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the message.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the type of message, such as SMS, MMS, or short code.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ID of the messaging profile associated with the message.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string MessagingProfileId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ID of the organization associated with the message.
        /// </summary>
        [JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the sender information for the message.
        /// </summary>
        [JsonPropertyName("from")]
        public FromTo? From { get; set; }

        /// <summary>
        /// Gets or sets the list of recipient information for the message.
        /// </summary>
        [JsonPropertyName("to")]
        public List<FromTo>? To { get; set; }

        /// <summary>
        /// Gets or sets the text content of the message.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the subject of the message, applicable for certain message types.
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Gets or sets the list of media URLs associated with the message.
        /// </summary>
        [JsonPropertyName("media")]
        public List<Media>? Media { get; set; }

        /// <summary>
        /// Gets or sets the webhook URL used for message notifications.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the failover webhook URL used if the primary webhook fails.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Gets or sets the encoding type used for the message.
        /// </summary>
        [JsonPropertyName("encoding")]
        public string? Encoding { get; set; }

        /// <summary>
        /// Gets or sets the number of message parts in case the message was split.
        /// </summary>
        [JsonPropertyName("parts")]
        public long Parts { get; set; }

        /// <summary>
        /// Gets or sets the list of tags associated with the message.
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        /// <summary>
        /// Gets or sets the cost details of the message.
        /// </summary>
        [JsonPropertyName("cost")]
        public Cost? Cost { get; set; }

        /// <summary>
        /// Gets or sets the date and time the message was received.
        /// </summary>
        [JsonPropertyName("received_at")]
        public DateTime? ReceivedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time the message was sent.
        /// </summary>
        [JsonPropertyName("sent_at")]
        public DateTime? SentAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time the message delivery was completed.
        /// </summary>
        [JsonPropertyName("completed_at")]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time the message is valid until.
        /// </summary>
        [JsonPropertyName("valid_until")]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Gets or sets the list of errors, if any, associated with the message.
        /// </summary>
        [JsonPropertyName("errors")]
        public List<Error>? Errors { get; set; }
    }
}