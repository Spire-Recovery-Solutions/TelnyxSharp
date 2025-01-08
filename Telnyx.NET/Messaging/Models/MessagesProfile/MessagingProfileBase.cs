using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using Telnyx.NET.Messaging.Models.MessagesProfile.Responses;

namespace Telnyx.NET.Messaging.Models.MessagesProfile
{
    /// <summary>
    /// Represents the base structure for a messaging profile.
    /// </summary>
    public abstract class MessagingProfileBase
    {
        /// <summary>
        /// Gets or sets the record type for the messaging profile.
        /// </summary>
        [JsonPropertyName("record_type")]
        public MessageRecordType? RecordType { get; set; } = MessageRecordType.Unknown;

        /// <summary>
        /// Gets or sets the unique identifier for the messaging profile.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the messaging profile.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the messaging profile is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the webhook URL for message delivery.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the failover URL for webhook delivery in case the primary URL fails.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Gets or sets the API version for webhooks associated with the messaging profile.
        /// </summary>
        [JsonPropertyName("webhook_api_version")]
        public string WebhookApiVersion { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of whitelisted destination numbers for the messaging profile.
        /// </summary>
        [JsonPropertyName("whitelisted_destinations")]
        public List<string>? WhitelistedDestinations { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp for the messaging profile.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last updated timestamp for the messaging profile.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the number pool settings for the messaging profile.
        /// </summary>
        [JsonPropertyName("number_pool_settings")]
        public NumberPoolSettings? NumberPoolSettings { get; set; }

        /// <summary>
        /// Gets or sets the URL shortener settings for the messaging profile.
        /// </summary>
        [JsonPropertyName("url_shortener_settings")]
        public UrlShortenerSettings? UrlShortenerSettings { get; set; }

        /// <summary>
        /// Gets or sets the secret key for version 1 API integrations.
        /// </summary>
        [JsonPropertyName("v1_secret")]
        public string? V1Secret { get; set; }

        /// <summary>
        /// Gets or sets the alpha sender ID for the messaging profile.
        /// </summary>
        [JsonPropertyName("alpha_sender")]
        public string? AlphaSender { get; set; }

        /// <summary>
        /// Gets or sets the daily spend limit for the messaging profile.
        /// </summary>
        [JsonPropertyName("daily_spend_limit")]
        public string DailySpendLimit { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the daily spend limit is enabled.
        /// </summary>
        [JsonPropertyName("daily_spend_limit_enabled")]
        public bool DailySpendLimitEnabled { get; set; }
    }
}
