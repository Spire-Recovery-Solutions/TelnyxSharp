using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations;

/// <summary>
/// Represents a request to enable or disable emergency services for a phone number.
/// This request includes the status of emergency services and the associated emergency address.
/// </summary>
public class EnableEmergencyRequest : ITelnyxRequest
{
    /// <summary>
    /// Gets or sets a value indicating whether emergency services are enabled.
    /// </summary>
    /// <remarks>
    /// Set to <c>true</c> to enable emergency services; otherwise, <c>false</c>.
    /// </remarks>
    [JsonPropertyName("emergency_enabled")]
    public required bool EmergencyEnabled { get; set; }

    /// <summary>
    /// Gets or sets the ID of the emergency address associated with the phone number.
    /// </summary>
    /// <remarks>
    /// This value is required and should correspond to a valid emergency address ID in the system.
    /// </remarks>
    [JsonPropertyName("emergency_address_id")]
    public required long EmergencyAddressId { get; set; }
}