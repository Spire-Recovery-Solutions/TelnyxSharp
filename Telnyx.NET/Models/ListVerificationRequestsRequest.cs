using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the request model for listing verification requests.
    /// </summary>
    public class ListVerificationRequestsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the page number for pagination. Default value is 1.
        /// </summary>
        [JsonPropertyName("page")]
        public required int PageNumber { get; set; } = 1;

        /// <summary>
        /// Gets or sets the number of items per page for pagination. Default value is 10.
        /// </summary>
        [JsonPropertyName("page_size")]
        public required int PageSize { get; set; } = 10;

        /// <summary>
        /// Gets or sets the start date for filtering verification requests. This property is optional.
        /// </summary>
        [JsonPropertyName("date_start")]
        public DateTimeOffset? DateStart { get; set; }

        /// <summary>
        /// Gets or sets the end date for filtering verification requests. This property is optional.
        /// </summary>
        [JsonPropertyName("date_end")]
        public DateTimeOffset? DateEnd { get; set; }

        /// <summary>
        /// Gets or sets the status filter for verification requests. This property is optional.
        /// </summary>
        [JsonPropertyName("status")]
        public Status? Status { get; set; }

        /// <summary>
        /// Gets or sets the phone number filter for verification requests. This property is optional.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
    }
}