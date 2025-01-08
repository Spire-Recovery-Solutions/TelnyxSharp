using System.Text.Json.Serialization;

namespace Telnyx.NET.Messaging.Models.Campaign
{
    public class GetCampaignResponse : BaseCampaignResponse
    {
        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }
}
