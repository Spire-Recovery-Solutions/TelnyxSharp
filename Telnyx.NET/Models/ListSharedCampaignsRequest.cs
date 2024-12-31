using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class ListSharedCampaignsRequest : ITelnyxRequest
    {
        /// <summary>
        /// The number of records to return per page.
        /// </summary>
        [JsonPropertyName("recordsPerPage")]
        public int? PageSize  { get; set; }

        /// <summary>
        /// The page number to retrieve.
        /// </summary>
        [JsonPropertyName("page")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the results. Defaults to sorting by created date in descending order.
        /// </summary>
        [JsonPropertyName("sort")]
        public Sort Sort { get; set; } = Sort.CreatedAt;
    }
}
