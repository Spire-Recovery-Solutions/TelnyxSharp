using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response model for listing campaigns associated with a specific brand.
    /// </summary>
    public class ListCampaignsResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the list of campaign records returned in the response.
        /// </summary>
        [JsonPropertyName("records")]
        public List<CampaignRecord>? Records { get; set; }

        /// <summary>
        /// Gets or sets the current page number in the paginated response.
        /// </summary>
        [JsonPropertyName("page")]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the total number of records available for the query.
        /// </summary>
        [JsonPropertyName("totalRecords")]
        public int TotalRecords { get; set; }

        /// <summary>
        /// Gets or sets a list of validation error details, if any, encountered during the retrieval of campaigns.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }

    /// <summary>
    /// Represents a single campaign record included in the list of campaigns.
    /// </summary>
    public class CampaignRecord : BaseCampaignResponse
    {
        /// <summary>
        /// Gets or sets the count of phone numbers assigned to this campaign.
        /// </summary>
        [JsonPropertyName("assignedPhoneNumbersCount")]
        public int AssignedPhoneNumbersCount { get; set; }
    }
}
