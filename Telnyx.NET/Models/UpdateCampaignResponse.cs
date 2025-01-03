using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public class UpdateCampaignResponse : BaseCampaignResponse
    {
        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }
}
