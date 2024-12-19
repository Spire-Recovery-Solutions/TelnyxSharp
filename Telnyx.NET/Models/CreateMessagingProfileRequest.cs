using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class CreateMessagingProfileRequest : ITelnyxRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; } = true;

        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        [JsonPropertyName("webhook_api_version")]
        public string WebhookApiVersion { get; set; } = "2";

        [JsonPropertyName("number_pool_settings")]
        public NumberPoolSettings? NumberPoolSettings { get; set; }

        [JsonPropertyName("url_shortener_settings")]
        public UrlShortenerSettings? UrlShortenerSettings { get; set; }

        [JsonPropertyName("whitelisted_destinations")]
        public List<string> WhitelistedDestinations { get; set; } = new();
    }
}
