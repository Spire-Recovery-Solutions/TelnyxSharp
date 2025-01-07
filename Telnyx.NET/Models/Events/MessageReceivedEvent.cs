using System.Text.Json.Serialization;
using Telnyx.NET.Messaging.Models;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event for a message received from Telnyx.
    /// Inherits from the base event class and contains the payload
    /// for the received message details.
    /// </summary>
    public class MessageReceivedEvent : BaseEvent
    {
        /// <summary>
        /// Gets or sets the payload containing details about the received message.
        /// </summary>
        [JsonPropertyName("payload")]
        public MessageReceivedPayload Payload { get; set; }
    }

    /// <summary>
    /// Contains detailed information about a message that has been received.
    /// </summary>
    public class MessageReceivedPayload
    {
        /// <summary>
        /// Gets or sets the type of record for the message.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; }

        /// <summary>
        /// Gets or sets the direction of the message (incoming/outgoing).
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the message.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the message (e.g., SMS, MMS).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the messaging profile associated with the message.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the list of recipients for the message.
        /// </summary>
        [JsonPropertyName("to")]
        public List<MessageToCc>? To { get; set; }

        /// <summary>
        /// Gets or sets the list of carbon copy recipients for the message.
        /// </summary>
        [JsonPropertyName("cc")]
        public List<MessageToCc>? Cc { get; set; }

        /// <summary>
        /// Gets or sets the details of the sender of the message.
        /// </summary>
        [JsonPropertyName("from")]
        public MessageFrom From { get; set; }

        /// <summary>
        /// Gets or sets the text content of the message.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the list of media objects attached to the message.
        /// </summary>
        [JsonPropertyName("media")]
        public List<Media>? Media { get; set; }

        /// <summary>
        /// Gets or sets the URL for the webhook to be called for this message.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the failover URL for the webhook in case the primary fails.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public Cost WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Gets or sets the encoding type used for the message.
        /// </summary>
        [JsonPropertyName("encoding")]
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or sets the number of parts that the message is divided into.
        /// </summary>
        [JsonPropertyName("parts")]
        public int Parts { get; set; }

        /// <summary>
        /// Gets or sets the type of autoresponse, if applicable.
        /// </summary>
        [JsonPropertyName("autoresponse_type")]
        public string? AutoresponseType { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the message was sent.
        /// </summary>
        [JsonPropertyName("sent_at")]
        public DateTimeOffset? SentAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the message was completed.
        /// </summary>
        [JsonPropertyName("completed_at")]
        public DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp until the message is valid.
        /// </summary>
        [JsonPropertyName("valid_until")]
        public DateTimeOffset? ValidUntil { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the organization associated with the message.
        /// </summary>
        [JsonPropertyName("organization_id")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the subject of the message, if applicable.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the list of tags associated with the message.
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        /// <summary>
        /// Gets or sets the cost associated with sending the message.
        /// </summary>
        [JsonPropertyName("cost")]
        public Cost? Cost { get; set; }

        /// <summary>
        /// Gets or sets the breakdown of costs associated with the message.
        /// </summary>
        [JsonPropertyName("cost_breakdown")]
        public CostBreakdown CostBreakdown { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the message is marked as spam.
        /// </summary>
        [JsonPropertyName("is_spam")]
        public bool? IsSpam { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the message was received.
        /// </summary>
        [JsonPropertyName("received_at")]
        public DateTimeOffset? ReceivedAt { get; set; }

        /// <summary>
        /// Gets or sets the list of errors associated with processing the message, if any.
        /// </summary>
        [JsonPropertyName("errors")]
        public List<TelnyxError>? Errors { get; set; }
    }

    /// <summary>
    /// Represents the sender of a message, including phone number and carrier information.
    /// </summary>
    public class MessageFrom
    {
        /// <summary>
        /// Gets or sets the phone number of the sender.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the carrier of the sender's phone number.
        /// </summary>
        [JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Gets or sets the type of line used by the sender (e.g., mobile, landline).
        /// </summary>
        [JsonPropertyName("line_type")]
        public string LineType { get; set; }
    }

    /// <summary>
    /// Represents a recipient of a message, including phone number and status.
    /// </summary>
    public class MessageToCc
    {
        /// <summary>
        /// Gets or sets the phone number of the recipient.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the status of the message sent to the recipient.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the carrier of the recipient's phone number.
        /// </summary>
        [JsonPropertyName("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Gets or sets the type of line used by the recipient (e.g., mobile, landline).
        /// </summary>
        [JsonPropertyName("line_type")]
        public string LineType { get; set; }
    }

    /// <summary>
    /// Represents a breakdown of costs associated with sending a message,
    /// including carrier fees and the rate charged.
    /// </summary>
    public class CostBreakdown
    {
        /// <summary>
        /// Gets or sets the carrier fee associated with the message.
        /// </summary>
        [JsonPropertyName("carrier_fee")]
        public Cost CarrierFee { get; set; }

        /// <summary>
        /// Gets or sets the rate charged for sending the message.
        /// </summary>
        [JsonPropertyName("rate")]
        public Cost Rate { get; set; }
    }
}