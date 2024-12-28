using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response containing cost details for a campaign based on its use case.
    /// </summary>
    public class GetCampaignCostResponse : ITelnyxResponse
    {
        /// <summary>
        /// Specifies the use case for the campaign, defining its purpose or type.
        /// </summary>
        [JsonPropertyName("campaignUsecase")]
        public string CampaignUsecase { get; set; } = string.Empty;

        /// <summary>
        /// The monthly recurring cost associated with the campaign as a string.
        /// </summary>
        [JsonPropertyName("monthlyCost")]
        public string MonthlyCost { get; set; } = string.Empty;

        /// <summary>
        /// The one-time upfront cost required for setting up the campaign as a string.
        /// </summary>
        [JsonPropertyName("upFrontCost")]
        public string UpFrontCost { get; set; } = string.Empty;

        /// <summary>
        /// A description providing additional context about the campaign.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// A collection of validation error details encountered during the cost retrieval process.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }
}