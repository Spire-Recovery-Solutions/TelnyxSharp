using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from a Messaging Profile API call.
    /// </summary>
    public class CreateMessagingProfileResponse : ITelnyxResponse
    {
        /// <summary>
        /// The data containing the messaging profile details.
        /// </summary>
        [JsonPropertyName("data")]
        public MessagingProfileData? Data { get; set; }

        /// <summary>
        /// List of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains the details of a messaging profile.
    /// </summary>
    public class MessagingProfileData
    {
        /// <summary>
        /// The record type of the messaging profile.
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
        /// </summary>
        [JsonPropertyName("webhook_api_version")]
        public string WebhookApiVersion { get; set; } = string.Empty;

        /// <summary>
        /// A list of whitelisted destination phone numbers or prefixes.
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

        /// <summary>
        /// The alphanumeric sender ID for destinations that require it.
        /// </summary>
        [JsonPropertyName("alpha_sender")]
        public string? AlphaSender { get; set; }

        /// <summary>
        /// The maximum daily spend limit for the messaging profile in USD.
        /// </summary>
        [JsonPropertyName("daily_spend_limit")]
        public string DailySpendLimit { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether the daily spend limit is enforced.
        /// </summary>
        [JsonPropertyName("daily_spend_limit_enabled")]
        public bool DailySpendLimitEnabled { get; set; }
    }
}
