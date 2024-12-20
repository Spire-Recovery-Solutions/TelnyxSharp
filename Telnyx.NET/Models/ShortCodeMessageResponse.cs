using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for a short code message sent through the Telnyx API.
    /// </summary>
    public class ShortCodeMessageResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the data associated with the short code message response.
        /// </summary>
        [JsonPropertyName("data")]
        public ShortCodeMessageData? Data { get; set; }

        
        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains detailed information about a short code message.
    /// </summary>
    public class ShortCodeMessageData
    {
        /// <summary>
        /// Gets or sets the type of record (e.g., "message").
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the direction of the message (e.g., "inbound" or "outbound").
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the message.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the type of message (e.g., "sms").
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ID of the messaging profile used to send the message.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string MessagingProfileId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the organization ID associated with the message.
        /// </summary>
        [JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the sender's details.
        /// </summary>
        [JsonPropertyName("from")]
        public FromTo? From { get; set; }

        /// <summary>
        /// Gets or sets the list of recipients for the message.
        /// </summary>
        [JsonPropertyName("to")]
        public List<FromTo>? To { get; set; }

        /// <summary>
        /// Gets or sets the text content of the message.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the subject of the message, if applicable.
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Gets or sets the list of media included in the message.
        /// </summary>
        [JsonPropertyName("media")]
        public List<Media>? Media { get; set; }

        /// <summary>
        /// Gets or sets the webhook URL for status updates.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the failover webhook URL in case the primary webhook fails.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Gets or sets the encoding format of the message.
        /// </summary>
        [JsonPropertyName("encoding")]
        public string Encoding { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of parts in the message (for multipart messages).
        /// </summary>
        [JsonPropertyName("parts")]
        public int Parts { get; set; }

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
        /// Gets or sets the timestamp when the message was received.
        /// </summary>
        [JsonPropertyName("received_at")]
        public DateTime? ReceivedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the message was sent.
        /// </summary>
        [JsonPropertyName("sent_at")]
        public DateTime? SentAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the message was completed.
        /// </summary>
        [JsonPropertyName("completed_at")]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or sets the expiration timestamp of the message.
        /// </summary>
        [JsonPropertyName("valid_until")]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Gets or sets the list of errors, if any occurred during message processing.
        /// </summary>
        [JsonPropertyName("errors")]
        public List<Error>? Errors { get; set; }
    }
}