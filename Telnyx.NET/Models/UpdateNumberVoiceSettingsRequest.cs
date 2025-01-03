using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models;

public class UpdateNumberVoiceSettingsRequest : ITelnyxRequest
{
    [JsonPropertyName("tech_prefix_enabled")]
    public bool? TechPrefixEnabled { get; set; }

    [JsonPropertyName("translated_number")]
    public string? TranslatedNumber { get; set; }

    [JsonPropertyName("call_forwarding")]
    public UpdateNumberVoiceSettingsCallForwarding CallForwarding { get; set; }

    [JsonPropertyName("cnam_listing")]
    public UpdateNumberVoiceSettingsCnamListing CnamListing { get; set; }

    [JsonPropertyName("usage_payment_method")]
    public string? UsagePaymentMethod { get; set; }

    [JsonPropertyName("media_features")]
    public UpdateNumberVoiceSettingsMediaFeatures MediaFeatures { get; set; }

    [JsonPropertyName("call_recording")]
    public UpdateNumberVoiceSettingsCallRecording CallRecording { get; set; }
}