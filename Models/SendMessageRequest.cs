
using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public sealed class SendMessageRequest : ITelnyxRequest
    {
        /// <summary>
        /// Sending phone number
        /// </summary>
        [JsonPropertyName("from")] public string? From { get; set; }

        /// <summary>
        /// Receiving phone number
        /// </summary>
        [JsonPropertyName("to")] public string? To { get; set; }

        /// <summary>
        /// Id of the messaging profile settings to use
        /// </summary>
        [JsonPropertyName("messaging_profile_id")] public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Text content of the message
        /// </summary>
        [JsonPropertyName("text")] public string? Text { get; set; }

        /// <summary>
        /// Subject of the message (optional)
        /// </summary>
        [JsonPropertyName("subject")] public string?  Subject { get; set; }

        /// <summary>
        /// List of URLs for media to send (required for MMS)
        /// </summary>
        [JsonPropertyName("media_urls")] public List<string> MediaUrls { get; set; }

        /// <summary>
        /// The URL where webhooks related to this message will be sent.
        /// </summary>
        [JsonPropertyName("webhook_url")] public string?  WebhookUrl { get; set; }

        /// <summary>
        /// Webhook URL to use in case the primary URL fails.
        /// </summary>
        [JsonPropertyName("wekhook_failover_url")] public string?  WebhookFailoverUrl { get; set; }

        /// <summary>
        /// If the profile this number is associated with has webhooks, use them for delivery notifications. If webhooks are also specified on the message itself, they will be attempted first, then those on the profile.
        /// </summary>
        [JsonPropertyName("use_profile_webhooks")] public bool? UseProfileWebhooks { get; set; }

        /// <summary>
        /// SMS or MMS
        /// </summary>
        [JsonPropertyName("type")] public string? Type { get; set; }
    }
}
