using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public class GetPhoneNumberCampaignResponse : BasePhoneNumberCampaigns
    {
        /// <summary>
        /// List of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }
}
