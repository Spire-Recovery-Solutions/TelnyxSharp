using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response received after sending a message using a number pool.
    /// </summary>
    public class NumberPoolMessageResponse : ITelnyxResponse
    {
        /// <summary>
        /// Contains the data about the message sent through the number pool.
        /// </summary>
        [JsonPropertyName("data")]
        public NumberPoolMessageData? Data { get; set; }

        /// <summary>
        /// Contains any errors that occurred during the API request.
        /// This is null if no errors were encountered.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the detailed information about a message sent through the number pool.
    /// </summary>
    public class NumberPoolMessageData
    {
        /// <summary>
        /// Indicates the type of record (e.g., "message").
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; }

        /// <summary>
        /// Indicates the direction of the message (e.g., "outbound").
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// The unique identifier for the message.
        /// This property may be null if not provided in the response.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Specifies the type of the message (e.g., SMS, MMS).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the messaging profile used to send the message.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string MessagingProfileId { get; set; }

        /// <summary>
        /// The organization ID associated with the message.
        /// This property may be null if not provided.
        /// </summary>
        [JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Information about the sender of the message.
        /// </summary>
        [JsonPropertyName("from")]
        public FromTo From { get; set; }

        /// <summary>
        /// A list of recipients for the message.
        /// Each recipient is represented as a FromTo object.
        /// </summary>
        [JsonPropertyName("to")]
        public List<FromTo> To { get; set; }

        /// <summary>
        /// The text content of the message.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// The subject of the message (applicable for MMS messages).
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// List of media attachments sent with the message.
        /// </summary>
        [JsonPropertyName("media")]
        public List<Media> Media { get; set; }

        /// <summary>
        /// The URL for the webhook callback associated with this message.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// The failover URL for the webhook callback, used if the primary URL fails.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string WebhookFailoverUrl { get; set; }

        /// <summary>
        /// The encoding format used for the message (e.g., "GSM").
        /// </summary>
        [JsonPropertyName("encoding")]
        public string Encoding { get; set; }

        /// <summary>
        /// The number of message parts if the message was split into multiple parts.
        /// </summary>
        [JsonPropertyName("parts")]
        public int Parts { get; set; }

        /// <summary>
        /// List of tags associated with the message for categorization or additional metadata.
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The cost information for sending the message.
        /// </summary>
        [JsonPropertyName("cost")]
        public Cost Cost { get; set; }

        /// <summary>
        /// The time when the message was received for processing.
        /// </summary>
        [JsonPropertyName("received_at")]
        public DateTime ReceivedAt { get; set; }

        /// <summary>
        /// The time when the message was sent, if available.
        /// </summary>
        [JsonPropertyName("sent_at")]
        public DateTime? SentAt { get; set; }

        /// <summary>
        /// The time when the message was completed (e.g., delivered or failed), if available.
        /// </summary>
        [JsonPropertyName("completed_at")]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The time until which the message remains valid, if applicable.
        /// </summary>
        [JsonPropertyName("valid_until")]
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// List of errors encountered during message processing, if any.
        /// </summary>
        [JsonPropertyName("errors")]
        public List<Error>? Errors { get; set; }
    }
}