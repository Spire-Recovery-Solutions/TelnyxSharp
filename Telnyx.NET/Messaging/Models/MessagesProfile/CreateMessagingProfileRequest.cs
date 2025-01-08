using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.MessagesProfile
{
    /// <summary>
    /// Represents a request to create a new messaging profile in the Telnyx API.
    /// </summary>
    public class CreateMessagingProfileRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the name of the messaging profile. This property is required.
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the messaging profile is enabled. Defaults to true.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// Gets or sets the primary webhook URL for message delivery.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the failover webhook URL, used if the primary webhook fails.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Gets or sets the API version used for webhook callbacks. Default is version 2.
        /// </summary>
        [JsonPropertyName("webhook_api_version")]
        public string WebhookApiVersion { get; set; } = "2";

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
        /// Gets or sets the list of whitelisted destinations for the messaging profile. This property is required.
        /// </summary>
        [JsonPropertyName("whitelisted_destinations")]
        public required List<string> WhitelistedDestinations { get; set; }
    }
}