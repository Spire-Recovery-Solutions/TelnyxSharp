using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class MessagingProfileMetricsResponse : ITelnyxResponse
    {
        /// <summary>
        /// List of metrics for messaging profiles.
        /// </summary>
        [JsonPropertyName("data")]
        public List<MessagingProfileMetricsData>? Data { get; set; }

        /// <summary>
        /// Metadata for pagination and result details.
        /// </summary>
        [JsonPropertyName("meta")]
        public MessagingProfileMetricsMeta? Meta { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    public class MessagingProfileMetricsData
    {
        /// <summary>
        /// Identifies the type of the resource.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier of the messaging profile.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public Guid MessagingProfileId { get; set; }

        /// <summary>
        /// The number of phone numbers associated with the messaging profile.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public int PhoneNumbers { get; set; }

        /// <summary>
        /// Metrics for outbound messages.
        /// </summary>
        [JsonPropertyName("outbound")]
        public MessagingProfileOutboundMetrics Outbound { get; set; } = new();

        /// <summary>
        /// Metrics for inbound messages.
        /// </summary>
        [JsonPropertyName("inbound")]
        public MessagingProfileInboundMetrics Inbound { get; set; } = new();
    }

    public class MessagingProfileMetricsMeta
    {
        /// <summary>
        /// Total number of pages.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Total number of results.
        /// </summary>
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        /// <summary>
        /// Current page number.
        /// </summary>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Number of results per page.
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
    }

}
