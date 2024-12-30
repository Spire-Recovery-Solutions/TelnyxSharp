using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class ListSharedCampaignsRequest : ITelnyxRequest
    {
        /// <summary>
        /// The number of records to return per page.
        /// </summary>
        [JsonPropertyName("recordsPerPage")]
        public int? RecordsPerPage { get; set; }

        /// <summary>
        /// The page number to retrieve.
        /// </summary>
        [JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the results. Defaults to sorting by created date in descending order.
        /// </summary>
        [JsonPropertyName("sort")]
        public string Sort { get; set; } = "-createdAt";
    }
}
