using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Response model for retrieving a brand by brandId.
    /// </summary>
    public class GetBrandResponse : BaseBrandResponse, ITelnyxResponse
    {
        [JsonPropertyName("assignedCampaignsCount")]
        public int? AssignedCampaignsCount { get; set; }

        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }
}
