using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.CallControlApplications.Requests
{
    /// <summary>
    /// Represents the request model for updating a call control application.
    /// </summary>
    public class UpdateCallControlApplicationRequest : ITelnyxRequest
    {
        /// <summary>
        /// The name of the application to be updated.
        /// This field is required.
        /// </summary>
        [JsonPropertyName("application_name")]
        public required string ApplicationName { get; set; }

        /// <summary>
        /// The primary webhook URL for event notifications.
        /// This field is required.
        /// </summary>
        [JsonPropertyName("webhook_event_url")]
        public required string WebhookEventUrl { get; set; }

        /// <summary>
        /// Indicates whether the application is active.
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Overrides the default anchorsite settings for the application.
        /// </summary>
        [JsonPropertyName("anchorsite_override")]
        public AnchorsiteOverride? AnchorsiteOverride { get; set; }

        /// <summary>
        /// Specifies the DTMF type to use for the application.
        /// </summary>
        [JsonPropertyName("dtmf_type")]
        public DtmfType? DtmfType { get; set; }

        /// <summary>
        /// Indicates whether the first command timeout is enabled.
        /// </summary>
        [JsonPropertyName("first_command_timeout")]
        public bool? FirstCommandTimeout { get; set; }

        /// <summary>
        /// The timeout duration in seconds for the first command.
        /// </summary>
        [JsonPropertyName("first_command_timeout_secs")]
        public int? FirstCommandTimeoutSecs { get; set; }

        /// <summary>
        /// Settings related to inbound call handling.
        /// </summary>
        [JsonPropertyName("inbound")]
        public InboundSettings? Inbound { get; set; }

        /// <summary>
        /// Settings related to outbound call handling.
        /// </summary>
        [JsonPropertyName("outbound")]
        public OutboundSettings? Outbound { get; set; }

        /// <summary>
        /// The API version to be used for webhook events.
        /// </summary>
        [JsonPropertyName("webhook_api_version")]
        public string? WebhookApiVersion { get; set; }

        /// <summary>
        /// The failover webhook URL for event notifications.
        /// </summary>
        [JsonPropertyName("webhook_event_failover_url")]
        public string? WebhookEventFailoverUrl { get; set; }

        /// <summary>
        /// The timeout duration in seconds for webhook events.
        /// </summary>
        [JsonPropertyName("webhook_timeout_secs")]
        public int? WebhookTimeoutSecs { get; set; }
    }
}