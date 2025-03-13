using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.BulkPhoneNumberCampaign.Requests
{
    /// <summary>
    /// Represents a request to assign a messaging profile to a campaign.
    /// </summary>
    public class AssignMessagingProfileToCampaignRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier of the messaging profile.
        /// This field is required.
        /// </summary>
        [JsonPropertyName("messagingProfileId")]
        public required string MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the TCR campaign ID associated with the assignment.
        /// </summary>
        [JsonPropertyName("tcrCampaignId")]
        public string? TcrCampaignId { get; set; }

        /// <summary>
        /// Gets or sets the campaign ID associated with the assignment.
        /// </summary>
        [JsonPropertyName("campaignId")]
        public string? CampaignId { get; set; }
    }
}