using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response containing metrics for a messaging profile.
    /// </summary>
    public class RetrieveMessagingProfileMetricsResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the metrics data for the messaging profile.
        /// </summary>
        [JsonPropertyName("data")]
        public MessagingProfileMetricsData? Data { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the metrics data for a messaging profile.
    /// </summary>
    public class MessagingProfileMetricsData
    {
        /// <summary>
        /// Gets or sets the detailed metrics.
        /// </summary>
        [JsonPropertyName("detailed")]
        public List<MessagingProfileDetailedMetric>? Detailed { get; set; }

        /// <summary>
        /// Gets or sets the overview metrics.
        /// </summary>
        [JsonPropertyName("overview")]
        public MessagingProfileMetricsOverview? Overview { get; set; }
    }

    /// <summary>
    /// Represents the overview metrics for a messaging profile.
    /// </summary>
    public class MessagingProfileMetricsOverview
    {
        /// <summary>
        /// Gets or sets the record type for the metrics.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the messaging profile ID.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string MessagingProfileId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of phone numbers associated with the profile.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public int PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the outbound metrics.
        /// </summary>
        [JsonPropertyName("outbound")]
        public MessagingProfileOutboundMetrics? Outbound { get; set; }

        /// <summary>
        /// Gets or sets the inbound metrics.
        /// </summary>
        [JsonPropertyName("inbound")]
        public MessagingProfileInboundMetrics? Inbound { get; set; }
    }

    /// <summary>
    /// Represents the detailed metrics for a messaging profile.
    /// </summary>
    public class MessagingProfileDetailedMetric
    {
        /// <summary>
        /// Gets or sets the timestamp for the metric.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the list of metric details.
        /// </summary>
        [JsonPropertyName("metrics")]
        public List<MessagingProfileMetricDetail>? Metrics { get; set; }
    }

    /// <summary>
    /// Represents a single metric detail.
    /// </summary>
    public class MessagingProfileMetricDetail
    {
        /// <summary>
        /// Gets or sets the label for the metric.
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of outbound messages sent.
        /// </summary>
        [JsonPropertyName("sent")]
        public int Sent { get; set; }

        /// <summary>
        /// Gets or sets the number of outbound messages delivered.
        /// </summary>
        [JsonPropertyName("delivered")]
        public int Delivered { get; set; }

        /// <summary>
        /// Gets or sets the ratio of outbound errors.
        /// </summary>
        [JsonPropertyName("outbound_error_ratio")]
        public int OutboundErrorRatio { get; set; }

        /// <summary>
        /// Gets or sets the number of inbound messages received.
        /// </summary>
        [JsonPropertyName("received")]
        public int Received { get; set; }
    }

    /// <summary>
    /// Represents the outbound metrics for a messaging profile.
    /// </summary>
    public class MessagingProfileOutboundMetrics
    {
        /// <summary>
        /// Gets or sets the number of outbound messages sent.
        /// </summary>
        [JsonPropertyName("sent")]
        public int Sent { get; set; }

        /// <summary>
        /// Gets or sets the number of outbound messages delivered.
        /// </summary>
        [JsonPropertyName("delivered")]
        public int Delivered { get; set; }

        /// <summary>
        /// Gets or sets the ratio of errors in outbound messages.
        /// </summary>
        [JsonPropertyName("error_ratio")]
        public double ErrorsRatio { get; set; }
    }

    /// <summary>
    /// Represents the inbound metrics for a messaging profile.
    /// </summary>
    public class MessagingProfileInboundMetrics
    {
        /// <summary>
        /// Gets or sets the number of inbound messages received.
        /// </summary>
        [JsonPropertyName("received")]
        public int Received { get; set; }
    }

}
