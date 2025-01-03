using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for partner campaigns shared by the user.
    /// </summary>
    public class GetPartnerCampaignsSharedByUserResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the current page number in the paginated response.
        /// </summary>
        [JsonPropertyName("page")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the list of partner campaigns shared by the user.
        /// </summary>
        [JsonPropertyName("records")]
        public List<PartnerCampaignsSharedByUser>? Records { get; set; }

        /// <summary>
        /// Gets or sets the total number of records available.
        /// </summary>
        [JsonPropertyName("totalRecords")]
        public int TotalRecords { get; set; }

        /// <summary>
        /// Represents any validation errors encountered during the retrieval process.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }

    /// <summary>
    /// Represents the details of a partner campaign shared by the user.
    /// </summary>
    public class PartnerCampaignsSharedByUser
    {
        /// <summary>
        /// Gets or sets the brand ID associated with the shared campaign.
        /// </summary>
        [JsonPropertyName("brandId")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the campaign ID associated with the shared campaign.
        /// </summary>
        [JsonPropertyName("campaignId")]
        public string CampaignId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date when the campaign was created.
        /// </summary>
        [JsonPropertyName("createDate")]
        public string? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the current status of the shared campaign.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the use case associated with the shared campaign.
        /// </summary>
        [JsonPropertyName("usecase")]
        public string Usecase { get; set; } = string.Empty;
    }
}