using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the request body for updating a phone number campaign in the Telnyx system.
    /// </summary>
    public class UpdatePhoneNumberCampaignRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the phone number associated with the campaign.
        /// This property is required to update a phone number campaign.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the campaign ID for the phone number campaign.
        /// This property is required to update a phone number campaign.
        /// </summary>
        [JsonPropertyName("campaignId")]
        public required string CampaignId { get; set; }
    }
}