using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for retrieving a messaging profile.
    /// </summary>
    public class RetrieveMessagingProfileResponse : ITelnyxResponse
    {
        /// <summary>
        /// The data containing the details of the messaging profile.
        /// </summary>
        [JsonPropertyName("data")]
        public MessagingProfileData? Data { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// This property is nullable to indicate that it may not always be present.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains details of the messaging profile.
    /// </summary>
    public class RetrieveMessagingProfileData
    {
        /// <summary>
        /// The record type of the messaging profile.
        /// Possible values: "messaging_profile".
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier of the messaging profile.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The name of the messaging profile.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether the messaging profile is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The primary webhook URL for message delivery notifications.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// The failover webhook URL for message delivery notifications.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        /// <summary>
        /// The API version used for webhooks.
        /// Possible values: "1", "2", "2010-04-01".
        /// </summary>
        [JsonPropertyName("webhook_api_version")]
        public string WebhookApiVersion { get; set; } = string.Empty;

        /// <summary>
        /// List of whitelisted destination country codes (ISO 3166-1 alpha-2).
        /// </summary>
        [JsonPropertyName("whitelisted_destinations")]
        public List<string> WhitelistedDestinations { get; set; } = new();

        /// <summary>
        /// The date and time when the messaging profile was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the messaging profile was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The secret used to authenticate with v1 endpoints.
        /// </summary>
        [JsonPropertyName("v1_secret")]
        public string V1Secret { get; set; } = string.Empty;

        /// <summary>
        /// Settings related to the number pool feature.
        /// </summary>
        [JsonPropertyName("number_pool_settings")]
        public NumberPoolSettings? NumberPoolSettings { get; set; }

        /// <summary>
        /// Settings related to the URL shortener feature.
        /// </summary>
        [JsonPropertyName("url_shortener_settings")]
        public UrlShortenerSettings? UrlShortenerSettings { get; set; }
    }
}
