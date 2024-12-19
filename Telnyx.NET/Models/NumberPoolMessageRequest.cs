using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents a request to send a message using a number pool via the Telnyx API.
    /// </summary>
    public class NumberPoolMessageRequest : ITelnyxRequest
    {
        /// <summary>
        /// Unique identifier for a messaging profile. This field is required.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string MessagingProfileId { get; set; } // Required

        /// <summary>
        /// List of recipient phone numbers in +E.164 format. This field is required.
        /// </summary>
        [JsonPropertyName("to")]
        public List<string> To { get; set; } // Required

        /// <summary>
        /// The message body (content) as a non-empty string. Required for SMS messages.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } // Required for SMS

        /// <summary>
        /// Subject of the multimedia message. Required for MMS messages.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; } // Required for MMS

        /// <summary>
        /// A list of media URLs for multimedia messages. The total media size must be less than 1 MB.
        /// Required for MMS messages.
        /// </summary>
        [JsonPropertyName("media_urls")]
        public List<string> MediaUrls { get; set; } // Required for MMS

        /// <summary>
        /// The URL where webhooks related to this message will be sent.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// The failover URL where webhooks related to this message will be sent if sending to the primary URL fails.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Indicates whether to use webhooks associated with the messaging profile for delivery notifications.
        /// Defaults to true.
        /// </summary>
        [JsonPropertyName("use_profile_webhooks")]
        public bool? UseProfileWebhooks { get; set; } = true;

        /// <summary>
        /// The protocol for sending the message. Possible values are "SMS" or "MMS".
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } // Possible values: SMS, MMS

        /// <summary>
        /// Automatically detect if an SMS message is unusually long and exceeds the recommended limit of message parts.
        /// </summary>
        [JsonPropertyName("auto_detect")]
        public bool? AutoDetect { get; set; }
    }
}