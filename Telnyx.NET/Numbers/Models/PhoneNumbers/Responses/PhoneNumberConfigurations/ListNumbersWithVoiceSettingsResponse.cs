using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations
{
    /// <summary>
    /// Represents the response containing a list of phone numbers with their associated voice settings.
    /// </summary>
    public class ListNumbersWithVoiceSettingsResponse : TelnyxResponse<List<PhoneNumberVoiceSettings>>
    {
    }

    /// <summary>
    /// Represents the voice settings for a specific phone number.
    /// </summary>
    public class PhoneNumberVoiceSettings
    {
        /// <summary>
        /// Unique identifier for the phone number voice settings.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of record (e.g., "voice_settings").
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// The associated phone number.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Identifier for the associated connection.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Optional reference for the customer.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Indicates whether the technical prefix is enabled.
        /// </summary>
        [JsonPropertyName("tech_prefix_enabled")]
        public bool? TechPrefixEnabled { get; set; }

        /// <summary>
        /// The translated phone number.
        /// </summary>
        [JsonPropertyName("translated_number")]
        public string? TranslatedNumber { get; set; }

        /// <summary>
        /// Settings for call forwarding.
        /// </summary>
        [JsonPropertyName("call_forwarding")]
        public CallForwardingSettings? CallForwarding { get; set; }

        /// <summary>
        /// Settings for CNAM (Caller Name).
        /// </summary>
        [JsonPropertyName("cnam_listing")]
        public CnamListingSettings? CnamListing { get; set; }

        /// <summary>
        /// Settings for emergency services.
        /// </summary>
        [JsonPropertyName("emergency")]
        public EmergencySettings? Emergency { get; set; }

        /// <summary>
        /// Payment method for usage charges.
        /// </summary>
        [JsonPropertyName("usage_payment_method")]
        public string? UsagePaymentMethod { get; set; }

        /// <summary>
        /// Media-related features and configurations.
        /// </summary>
        [JsonPropertyName("media_features")]
        public MediaFeatures? MediaFeatures { get; set; }

        /// <summary>
        /// Settings for call recording.
        /// </summary>
        [JsonPropertyName("call_recording")]
        public CallRecordingSettings? CallRecording { get; set; }

        /// <summary>
        /// Settings for inbound call screening.
        /// </summary>
        [JsonPropertyName("inbound_call_screening")]
        public string? InboundCallScreening { get; set; }
    }

    /// <summary>
    /// Represents the settings for call forwarding.
    /// </summary>
    public class CallForwardingSettings
    {
        /// <summary>
        /// Indicates if call forwarding is enabled.
        /// </summary>
        [JsonPropertyName("call_forwarding_enabled")]
        public bool? CallForwardingEnabled { get; set; }

        /// <summary>
        /// The number to which calls are forwarded.
        /// </summary>
        [JsonPropertyName("forwards_to")]
        public string? ForwardsTo { get; set; }

        /// <summary>
        /// The type of forwarding, such as "always" or "on_failure".
        /// </summary>
        [JsonPropertyName("forwarding_type")]
        public string? ForwardingType { get; set; }
    }

    /// <summary>
    /// Represents the settings for CNAM (Caller Name).
    /// </summary>
    public class CnamListingSettings
    {
        /// <summary>
        /// Indicates if CNAM listing is enabled.
        /// </summary>
        [JsonPropertyName("cnam_listing_enabled")]
        public bool? CnamListingEnabled { get; set; }

        /// <summary>
        /// Details of the CNAM listing (max 15 alphanumeric characters or spaces).
        /// </summary>
        [JsonPropertyName("cnam_listing_details")]
        public string? CnamListingDetails { get; set; }
    }

    /// <summary>
    /// Represents the settings for emergency services.
    /// </summary>
    public class EmergencySettings
    {
        /// <summary>
        /// Indicates if emergency services are enabled.
        /// </summary>
        [JsonPropertyName("emergency_enabled")]
        public bool? EmergencyEnabled { get; set; }

        /// <summary>
        /// Identifier for the emergency address.
        /// </summary>
        [JsonPropertyName("emergency_address_id")]
        public long? EmergencyAddressId { get; set; }

        /// <summary>
        /// The status of emergency services (e.g., "disabled", "active").
        /// </summary>
        [JsonPropertyName("emergency_status")]
        public string? EmergencyStatus { get; set; }
    }

    /// <summary>
    /// Represents media-related features and configurations.
    /// </summary>
    public class MediaFeatures
    {
        /// <summary>
        /// Indicates if RTP auto-adjust is enabled.
        /// </summary>
        [JsonPropertyName("rtp_auto_adjust_enabled")]
        public bool? RtpAutoAdjustEnabled { get; set; }

        /// <summary>
        /// Indicates if accepting any RTP packets is enabled.
        /// </summary>
        [JsonPropertyName("accept_any_rtp_packets_enabled")]
        public bool? AcceptAnyRtpPacketsEnabled { get; set; }

        /// <summary>
        /// Indicates if T38 fax gateway is enabled.
        /// </summary>
        [JsonPropertyName("t38_fax_gateway_enabled")]
        public bool? T38FaxGatewayEnabled { get; set; }
    }

    /// <summary>
    /// Represents the settings for call recording.
    /// </summary>
    public class CallRecordingSettings
    {
        /// <summary>
        /// Indicates if inbound call recording is enabled.
        /// </summary>
        [JsonPropertyName("inbound_call_recording_enabled")]
        public bool? InboundCallRecordingEnabled { get; set; }

        /// <summary>
        /// The format for inbound call recordings (e.g., "wav", "mp3").
        /// </summary>
        [JsonPropertyName("inbound_call_recording_format")]
        public string? InboundCallRecordingFormat { get; set; }

        /// <summary>
        /// The channel configuration for inbound call recordings (e.g., "single", "dual").
        /// </summary>
        [JsonPropertyName("inbound_call_recording_channels")]
        public string? InboundCallRecordingChannels { get; set; }
    }
}