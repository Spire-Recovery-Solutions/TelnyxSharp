using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.CallControlApplications.Requests
{
    /// <summary>
    /// Represents the request model for creating a call control application.
    /// </summary>
    public class CreateCallControlApplicationRequest : ITelnyxRequest
    {
        /// <summary>
        /// The name of the call control application.
        /// </summary>
        [JsonPropertyName("application_name")]
        public required string ApplicationName { get; set; }

        /// <summary>
        /// The URL to which webhook events will be sent.
        /// </summary>
        [JsonPropertyName("webhook_event_url")]
        public required string WebhookEventUrl { get; set; }

        /// <summary>
        /// Indicates whether the application is active.
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; } = true;

        /// <summary>
        /// Overrides the default anchorsite behavior with the specified value.
        /// </summary>
        [JsonPropertyName("anchorsite_override")]
        public AnchorsiteOverride AnchorsiteOverride { get; set; } = AnchorsiteOverride.Latency;

        /// <summary>
        /// Specifies the DTMF type for the application.
        /// </summary>
        [JsonPropertyName("dtmf_type")]
        public DtmfType DtmfType { get; set; } = DtmfType.Rfc2833;

        /// <summary>
        /// Indicates whether the first command has a timeout.
        /// </summary>
        [JsonPropertyName("first_command_timeout")]
        public bool FirstCommandTimeout { get; set; }

        /// <summary>
        /// Specifies the timeout duration (in seconds) for the first command.
        /// </summary>
        [JsonPropertyName("first_command_timeout_secs")]
        public int FirstCommandTimeoutSecs { get; set; } = 30;

        /// <summary>
        /// Defines the settings for inbound calls.
        /// </summary>
        [JsonPropertyName("inbound")]
        public InboundSettings? Inbound { get; set; }

        /// <summary>
        /// Defines the settings for outbound calls.
        /// </summary>
        [JsonPropertyName("outbound")]
        public OutboundSettings? Outbound { get; set; }

        /// <summary>
        /// Specifies the webhook API version to be used.
        /// </summary>
        [JsonPropertyName("webhook_api_version")]
        public string WebhookApiVersion { get; set; } = "1";

        /// <summary>
        /// The URL to which webhook events will be sent in case of failover.
        /// </summary>
        [JsonPropertyName("webhook_event_failover_url")]
        public string? WebhookEventFailoverUrl { get; set; }

        /// <summary>
        /// The timeout duration (in seconds) for webhook event processing.
        /// </summary>
        [JsonPropertyName("webhook_timeout_secs")]
        public int? WebhookTimeoutSecs { get; set; }
    }
}