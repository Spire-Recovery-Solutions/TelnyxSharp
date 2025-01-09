
using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests;

public class UpdateNumberConfigurationRequest : ITelnyxRequest
{
    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }

    [JsonPropertyName("address_id")]
    public string? AddressId { get; set; }

    [JsonPropertyName("external_pin")]
    public string? ExternalPin { get; set; }

    [JsonPropertyName("customer_reference")]
    public string? CustomerReference { get; set; }

    [JsonPropertyName("connection_id")]
    public string? ConnectionId { get; set; }

    [JsonPropertyName("billing_group_id")]
    public string? BillingGroupId { get; set; }

    [JsonPropertyName("number_level_routing")]
    public string? NumberLevelRouting { get; set; }

    [JsonPropertyName("hd_voice_enabled")]
    public bool? HdVoiceEnabled { get; set; }


}