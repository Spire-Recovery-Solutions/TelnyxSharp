using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response containing a list of short codes associated with a messaging profile.
    /// </summary>
    public class MessagingProfileShortCodeResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the list of short codes associated with the messaging profile.
        /// </summary>
        [JsonPropertyName("data")]
        public List<MessagingProfileShortCode>? Data { get; set; }

        /// <summary>
        /// Gets or sets metadata about the response, such as pagination information.
        /// </summary>
        [JsonPropertyName("meta")]
        public MessagingProfileShortCodeMeta? Meta { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// This property is nullable to indicate that it may not always be present.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents a short code associated with a messaging profile.
    /// </summary>
    public class MessagingProfileShortCode
    {
        /// <summary>
        /// Gets or sets the record type for the short code.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the short code.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the short digit sequence used to address messages.
        /// </summary>
        [JsonPropertyName("short_code")]
        public string ShortCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ISO 3166-1 alpha-2 country code for the short code.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the messaging profile ID associated with the short code.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the short code was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the short code was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents metadata about the messaging profile short code response, such as pagination details.
    /// </summary>
    public class MessagingProfileShortCodeMeta
    {
        /// <summary>
        /// Gets or sets the total number of pages available in the response.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or sets the total number of results available.
        /// </summary>
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        /// <summary>
        /// Gets or sets the current page number in the response.
        /// </summary>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the size of the page (number of items per page).
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
    }

}
