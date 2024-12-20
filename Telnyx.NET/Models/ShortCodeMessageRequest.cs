using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents a request for sending a short code message through Telnyx API.
    /// </summary>
    public class ShortCodeMessageRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the sender's short code or phone number.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the recipient's phone number.
        /// </summary>
        [JsonPropertyName("to")]
        public string To { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the text content of the message.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the subject of the message (if applicable).
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Gets or sets the list of media URLs to include in the message.
        /// </summary>
        [JsonPropertyName("media_urls")]
        public List<string>? MediaUrls { get; set; }

        /// <summary>
        /// Gets or sets the webhook URL for message status updates.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the failover webhook URL in case the primary webhook fails.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use the messaging profile's webhooks.
        /// Default is <c>true</c>.
        /// </summary>
        [JsonPropertyName("use_profile_webhooks")]
        public bool? UseProfileWebhooks { get; set; } = true;

        /// <summary>
        /// Gets or sets the type of message being sent (e.g., SMS, MMS).
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to auto-detect the message type.
        /// </summary>
        [JsonPropertyName("auto_detect")]
        public bool? AutoDetect { get; set; }
    }
}