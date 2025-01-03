using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public class MessagingProfileMetricsResponse : TelnyxResponse<List<MessagingProfileMetricsData>>
    {
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
