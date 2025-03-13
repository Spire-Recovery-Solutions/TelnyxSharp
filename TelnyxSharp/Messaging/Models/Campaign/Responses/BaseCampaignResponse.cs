using System.Text.Json.Serialization;
using TelnyxSharp.Enums;
using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.Campaign.Responses
{
    /// <summary>
    /// Represents the base response for a campaign, including its details, settings, and status.
    /// </summary>
    public abstract class BaseCampaignResponse : TelnyxResponse
    {
        /// <summary>
        /// Indicates whether age-gating is enabled for the campaign.
        /// </summary>
        [JsonPropertyName("ageGated")]
        public bool AgeGated { get; set; }

        /// <summary>
        /// Indicates whether the campaign is set to auto-renew.
        /// </summary>
        [JsonPropertyName("autoRenewal")]
        public bool AutoRenewal { get; set; }

        /// <summary>
        /// The date when the campaign was last billed.
        /// </summary>
        [JsonPropertyName("billedDate")]
        public string? BilledDate { get; set; }

        /// <summary>
        /// The ID of the associated brand.
        /// </summary>
        [JsonPropertyName("brandId")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// The display name of the brand associated with the campaign.
        /// </summary>
        [JsonPropertyName("brandDisplayName")]
        public string? BrandDisplayName { get; set; }

        /// <summary>
        /// The unique identifier of the campaign.
        /// </summary>
        [JsonPropertyName("campaignId")]
        public string CampaignId { get; set; } = string.Empty;

        /// <summary>
        /// The TCR (The Campaign Registry) brand ID.
        /// </summary>
        [JsonPropertyName("tcrBrandId")]
        public string? TcrBrandId { get; set; }

        /// <summary>
        /// The TCR (The Campaign Registry) campaign ID.
        /// </summary>
        [JsonPropertyName("tcrCampaignId")]
        public string? TcrCampaignId { get; set; }

        /// <summary>
        /// The date the campaign was created.
        /// </summary>
        [JsonPropertyName("createDate")]
        public string? CreateDate { get; set; }

        /// <summary>
        /// The ID of the CSP (Campaign Service Provider) managing the campaign.
        /// </summary>
        [JsonPropertyName("cspId")]
        public string CspId { get; set; } = string.Empty;

        /// <summary>
        /// A description of the campaign.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether direct lending is involved in the campaign.
        /// </summary>
        [JsonPropertyName("directLending")]
        public bool DirectLending { get; set; }

        /// <summary>
        /// Indicates if the campaign uses embedded links.
        /// </summary>
        [JsonPropertyName("embeddedLink")]
        public bool EmbeddedLink { get; set; }

        /// <summary>
        /// Indicates if the campaign uses embedded phone numbers.
        /// </summary>
        [JsonPropertyName("embeddedPhone")]
        public bool EmbeddedPhone { get; set; }

        /// <summary>
        /// Keywords used to provide help to subscribers.
        /// </summary>
        [JsonPropertyName("helpKeywords")]
        public string? HelpKeywords { get; set; }

        /// <summary>
        /// The help message for subscribers.
        /// </summary>
        [JsonPropertyName("helpMessage")]
        public string? HelpMessage { get; set; }

        /// <summary>
        /// Details about the message flow for the campaign.
        /// </summary>
        [JsonPropertyName("messageFlow")]
        public string? MessageFlow { get; set; }

        /// <summary>
        /// Indicates if the campaign is in mock mode for testing purposes.
        /// </summary>
        [JsonPropertyName("mock")]
        public bool Mock { get; set; }

        /// <summary>
        /// The next renewal or expiration date for the campaign.
        /// </summary>
        [JsonPropertyName("nextRenewalOrExpirationDate")]
        public string? NextRenewalOrExpirationDate { get; set; }

        /// <summary>
        /// Indicates whether the campaign uses a number pool.
        /// </summary>
        [JsonPropertyName("numberPool")]
        public bool NumberPool { get; set; }

        /// <summary>
        /// Keywords used for subscribers to opt-in.
        /// </summary>
        [JsonPropertyName("optinKeywords")]
        public string? OptinKeywords { get; set; }

        /// <summary>
        /// The opt-in message for subscribers.
        /// </summary>
        [JsonPropertyName("optinMessage")]
        public string? OptinMessage { get; set; }

        /// <summary>
        /// Keywords used for subscribers to opt-out.
        /// </summary>
        [JsonPropertyName("optoutKeywords")]
        public string? OptoutKeywords { get; set; }

        /// <summary>
        /// The opt-out message for subscribers.
        /// </summary>
        [JsonPropertyName("optoutMessage")]
        public string? OptoutMessage { get; set; }

        /// <summary>
        /// An optional reference ID associated with the campaign.
        /// </summary>
        [JsonPropertyName("referenceId")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// The ID of the reseller managing the campaign.
        /// </summary>
        [JsonPropertyName("resellerId")]
        public string? ResellerId { get; set; }

        /// <summary>
        /// Sample message 1 for the campaign.
        /// </summary>
        [JsonPropertyName("sample1")]
        public string? Sample1 { get; set; }

        /// <summary>
        /// Sample message 2 for the campaign.
        /// </summary>
        [JsonPropertyName("sample2")]
        public string? Sample2 { get; set; }

        /// <summary>
        /// Sample message 3 for the campaign.
        /// </summary>
        [JsonPropertyName("sample3")]
        public string? Sample3 { get; set; }

        /// <summary>
        /// Sample message 4 for the campaign.
        /// </summary>
        [JsonPropertyName("sample4")]
        public string? Sample4 { get; set; }

        /// <summary>
        /// Sample message 5 for the campaign.
        /// </summary>
        [JsonPropertyName("sample5")]
        public string? Sample5 { get; set; }

        /// <summary>
        /// The current status of the campaign.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// A list of sub-use cases associated with the campaign.
        /// </summary>
        [JsonPropertyName("subUsecases")]
        public List<string> SubUsecases { get; set; } = new();

        /// <summary>
        /// Indicates if subscriber help is supported.
        /// </summary>
        [JsonPropertyName("subscriberHelp")]
        public bool SubscriberHelp { get; set; }

        /// <summary>
        /// Indicates if subscriber opt-in is supported.
        /// </summary>
        [JsonPropertyName("subscriberOptin")]
        public bool SubscriberOptin { get; set; }

        /// <summary>
        /// Indicates if subscriber opt-out is supported.
        /// </summary>
        [JsonPropertyName("subscriberOptout")]
        public bool SubscriberOptout { get; set; }

        /// <summary>
        /// Indicates if terms and conditions are applicable.
        /// </summary>
        [JsonPropertyName("termsAndConditions")]
        public bool TermsAndConditions { get; set; }

        /// <summary>
        /// The primary use case of the campaign.
        /// </summary>
        [JsonPropertyName("usecase")]
        public string UseCase { get; set; } = string.Empty;

        /// <summary>
        /// The URL for campaign webhooks.
        /// </summary>
        [JsonPropertyName("webhookURL")]
        public string? WebhookURL { get; set; }

        /// <summary>
        /// The failover URL for campaign webhooks.
        /// </summary>
        [JsonPropertyName("webhookFailoverURL")]
        public string? WebhookFailoverURL { get; set; }

        /// <summary>
        /// Indicates if the campaign is registered with T-Mobile.
        /// </summary>
        [JsonPropertyName("isTMobileRegistered")]
        public bool IsTMobileRegistered { get; set; }

        /// <summary>
        /// Indicates if the campaign is suspended by T-Mobile.
        /// </summary>
        [JsonPropertyName("isTMobileSuspended")]
        public bool IsTMobileSuspended { get; set; }

        /// <summary>
        /// Indicates if number pooling is enabled for T-Mobile.
        /// </summary>
        [JsonPropertyName("isTMobileNumberPoolingEnabled")]
        public bool IsTMobileNumberPoolingEnabled { get; set; }

        /// <summary>
        /// A list of reasons for campaign failure, if any.
        /// </summary>
        [JsonPropertyName("failureReasons")]
        public List<string>? FailureReasons { get; set; }

        /// <summary>
        /// The submission status of the campaign.
        /// </summary>
        [JsonPropertyName("submissionStatus")]
        public string? SubmissionStatus { get; set; }

        /// <summary>
        /// The overall status of the campaign.
        /// </summary>
        [JsonPropertyName("campaignStatus")]
        public CampaignStatus? CampaignStatus { get; set; }

        /// <summary>
        /// The link to the campaign's privacy policy.
        /// </summary>
        [JsonPropertyName("privacyPolicyLink")]
        public string? PrivacyPolicyLink { get; set; }

        /// <summary>
        /// The link to the campaign's terms and conditions.
        /// </summary>
        [JsonPropertyName("termsAndConditionsLink")]
        public string? TermsAndConditionsLink { get; set; }

        /// <summary>
        /// A sample of an embedded link used in the campaign.
        /// </summary>
        [JsonPropertyName("embeddedLinkSample")]
        public string? EmbeddedLinkSample { get; set; }
    }
}