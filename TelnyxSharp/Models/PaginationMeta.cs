using System.Text.Json.Serialization;

namespace TelnyxSharp.Models
{
    /// <summary>
    /// Represents metadata for paginated results in an API response.
    /// </summary>
    public class PaginationMeta
    {
        /// <summary>
        /// Gets or sets the total number of pages available in the result set.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or sets the total number of results available in the result set.
        /// </summary>
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        /// <summary>
        /// Gets or sets the current page number in the result set.
        /// </summary>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the number of results per page in the result set.
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
    }
}