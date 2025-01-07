using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the request model for updating a campaign's details.
    /// </summary>
    public class UpdateCampaignRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the reseller ID associated with the campaign.
        /// </summary>
        [JsonPropertyName("resellerId")]
        public string? ResellerId { get; set; }

        /// <summary>
        /// Gets or sets the first sample message for the campaign.
        /// </summary>
        [JsonPropertyName("sample1")]
        public string? Sample1 { get; set; }

        /// <summary>
        /// Gets or sets the second sample message for the campaign.
        /// </summary>
        [JsonPropertyName("sample2")]
        public string? Sample2 { get; set; }

        /// <summary>
        /// Gets or sets the third sample message for the campaign.
        /// </summary>
        [JsonPropertyName("sample3")]
        public string? Sample3 { get; set; }

        /// <summary>
        /// Gets or sets the fourth sample message for the campaign.
        /// </summary>
        [JsonPropertyName("sample4")]
        public string? Sample4 { get; set; }

        /// <summary>
        /// Gets or sets the fifth sample message for the campaign.
        /// </summary>
        [JsonPropertyName("sample5")]
        public string? Sample5 { get; set; }

        /// <summary>
        /// Gets or sets the message flow for the campaign, describing how messages will be handled.
        /// </summary>
        [JsonPropertyName("messageFlow")]
        public string? MessageFlow { get; set; }

        /// <summary>
        /// Gets or sets the help message for the campaign.
        /// </summary>
        [JsonPropertyName("helpMessage")]
        public string? HelpMessage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the campaign will auto-renew.
        /// </summary>
        [JsonPropertyName("autoRenewal")]
        public bool AutoRenewal { get; set; }

        /// <summary>
        /// Gets or sets the primary webhook URL for the campaign.
        /// </summary>
        [JsonPropertyName("webhookURL")]
        public string? WebhookURL { get; set; }

        /// <summary>
        /// Gets or sets the failover webhook URL for the campaign.
        /// </summary>
        [JsonPropertyName("webhookFailoverURL")]
        public string? WebhookFailoverURL { get; set; }
    }
}