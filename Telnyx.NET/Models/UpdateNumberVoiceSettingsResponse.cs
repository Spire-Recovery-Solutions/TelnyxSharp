using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Response model for updating the voice settings of a phone number.
    /// This class represents the response received after updating the voice settings, including details such as call forwarding, CNAM listing, and media features.
    /// </summary>
    public class UpdateNumberVoiceSettingsResponse : TelnyxResponse<UpdateNumberVoiceSettingsData>
    {
    }

    /// <summary>
    /// Data model for the updated voice settings of a phone number.
    /// This class contains the actual updated voice settings, including options such as call forwarding, call recording, and emergency settings.
    /// </summary>
    public partial class UpdateNumberVoiceSettingsData
    {
        /// <summary>
        /// Gets or sets the unique identifier of the updated voice settings.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the record type of the updated settings.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the phone number associated with the updated voice settings.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the connection ID related to the updated voice settings.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the connection name associated with the updated voice settings.
        /// </summary>
        [JsonPropertyName("connection_name")]
        public string? ConnectionName { get; set; }

        /// <summary>
        /// Gets or sets the customer reference ID associated with the updated voice settings.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the origination verification status of the phone number.
        /// </summary>
        [JsonPropertyName("origination_verification_status")]
        public string? OriginationVerificationStatus { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the origination verification status was last updated.
        /// </summary>
        [JsonPropertyName("origination_verification_status_updated_at")]
        public string? OriginationVerificationStatusUpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Caller ID Name (CNAM) is enabled.
        /// </summary>
        [JsonPropertyName("caller_id_name_enabled")]
        public bool? CallerIdNameEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tech prefix feature is enabled.
        /// </summary>
        [JsonPropertyName("tech_prefix_enabled")]
        public bool? TechPrefixEnabled { get; set; }

        /// <summary>
        /// Gets or sets the translated number to be used for the phone number.
        /// </summary>
        [JsonPropertyName("translated_number")]
        public string? TranslatedNumber { get; set; }

        /// <summary>
        /// Gets or sets the payment method for the usage costs of the phone number.
        /// </summary>
        [JsonPropertyName("usage_payment_method")]
        public string? UsagePaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the call forwarding settings for the phone number.
        /// </summary>
        [JsonPropertyName("call_forwarding")]
        public UpdateNumberVoiceSettingsCallForwarding CallForwarding { get; set; }

        /// <summary>
        /// Gets or sets the call recording settings for the phone number.
        /// </summary>
        [JsonPropertyName("call_recording")]
        public UpdateNumberVoiceSettingsCallRecording CallRecording { get; set; }

        /// <summary>
        /// Gets or sets the CNAM listing settings for the phone number.
        /// </summary>
        [JsonPropertyName("cnam_listing")]
        public UpdateNumberVoiceSettingsCnamListing CnamListing { get; set; }

        /// <summary>
        /// Gets or sets the emergency settings for the phone number.
        /// </summary>
        [JsonPropertyName("emergency")]
        public UpdateNumberVoiceSettingsEmergency Emergency { get; set; }

        /// <summary>
        /// Gets or sets the media features related to the voice settings of the phone number.
        /// </summary>
        [JsonPropertyName("media_features")]
        public UpdateNumberVoiceSettingsMediaFeatures MediaFeatures { get; set; }
    }

    /// <summary>
    /// Call forwarding settings for a phone number.
    /// </summary>
    public partial class UpdateNumberVoiceSettingsCallForwarding
    {
        /// <summary>
        /// Gets or sets a value indicating whether call forwarding is enabled.
        /// </summary>
        [JsonPropertyName("call_forwarding_enabled")]
        public bool? CallForwardingEnabled { get; set; }

        /// <summary>
        /// Gets or sets the number to which calls are forwarded.
        /// </summary>
        [JsonPropertyName("forwards_to")]
        public string? ForwardsTo { get; set; }

        /// <summary>
        /// Gets or sets the type of call forwarding.
        /// </summary>
        [JsonPropertyName("forwarding_type")]
        public string? ForwardingType { get; set; }
    }

    /// <summary>
    /// Call recording settings for a phone number.
    /// </summary>
    public partial class UpdateNumberVoiceSettingsCallRecording
    {
        /// <summary>
        /// Gets or sets a value indicating whether inbound call recording is enabled.
        /// </summary>
        [JsonPropertyName("inbound_call_recording_enabled")]
        public bool? InboundCallRecordingEnabled { get; set; }

        /// <summary>
        /// Gets or sets the number of channels used for inbound call recording.
        /// </summary>
        [JsonPropertyName("inbound_call_recording_channels")]
        public string? InboundCallRecordingChannels { get; set; }

        /// <summary>
        /// Gets or sets the format for recording inbound calls.
        /// </summary>
        [JsonPropertyName("inbound_call_recording_format")]
        public string? InboundCallRecordingFormat { get; set; }
    }

    /// <summary>
    /// CNAM (Caller ID Name) listing settings for a phone number.
    /// </summary>
    public partial class UpdateNumberVoiceSettingsCnamListing
    {
        /// <summary>
        /// Gets or sets a value indicating whether CNAM listing is enabled.
        /// </summary>
        [JsonPropertyName("cnam_listing_enabled")]
        public bool? CnamListingEnabled { get; set; }

        /// <summary>
        /// Gets or sets the CNAM listing details.
        /// </summary>
        [JsonPropertyName("cnam_listing_details")]
        public string? CnamListingDetails { get; set; }
    }

    /// <summary>
    /// Emergency settings for a phone number.
    /// </summary>
    public partial class UpdateNumberVoiceSettingsEmergency
    {
        /// <summary>
        /// Gets or sets a value indicating whether emergency services are enabled for the phone number.
        /// </summary>
        [JsonPropertyName("emergency_enabled")]
        public bool? EmergencyEnabled { get; set; }

        /// <summary>
        /// Gets or sets the emergency address ID for the phone number.
        /// </summary>
        [JsonPropertyName("emergency_address_id")]
        public string? EmergencyAddressId { get; set; }

        /// <summary>
        /// Gets or sets the emergency status of the phone number.
        /// </summary>
        [JsonPropertyName("emergency_status")]
        public string? EmergencyStatus { get; set; }
    }

    /// <summary>
    /// Media features related to voice settings for a phone number.
    /// </summary>
    public partial class UpdateNumberVoiceSettingsMediaFeatures
    {
        /// <summary>
        /// Gets or sets the media handling mode for the phone number (e.g., RTP or WebRTC).
        /// </summary>
        [JsonPropertyName("media_handling_mode")]
        public string? MediaHandlingMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether RTP auto-adjustment is enabled.
        /// </summary>
        [JsonPropertyName("rtp_auto_adjust_enabled")]
        public bool? RtpAutoAdjustEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the phone number accepts any RTP packets.
        /// </summary>
        [JsonPropertyName("accept_any_rtp_packets_enabled")]
        public bool? AcceptAnyRtpPacketsEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether T38 fax gateway is enabled.
        /// </summary>
        [JsonPropertyName("t38_fax_gateway_enabled")]
        public bool? T38FaxGatewayEnabled { get; set; }
    }
}