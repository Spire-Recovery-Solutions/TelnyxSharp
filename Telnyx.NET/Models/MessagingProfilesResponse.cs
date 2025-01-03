using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public class MessagingProfilesResponse : TelnyxResponse
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
        public PaginationMeta? Meta { get; set; }

        /// <summary>
        /// List of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents a messaging profile.
    /// </summary>
    public class MessagingProfile : MessagingProfileBase
    {
    }

    /// <summary>
    /// Represents the number pool settings for a messaging profile.
    /// </summary>
    public class NumberPoolSettings
    {
        [JsonPropertyName("toll_free_weight")]
        public required int TollFreeWeight { get; set; }

        [JsonPropertyName("long_code_weight")]
        public required int LongCodeWeight { get; set; }

        [JsonPropertyName("skip_unhealthy")]
        public required bool SkipUnhealthy { get; set; }

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
        public required string Domain { get; set; }

        [JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        [JsonPropertyName("replace_blacklist_only")]
        public bool ReplaceBlacklistOnly { get; set; }

        [JsonPropertyName("send_webhooks")]
        public bool SendWebhooks { get; set; }
    }

   
}
