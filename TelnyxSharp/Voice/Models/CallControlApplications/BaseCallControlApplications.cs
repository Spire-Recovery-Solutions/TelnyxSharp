using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.CallControlApplications
{
    /// <summary>
    /// Base class for Call Control Applications containing common properties.
    /// </summary>
    public class BaseCallControlApplications
    {
        /// <summary>
        /// Indicates whether the application is active.
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; } = true;

        /// <summary>
        /// Optional override for the anchor site.
        /// </summary>
        [JsonPropertyName("anchorsite_override")]
        public string? AnchorsiteOverride { get; set; }

        /// <summary>
        /// Name of the application.
        /// </summary>
        [JsonPropertyName("application_name")]
        public string? ApplicationName { get; set; }

        /// <summary>
        /// The creation time of the application in ISO 8601 format.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The type of DTMF signaling used (e.g., RFC 2833).
        /// </summary>
        [JsonPropertyName("dtmf_type")]
        public string DtmfType { get; set; } = "RFC 2833";

        /// <summary>
        /// Indicates whether the first command has a timeout.
        /// </summary>
        [JsonPropertyName("first_command_timeout")]
        public bool FirstCommandTimeout { get; set; }

        /// <summary>
        /// The timeout duration for the first command in seconds.
        /// </summary>
        [JsonPropertyName("first_command_timeout_secs")]
        public int FirstCommandTimeoutSecs { get; set; } = 30;

        /// <summary>
        /// Unique identifier for the application.
        /// </summary>
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Inbound settings associated with the application.
        /// </summary>
        [JsonPropertyName("inbound")]
        public InboundSettings? Inbound { get; set; }

        /// <summary>
        /// Outbound settings associated with the application.
        /// </summary>
        [JsonPropertyName("outbound")]
        public OutboundSettings? Outbound { get; set; }

        /// <summary>
        /// The record type of the application.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = "call_control_application";

        /// <summary>
        /// The last update time of the application in ISO 8601 format.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Version of the webhook API.
        /// </summary>
        [JsonPropertyName("webhook_api_version")]
        public string WebhookApiVersion { get; set; } = "1";

        /// <summary>
        /// The URL to be used if the webhook event fails over.
        /// </summary>
        [JsonPropertyName("webhook_event_failover_url")]
        public string? WebhookEventFailoverUrl { get; set; }

        /// <summary>
        /// The URL to which webhook events are sent.
        /// </summary>
        [JsonPropertyName("webhook_event_url")]
        public string? WebhookEventUrl { get; set; }

        /// <summary>
        /// The timeout duration for the webhook in seconds.
        /// </summary>
        [JsonPropertyName("webhook_timeout_secs")]
        public int? WebhookTimeoutSecs { get; set; }
    }

    /// <summary>
    /// Represents the inbound settings for a call control application.
    /// </summary>
    public class InboundSettings
    {
        /// <summary>
        /// The limit for the number of channels for inbound calls.
        /// </summary>
        [JsonPropertyName("channel_limit")]
        public int? ChannelLimit { get; set; }

        /// <summary>
        /// Indicates whether SHAKEN/STIR is enabled for inbound calls.
        /// </summary>
        [JsonPropertyName("shaken_stir_enabled")]
        public bool ShakenStirEnabled { get; set; }

        /// <summary>
        /// The SIP subdomain for inbound call processing.
        /// </summary>
        [JsonPropertyName("sip_subdomain")]
        public string? SipSubdomain { get; set; }

        /// <summary>
        /// Settings for receiving SIP subdomains.
        /// </summary>
        [JsonPropertyName("sip_subdomain_receive_settings")]
        public SipSubdomainReceiveSettings SipSubdomainReceiveSettings { get; set; } = SipSubdomainReceiveSettings.FromAnyone;
    }

    /// <summary>
    /// Represents the outbound settings for a call control application.
    /// </summary>
    public class OutboundSettings
    {
        /// <summary>
        /// The limit for the number of channels for outbound calls.
        /// </summary>
        [JsonPropertyName("channel_limit")]
        public int? ChannelLimit { get; set; }

        /// <summary>
        /// The ID of the associated outbound voice profile.
        /// </summary>
        [JsonPropertyName("outbound_voice_profile_id")]
        public long? OutboundVoiceProfileId { get; set; }
    }
}