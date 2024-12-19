using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents a request to send a long code message using the Telnyx API.
    /// Includes various properties for message configuration, such as recipients, message content, media, and webhooks.
    /// </summary>
    public class LongCodeMessageRequest : ITelnyxRequest
    {
        /// <summary>
        /// The phone number the message will be sent from.
        /// This is a required field and should be a valid long code number.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; } = string.Empty;

        /// <summary>
        /// The phone number the message will be sent to.
        /// This is a required field and should be a valid recipient number.
        /// </summary>
        [JsonPropertyName("to")]
        public string To { get; set; } = string.Empty;

        /// <summary>
        /// The text content of the message.
        /// Optional; can be null if sending a message with media or other content.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The subject of the message.
        /// Optional; primarily used for MMS messages to include a subject line.
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// A list of media URLs to include in the message.
        /// Optional; used for sending MMS messages with attached media.
        /// </summary>
        [JsonPropertyName("media_urls")]
        public List<string>? MediaUrls { get; set; }

        /// <summary>
        /// The URL where webhook events will be sent for message status updates.
        /// Optional; overrides the default webhook URL configured in the messaging profile.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// A failover URL where webhook events will be sent if the primary webhook fails.
        /// Optional; used for ensuring message status updates are received.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Indicates whether the message should use webhooks configured in the messaging profile.
        /// Optional; defaults to `false` if not specified.
        /// </summary>
        [JsonPropertyName("use_profile_webhooks")]
        public bool? UseProfileWebhooks { get; set; }

        /// <summary>
        /// The type of message being sent (e.g., "sms", "mms").
        /// Optional; specifies the messaging protocol to be used.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Indicates whether to automatically detect the message type.
        /// Optional; if true, the system determines whether the message should be sent as SMS or MMS.
        /// </summary>
        [JsonPropertyName("auto_detect")]
        public bool? AutoDetect { get; set; }
    }
}