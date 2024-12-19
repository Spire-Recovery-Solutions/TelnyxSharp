using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response received from the Telnyx API after sending a long code message.
    /// Includes data about the message and any errors encountered during the API call.
    /// </summary>
    public class LongCodeMessageResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the detailed message data returned by the API.
        /// </summary>
        [JsonPropertyName("data")]
        public LongCodeMessageData? Data { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains detailed information about the message sent via the Telnyx API.
    /// </summary>
    public class LongCodeMessageData
    {
        /// <summary>
        /// The type of record (e.g., "message").
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// The direction of the message (e.g., "outbound").
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; } = string.Empty;

        /// <summary>
        /// Unique identifier for the message.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of message (e.g., "sms" or "mms").
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Identifier for the messaging profile used to send the message.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string MessagingProfileId { get; set; } = string.Empty;

        /// <summary>
        /// Identifier for the organization associated with the message.
        /// </summary>
        [JsonPropertyName("organization_id")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Details about the sender of the message.
        /// </summary>
        [JsonPropertyName("from")]
        public FromTo? From { get; set; }

        /// <summary>
        /// List of recipients for the message, along with their status and details.
        /// </summary>
        [JsonPropertyName("to")]
        public List<FromTo>? To { get; set; }

        /// <summary>
        /// The text content of the message.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The subject of the message, applicable for MMS.
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// List of media attached to the message.
        /// </summary>
        [JsonPropertyName("media")]
        public List<Media>? Media { get; set; }

        /// <summary>
        /// The webhook URL used for message status updates.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// The failover webhook URL used for message status updates.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        /// <summary>
        /// The encoding format of the message text.
        /// </summary>
        [JsonPropertyName("encoding")]
        public string? Encoding { get; set; }

        /// <summary>
        /// The number of message parts for multipart messages.
        /// </summary>
        [JsonPropertyName("parts")]
        public int? Parts { get; set; }

        /// <summary>
        /// List of tags associated with the message.
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        /// <summary>
        /// Cost information for sending the message.
        /// </summary>
        [JsonPropertyName("cost")]
        public Cost? Cost { get; set; }

        /// <summary>
        /// The timestamp when the message was received.
        /// </summary>
        [JsonPropertyName("received_at")]
        public DateTime? ReceivedAt { get; set; }

        /// <summary>
        /// The timestamp when the message was sent.
        /// </summary>
        [JsonPropertyName("sent_at")]
        public DateTime? SentAt { get; set; }

        /// <summary>
        /// The timestamp when the message was completed.
        /// </summary>
        [JsonPropertyName("completed_at")]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The expiration timestamp for the message's validity.
        /// </summary>
        [JsonPropertyName("valid_until")]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// List of errors encountered for individual message components.
        /// </summary>
        [JsonPropertyName("errors")]
        public List<Error>? Errors { get; set; }
    }
}