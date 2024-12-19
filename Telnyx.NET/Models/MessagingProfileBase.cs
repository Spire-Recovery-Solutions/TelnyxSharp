using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public abstract class MessagingProfileBase
    {
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        [JsonPropertyName("webhook_api_version")]
        public string WebhookApiVersion { get; set; } = string.Empty;

        [JsonPropertyName("whitelisted_destinations")]
        public List<string>? WhitelistedDestinations { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("number_pool_settings")]
        public NumberPoolSettings? NumberPoolSettings { get; set; }

        [JsonPropertyName("url_shortener_settings")]
        public UrlShortenerSettings? UrlShortenerSettings { get; set; }

        [JsonPropertyName("v1_secret")]
        public string? V1Secret { get; set; }

        [JsonPropertyName("alpha_sender")]
        public string? AlphaSender { get; set; }

        [JsonPropertyName("daily_spend_limit")]
        public string DailySpendLimit { get; set; } = string.Empty;

        [JsonPropertyName("daily_spend_limit_enabled")]
        public bool DailySpendLimitEnabled { get; set; }
    }
}
