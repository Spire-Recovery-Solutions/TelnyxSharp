using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the request model for listing campaigns associated with a specific brand.
    /// </summary>
    public class ListCampaignsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier of the brand for which campaigns are being listed.
        /// </summary>
        [JsonPropertyName("brandId")]
        public required string BrandId { get; set; }

        /// <summary>
        /// Gets or sets the page number for paginated results. Defaults to 1.
        /// </summary>
        [JsonPropertyName("page")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// Gets or sets the number of records per page in the paginated results. Defaults to 10.
        /// </summary>
        [JsonPropertyName("recordsPerPage")]
        public int PageSize  { get; set; } = 10;

        /// <summary>
        /// Gets or sets the sorting criteria for the campaign results.
        /// Defaults to descending order of creation date ("-createdAt").
        /// </summary>
        [JsonPropertyName("sort")]
        public Sort? Sort { get; set; } = Enums.Sort.CreatedAtDesc;
    }
}