using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents a request to update a messaging profile using the Telnyx API.
    /// </summary>
    public class UpdateMessagingProfileRequest : ITelnyxRequest
    {
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
        /// Gets or sets the primary webhook URL for message callbacks.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the failover webhook URL for message callbacks in case the primary webhook fails.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Gets or sets the API version to use for webhook callbacks.
        /// </summary>
        [JsonPropertyName("webhook_api_version")]
        public string WebhookApiVersion { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of whitelisted destination phone numbers.
        /// </summary>
        [JsonPropertyName("whitelisted_destinations")]
        public List<string> WhitelistedDestinations { get; set; } = new();

        /// <summary>
        /// Gets or sets the v1 secret for authenticating webhook requests.
        /// </summary>
        [JsonPropertyName("v1_secret")]
        public string V1Secret { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the settings for the number pool associated with the messaging profile.
        /// </summary>
        [JsonPropertyName("number_pool_settings")]
        public NumberPoolSettings? NumberPoolSettings { get; set; }

        /// <summary>
        /// Gets or sets the settings for the URL shortener associated with the messaging profile.
        /// </summary>
        [JsonPropertyName("url_shortener_settings")]
        public UrlShortenerSettings? UrlShortenerSettings { get; set; }

        /// <summary>
        /// Gets or sets the alpha sender ID used for sending messages.
        /// </summary>
        [JsonPropertyName("alpha_sender")]
        public string? AlphaSender { get; set; }

        /// <summary>
        /// Gets or sets the daily spend limit for the messaging profile.
        /// </summary>
        [JsonPropertyName("daily_spend_limit")]
        public string DailySpendLimit { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether the daily spend limit is enforced.
        /// </summary>
        [JsonPropertyName("daily_spend_limit_enabled")]
        public bool DailySpendLimitEnabled { get; set; }
    }
}