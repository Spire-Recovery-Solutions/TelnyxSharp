using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents a request to retrieve phone number campaigns based on specific filters and pagination parameters.
    /// </summary>
    public class RetrievePhoneNumberCampaignsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of records to retrieve per page.
        /// </summary>
        [JsonPropertyName("recordsPerPage")]
        public int? RecordsPerPage { get; set; }

        /// <summary>
        /// Gets or sets the page number for paginated results.
        /// </summary>
        [JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx campaign ID to filter the campaigns.
        /// </summary>
        [JsonPropertyName("filter[telnyx_campaign_id]")]
        public string? FilterTelnyxCampaignId { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx brand ID to filter the campaigns.
        /// </summary>
        [JsonPropertyName("filter[telnyx_brand_id]")]
        public string? FilterTelnyxBrandId { get; set; }

        /// <summary>
        /// Gets or sets the TCR (The Campaign Registry) campaign ID to filter the campaigns.
        /// </summary>
        [JsonPropertyName("filter[tcr_campaign_id]")]
        public string? FilterTcrCampaignId { get; set; }

        /// <summary>
        /// Gets or sets the TCR brand ID to filter the campaigns.
        /// </summary>
        [JsonPropertyName("filter[tcr_brand_id]")]
        public string? FilterTcrBrandId { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the campaigns. Default is by creation date in descending order.
        /// </summary>
        [JsonPropertyName("sort")]
        public string? Sort { get; set; } = "-createdAt";
    }
}