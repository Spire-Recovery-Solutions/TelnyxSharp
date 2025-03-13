using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.PhoneNumberCampaign.Requests
{
    /// <summary>
    /// Represents the request body for creating a phone number campaign in the Telnyx system.
    /// </summary>
    public class CreatePhoneNumberCampaignRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the phone number associated with the campaign.
        /// This property is required to create a phone number campaign.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the campaign ID for the phone number campaign.
        /// This property is required to create a phone number campaign.
        /// </summary>
        [JsonPropertyName("campaignId")]
        public required string CampaignId { get; set; }
    }
}