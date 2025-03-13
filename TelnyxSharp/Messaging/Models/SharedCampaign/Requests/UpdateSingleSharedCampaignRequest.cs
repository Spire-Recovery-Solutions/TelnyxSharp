using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.SharedCampaign.Requests
{
    /// <summary>
    /// Represents a request to update a single shared campaign.
    /// </summary>
    public class UpdateSingleSharedCampaignRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the primary webhook URL for the shared campaign.
        /// This URL is required and cannot be null.
        /// </summary>
        [JsonPropertyName("webhookURL")]
        public string WebhookURL { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the failover webhook URL for the shared campaign.
        /// This URL is required and cannot be null.
        /// </summary>
        [JsonPropertyName("webhookFailoverURL")]
        public string WebhookFailoverURL { get; set; } = string.Empty;
    }
}