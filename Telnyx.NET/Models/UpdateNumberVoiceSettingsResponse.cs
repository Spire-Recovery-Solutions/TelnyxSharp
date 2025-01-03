using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models;

public class UpdateNumberVoiceSettingsResponse : TelnyxResponse
{
    [JsonPropertyName("data")]
    public UpdateNumberVoiceSettingsData Data { get; set; }
}

public partial class UpdateNumberVoiceSettingsData
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("record_type")]
    public string? RecordType { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("connection_id")]
    public string? ConnectionId { get; set; }

    [JsonPropertyName("connection_name")]
    public string? ConnectionName { get; set; }

    [JsonPropertyName("customer_reference")]
    public string? CustomerReference { get; set; }

    [JsonPropertyName("origination_verification_status")]
    public string? OriginationVerificationStatus { get; set; }

    [JsonPropertyName("origination_verification_status_updated_at")]
    public string? OriginationVerificationStatusUpdatedAt { get; set; }

    [JsonPropertyName("caller_id_name_enabled")]
    public bool? CallerIdNameEnabled { get; set; }

    [JsonPropertyName("tech_prefix_enabled")]
    public bool? TechPrefixEnabled { get; set; }

    [JsonPropertyName("translated_number")]
    public string? TranslatedNumber { get; set; }

    [JsonPropertyName("usage_payment_method")]
    public string? UsagePaymentMethod { get; set; }

    [JsonPropertyName("call_forwarding")]
    public UpdateNumberVoiceSettingsCallForwarding CallForwarding { get; set; }

    [JsonPropertyName("call_recording")]
    public UpdateNumberVoiceSettingsCallRecording CallRecording { get; set; }

    [JsonPropertyName("cnam_listing")]
    public UpdateNumberVoiceSettingsCnamListing CnamListing { get; set; }

    [JsonPropertyName("emergency")]
    public UpdateNumberVoiceSettingsEmergency Emergency { get; set; }

    [JsonPropertyName("media_features")]
    public UpdateNumberVoiceSettingsMediaFeatures MediaFeatures { get; set; }
}

public partial class UpdateNumberVoiceSettingsCallForwarding
{
    [JsonPropertyName("call_forwarding_enabled")]
    public bool? CallForwardingEnabled { get; set; }

    [JsonPropertyName("forwards_to")]
    public string? ForwardsTo { get; set; }

    [JsonPropertyName("forwarding_type")]
    public string? ForwardingType { get; set; }
}

public partial class UpdateNumberVoiceSettingsCallRecording
{
    [JsonPropertyName("inbound_call_recording_enabled")]
    public bool? InboundCallRecordingEnabled { get; set; }

    [JsonPropertyName("inbound_call_recording_channels")]
    public string? InboundCallRecordingChannels { get; set; }

    [JsonPropertyName("inbound_call_recording_format")]
    public string? InboundCallRecordingFormat { get; set; }
}

public partial class UpdateNumberVoiceSettingsCnamListing
{
    [JsonPropertyName("cnam_listing_enabled")]
    public bool? CnamListingEnabled { get; set; }

    [JsonPropertyName("cnam_listing_details")]
    public string? CnamListingDetails { get; set; }
}

public partial class UpdateNumberVoiceSettingsEmergency
{
    [JsonPropertyName("emergency_enabled")]
    public bool? EmergencyEnabled { get; set; }

    [JsonPropertyName("emergency_address_id")]
    public string? EmergencyAddressId { get; set; }

    [JsonPropertyName("emergency_status")]
    public string? EmergencyStatus { get; set; }
}

public partial class UpdateNumberVoiceSettingsMediaFeatures
{
    [JsonPropertyName("media_handling_mode")]
    public string? MediaHandlingMode { get; set; }

    [JsonPropertyName("rtp_auto_adjust_enabled")]
    public bool? RtpAutoAdjustEnabled { get; set; }

    [JsonPropertyName("accept_any_rtp_packets_enabled")]
    public bool? AcceptAnyRtpPacketsEnabled { get; set; }

    [JsonPropertyName("t38_fax_gateway_enabled")]
    public bool? T38FaxGatewayEnabled { get; set; }
}
