using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.Campaign
{
    /// <summary>
    /// Represents the request payload for submitting a campaign to the Telnyx platform.
    /// </summary>
    public class SubmitCampaignRequest : ITelnyxRequest
    {
        /// <summary>
        /// Indicates whether the campaign includes affiliate marketing.
        /// </summary>
        [JsonPropertyName("affiliateMarketing")]
        public bool? AffiliateMarketing { get; set; }

        /// <summary>
        /// Indicates if the campaign has age-gated content.
        /// </summary>
        [JsonPropertyName("ageGated")]
        public bool? AgeGated { get; set; }

        /// <summary>
        /// Specifies whether the campaign has auto-renewal enabled.
        /// </summary>
        [JsonPropertyName("autoRenewal")]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// The unique identifier for the brand associated with the campaign.
        /// </summary>
        [JsonPropertyName("brandId")]
        public required string BrandId { get; set; }

        /// <summary>
        /// A detailed description of the campaign.
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; set; }

        /// <summary>
        /// Indicates if the campaign involves direct lending.
        /// </summary>
        [JsonPropertyName("directLending")]
        public bool? DirectLending { get; set; }

        /// <summary>
        /// Indicates if the campaign includes embedded links.
        /// </summary>
        [JsonPropertyName("embeddedLink")]
        public bool? EmbeddedLink { get; set; }

        /// <summary>
        /// Indicates if the campaign includes embedded phone numbers.
        /// </summary>
        [JsonPropertyName("embeddedPhone")]
        public bool? EmbeddedPhone { get; set; }

        /// <summary>
        /// Keywords used for help messages in the campaign.
        /// </summary>
        [JsonPropertyName("helpKeywords")]
        public string? HelpKeywords { get; set; }

        /// <summary>
        /// The help message content for the campaign.
        /// </summary>
        [JsonPropertyName("helpMessage")]
        public string? HelpMessage { get; set; }

        /// <summary>
        /// Describes the message flow for the campaign.
        /// </summary>
        [JsonPropertyName("messageFlow")]
        public string? MessageFlow { get; set; }

        /// <summary>
        /// A list of mobile network operator (MNO) IDs associated with the campaign.
        /// </summary>
        [JsonPropertyName("mnoIds")]
        public List<int>? MnoIds { get; set; }

        /// <summary>
        /// Specifies whether the campaign uses a number pool.
        /// </summary>
        [JsonPropertyName("numberPool")]
        public bool? NumberPool { get; set; }

        /// <summary>
        /// Keywords used for opt-in messages.
        /// </summary>
        [JsonPropertyName("optinKeywords")]
        public string? OptinKeywords { get; set; }

        /// <summary>
        /// The opt-in message content for the campaign.
        /// </summary>
        [JsonPropertyName("optinMessage")]
        public string? OptinMessage { get; set; }

        /// <summary>
        /// Keywords used for opt-out messages.
        /// </summary>
        [JsonPropertyName("optoutKeywords")]
        public string? OptoutKeywords { get; set; }

        /// <summary>
        /// The opt-out message content for the campaign.
        /// </summary>
        [JsonPropertyName("optoutMessage")]
        public string? OptoutMessage { get; set; }

        /// <summary>
        /// A reference ID for tracking the campaign.
        /// </summary>
        [JsonPropertyName("referenceId")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// The ID of the reseller associated with the campaign.
        /// </summary>
        [JsonPropertyName("resellerId")]
        public string? ResellerId { get; set; }

        /// <summary>
        /// Sample message 1 used in the campaign.
        /// </summary>
        [JsonPropertyName("sample1")]
        public string? Sample1 { get; set; }

        /// <summary>
        /// Sample message 2 used in the campaign.
        /// </summary>
        [JsonPropertyName("sample2")]
        public string? Sample2 { get; set; }

        /// <summary>
        /// Sample message 3 used in the campaign.
        /// </summary>
        [JsonPropertyName("sample3")]
        public string? Sample3 { get; set; }

        /// <summary>
        /// Sample message 4 used in the campaign.
        /// </summary>
        [JsonPropertyName("sample4")]
        public string? Sample4 { get; set; }

        /// <summary>
        /// Sample message 5 used in the campaign.
        /// </summary>
        [JsonPropertyName("sample5")]
        public string? Sample5 { get; set; }

        /// <summary>
        /// A list of sub-use cases for the campaign.
        /// </summary>
        [JsonPropertyName("subUsecases")]
        public List<string>? SubUsecases { get; set; }

        /// <summary>
        /// Indicates if the campaign supports subscriber help functionality.
        /// </summary>
        [JsonPropertyName("subscriberHelp")]
        public bool? SubscriberHelp { get; set; }

        /// <summary>
        /// Indicates if the campaign supports subscriber opt-in functionality.
        /// </summary>
        [JsonPropertyName("subscriberOptin")]
        public bool? SubscriberOptin { get; set; }

        /// <summary>
        /// Indicates if the campaign supports subscriber opt-out functionality.
        /// </summary>
        [JsonPropertyName("subscriberOptout")]
        public bool? SubscriberOptout { get; set; }

        /// <summary>
        /// A list of tags associated with the campaign.
        /// </summary>
        [JsonPropertyName("tag")]
        public List<string>? Tag { get; set; }

        /// <summary>
        /// Specifies whether the campaign requires terms and conditions acceptance.
        /// </summary>
        [JsonPropertyName("termsAndConditions")]
        public bool? TermsAndConditions { get; set; }

        /// <summary>
        /// A link to the privacy policy for the campaign.
        /// </summary>
        [JsonPropertyName("privacyPolicyLink")]
        public string? PrivacyPolicyLink { get; set; }

        /// <summary>
        /// A link to the terms and conditions for the campaign.
        /// </summary>
        [JsonPropertyName("termsAndConditionsLink")]
        public string? TermsAndConditionsLink { get; set; }

        /// <summary>
        /// A sample embedded link used in the campaign.
        /// </summary>
        [JsonPropertyName("embeddedLinkSample")]
        public string? EmbeddedLinkSample { get; set; }

        /// <summary>
        /// The primary use case for the campaign.
        /// </summary>
        [JsonPropertyName("usecase")]
        public required string Usecase { get; set; }

        /// <summary>
        /// The webhook URL to receive campaign-related events.
        /// </summary>
        [JsonPropertyName("webhookURL")]
        public string? WebhookURL { get; set; }

        /// <summary>
        /// A failover webhook URL to handle events when the primary URL fails.
        /// </summary>
        [JsonPropertyName("webhookFailoverURL")]
        public string? WebhookFailoverURL { get; set; }
    }
}