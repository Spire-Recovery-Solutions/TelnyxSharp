using System.Text.Json.Serialization;
using TelnyxSharp.Enums;
using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.SharedCampaign
{
    /// <summary>
    /// Represents the base properties shared by campaigns in the Telnyx system.
    /// </summary>
    public abstract class BaseSharedCampaigns : TelnyxResponse
    {
        /// <summary>
        /// Indicates whether age gating is enabled for the campaign.
        /// </summary>
        [JsonPropertyName("ageGated")]
        public bool? AgeGated { get; set; }

        /// <summary>
        /// The number of phone numbers assigned to the campaign.
        /// </summary>
        [JsonPropertyName("assignedPhoneNumbersCount")]
        public int? AssignedPhoneNumbersCount { get; set; }

        /// <summary>
        /// The display name of the brand associated with the campaign.
        /// </summary>
        [JsonPropertyName("brandDisplayName")]
        public string? BrandDisplayName { get; set; }

        /// <summary>
        /// The current status of the campaign.
        /// </summary>
        [JsonPropertyName("campaignStatus")]
        public CampaignStatus? CampaignStatus { get; set; }

        /// <summary>
        /// The description of the campaign.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether direct lending is enabled for the campaign.
        /// </summary>
        [JsonPropertyName("directLending")]
        public bool? DirectLending { get; set; }

        /// <summary>
        /// Indicates whether embedded links are supported in campaign messages.
        /// </summary>
        [JsonPropertyName("embeddedLink")]
        public bool? EmbeddedLink { get; set; }

        /// <summary>
        /// A sample embedded link for the campaign.
        /// </summary>
        [JsonPropertyName("embeddedLinkSample")]
        public string? EmbeddedLinkSample { get; set; }

        /// <summary>
        /// Indicates whether embedded phone numbers are supported in campaign messages.
        /// </summary>
        [JsonPropertyName("embeddedPhone")]
        public bool? EmbeddedPhone { get; set; }

        /// <summary>
        /// The reasons for any campaign failures.
        /// </summary>
        [JsonPropertyName("failureReasons")]
        public List<string>? FailureReasons { get; set; }

        /// <summary>
        /// Keywords for accessing help within the campaign.
        /// </summary>
        [JsonPropertyName("helpKeywords")]
        public string? HelpKeywords { get; set; }

        /// <summary>
        /// The help message associated with the campaign.
        /// </summary>
        [JsonPropertyName("helpMessage")]
        public string? HelpMessage { get; set; }

        /// <summary>
        /// Indicates whether number pooling is enabled for the campaign.
        /// </summary>
        [JsonPropertyName("isNumberPoolingEnabled")]
        public bool? IsNumberPoolingEnabled { get; set; }

        /// <summary>
        /// The message flow details for the campaign.
        /// </summary>
        [JsonPropertyName("messageFlow")]
        public string? MessageFlow { get; set; }

        /// <summary>
        /// Indicates whether the campaign uses a number pool.
        /// </summary>
        [JsonPropertyName("numberPool")]
        public bool? NumberPool { get; set; }

        /// <summary>
        /// Keywords for opt-in actions within the campaign.
        /// </summary>
        [JsonPropertyName("optinKeywords")]
        public string? OptinKeywords { get; set; }

        /// <summary>
        /// The opt-in message associated with the campaign.
        /// </summary>
        [JsonPropertyName("optinMessage")]
        public string? OptinMessage { get; set; }

        /// <summary>
        /// Keywords for opt-out actions within the campaign.
        /// </summary>
        [JsonPropertyName("optoutKeywords")]
        public string? OptoutKeywords { get; set; }

        /// <summary>
        /// The opt-out message associated with the campaign.
        /// </summary>
        [JsonPropertyName("optoutMessage")]
        public string? OptoutMessage { get; set; }

        /// <summary>
        /// The link to the privacy policy associated with the campaign.
        /// </summary>
        [JsonPropertyName("privacyPolicyLink")]
        public string? PrivacyPolicyLink { get; set; }

        /// <summary>
        /// The primary use case for the campaign.
        /// </summary>
        [JsonPropertyName("usecase")]
        public string? Usecase { get; set; }

        /// <summary>
        /// The first sample message for the campaign.
        /// </summary>
        [JsonPropertyName("sample1")]
        public string? Sample1 { get; set; }

        /// <summary>
        /// The second sample message for the campaign.
        /// </summary>
        [JsonPropertyName("sample2")]
        public string? Sample2 { get; set; }

        /// <summary>
        /// The third sample message for the campaign.
        /// </summary>
        [JsonPropertyName("sample3")]
        public string? Sample3 { get; set; }

        /// <summary>
        /// The fourth sample message for the campaign.
        /// </summary>
        [JsonPropertyName("sample4")]
        public string? Sample4 { get; set; }

        /// <summary>
        /// The fifth sample message for the campaign.
        /// </summary>
        [JsonPropertyName("sample5")]
        public string? Sample5 { get; set; }

        /// <summary>
        /// The sub-use cases for the campaign.
        /// </summary>
        [JsonPropertyName("subUsecases")]
        public string[]? SubUsecases { get; set; }

        /// <summary>
        /// Indicates whether subscriber opt-in is required.
        /// </summary>
        [JsonPropertyName("subscriberOptin")]
        public bool? SubscriberOptin { get; set; }

        /// <summary>
        /// Indicates whether subscriber opt-out is required.
        /// </summary>
        [JsonPropertyName("subscriberOptout")]
        public bool? SubscriberOptout { get; set; }

        /// <summary>
        /// The Telnyx Campaign Registry (TCR) brand ID.
        /// </summary>
        [JsonPropertyName("tcrBrandId")]
        public string TcrBrandId { get; set; } = string.Empty;

        /// <summary>
        /// The Telnyx Campaign Registry (TCR) campaign ID.
        /// </summary>
        [JsonPropertyName("tcrCampaignId")]
        public string TcrCampaignId { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether terms and conditions are required.
        /// </summary>
        [JsonPropertyName("termsAndConditions")]
        public bool? TermsAndConditions { get; set; }

        /// <summary>
        /// The link to the terms and conditions for the campaign.
        /// </summary>
        [JsonPropertyName("termsAndConditionsLink")]
        public string? TermsAndConditionsLink { get; set; }

        /// <summary>
        /// The primary webhook URL for the campaign.
        /// </summary>
        [JsonPropertyName("webhookURL")]
        public string? WebhookURL { get; set; }

        /// <summary>
        /// The failover webhook URL for the campaign.
        /// </summary>
        [JsonPropertyName("webhookFailoverURL")]
        public string? WebhookFailoverURL { get; set; }

        /// <summary>
        /// The creation timestamp of the campaign.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The last updated timestamp of the campaign.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}