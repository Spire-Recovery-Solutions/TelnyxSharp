using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.PhoneNumberCampaign
{
    /// <summary>
    /// Represents the base model for phone number campaigns, containing common properties that all campaigns share.
    /// </summary>
    public abstract class BasePhoneNumberCampaigns : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the phone number associated with the campaign.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the brand ID associated with the campaign, if available.
        /// </summary>
        [JsonPropertyName("brandId")]
        public string? BrandId { get; set; }

        /// <summary>
        /// Gets or sets the TCR (The Campaign Registry) brand ID associated with the campaign, if available.
        /// </summary>
        [JsonPropertyName("tcrBrandId")]
        public string? TcrBrandId { get; set; }

        /// <summary>
        /// Gets or sets the campaign ID associated with the phone number campaign.
        /// </summary>
        [JsonPropertyName("campaignId")]
        public string CampaignId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the TCR campaign ID associated with the phone number campaign, if available.
        /// </summary>
        [JsonPropertyName("tcrCampaignId")]
        public string? TcrCampaignId { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx campaign ID associated with the phone number campaign, if available.
        /// </summary>
        [JsonPropertyName("telnyxCampaignId")]
        public string? TelnyxCampaignId { get; set; }

        /// <summary>
        /// Gets or sets the assignment status of the phone number campaign.
        /// </summary>
        [JsonPropertyName("assignmentStatus")]
        public string? AssignmentStatus { get; set; }

        /// <summary>
        /// Gets or sets the list of failure reasons associated with the campaign, if any.
        /// </summary>
        [JsonPropertyName("failureReasons")]
        public List<string>? FailureReasons { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp of the phone number campaign.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last update timestamp of the phone number campaign.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}