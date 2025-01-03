using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class CreatePhoneNumberCampaignResponse : BasePhoneNumberCampaigns
    {
        /// <summary>
        /// List of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }
}
