using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class MessagingProfilesResponse : ITelnyxResponse
    {
        /// <summary>
        /// A list of messaging profiles.
        /// </summary>
        [JsonPropertyName("data")]
        public List<MessagingProfile>? Data { get; set; }

        /// <summary>
        /// Metadata about the pagination and results.
        /// </summary>
        [JsonPropertyName("meta")]
        public MessagingProfilesMeta? Meta { get; set; }

        /// <summary>
        /// List of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents a messaging profile.
    /// </summary>
    public class MessagingProfile
    {
        /// <summary>
        /// Identifies the type of resource.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; }

        /// <summary>
        /// The unique identifier of the messaging profile.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The user-friendly name of the messaging profile.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The primary webhook URL for the messaging profile.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// The failover webhook URL for the messaging profile.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Indicates whether the messaging profile is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The API version used for webhooks.
        /// </summary>
        [JsonPropertyName("webhook_api_version")]
        public string WebhookApiVersion { get; set; }

        /// <summary>
        /// The destinations allowed for the messaging profile.
        /// </summary>
        [JsonPropertyName("whitelisted_destinations")]
        public List<string>? WhitelistedDestinations { get; set; }

        /// <summary>
        /// The creation timestamp of the messaging profile.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The last update timestamp of the messaging profile.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The settings for the number pool.
        /// </summary>
        [JsonPropertyName("number_pool_settings")]
        public NumberPoolSettings? NumberPoolSettings { get; set; }

        /// <summary>
        /// The settings for the URL shortener.
        /// </summary>
        [JsonPropertyName("url_shortener_settings")]
        public UrlShortenerSettings? UrlShortenerSettings { get; set; }

        /// <summary>
        /// The v1 secret for authentication.
        /// </summary>
        [JsonPropertyName("v1_secret")]
        public string? V1Secret { get; set; }
    }

    /// <summary>
    /// Represents the number pool settings for a messaging profile.
    /// </summary>
    public class NumberPoolSettings
    {
        [JsonPropertyName("toll_free_weight")]
        public int TollFreeWeight { get; set; }

        [JsonPropertyName("long_code_weight")]
        public int LongCodeWeight { get; set; }

        [JsonPropertyName("skip_unhealthy")]
        public bool SkipUnhealthy { get; set; }

        [JsonPropertyName("sticky_sender")]
        public bool StickySender { get; set; }

        [JsonPropertyName("geomatch")]
        public bool Geomatch { get; set; }
    }

    /// <summary>
    /// Represents the URL shortener settings for a messaging profile.
    /// </summary>
    public class UrlShortenerSettings
    {
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        [JsonPropertyName("replace_blacklist_only")]
        public bool ReplaceBlacklistOnly { get; set; }

        [JsonPropertyName("send_webhooks")]
        public bool SendWebhooks { get; set; }
    }

    /// <summary>
    /// Represents metadata related to messaging profiles, including pagination details.
    /// </summary>
    public partial class MessagingProfilesMeta
    {
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
    }
}
