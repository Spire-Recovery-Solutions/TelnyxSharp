using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.BulkPhoneNumberCampaign.Responses
{
    /// <summary>
    /// Represents the response for assigning a messaging profile to a campaign.
    /// </summary>
    public class AssignMessagingProfileToCampaignResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier of the messaging profile.
        /// </summary>
        [JsonPropertyName("messagingProfileId")]
        public string MessagingProfileId { get; set; } = string.Empty;

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

        /// <summary>
        /// Gets or sets the task ID associated with the assignment process.
        /// </summary>
        [JsonPropertyName("taskId")]
        public string TaskId { get; set; } = string.Empty;
    }
}