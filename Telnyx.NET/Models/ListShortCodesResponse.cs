using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for a request to list short codes.
    /// </summary>
    public class ListShortCodesResponse : ITelnyxResponse
    {
        /// <summary>
        /// The list of short codes returned by the request.
        /// </summary>
        [JsonPropertyName("data")]
        public List<ShortCode>? Data { get; set; }

        /// <summary>
        /// Metadata related to the pagination of the short codes list.
        /// </summary>
        [JsonPropertyName("meta")]
        public ListShortCodesMeta? Meta { get; set; }

        /// <summary>
        /// Represents any errors encountered during the message sending process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents a single short code.
    /// </summary>
    public class ShortCode
    {
        /// <summary>
        /// The type of the resource record.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier of the short code.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The short code value (e.g., a 5- or 6-digit number).
        /// </summary>
        [JsonPropertyName("short_code")]
        public string ShortCodeValue { get; set; } = string.Empty;

        /// <summary>
        /// The country code associated with the short code.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier of the messaging profile associated with this short code.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// The date and time when the short code was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the short code was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents metadata for the list of short codes, including pagination details.
    /// </summary>
    public class ListShortCodesMeta
    {
        /// <summary>
        /// The total number of pages available.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// The total number of results available.
        /// </summary>
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        /// <summary>
        /// The current page number in the results.
        /// </summary>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// The number of results per page.
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
    }
}
