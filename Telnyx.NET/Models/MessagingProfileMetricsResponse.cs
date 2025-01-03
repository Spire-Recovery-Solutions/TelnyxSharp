using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public class MessagingProfileMetricsResponse : TelnyxResponse
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
        public PaginationMeta? Meta { get; set; }

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
        public string? MessagingProfileId { get; set; }

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


}
