using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations;

/// <summary>
/// Represents a request to update the configuration of a phone number.
/// This class allows for specifying various settings such as tags, address information, customer references, and routing options.
/// </summary>
public class UpdateNumberConfigurationRequest : ITelnyxRequest
{
    /// <summary>
    /// Gets or sets an array of tags associated with the phone number.
    /// </summary>
    /// <remarks>
    /// Tags can be used to categorize or group phone numbers for easier management.
    /// </remarks>
    [JsonPropertyName("tags")]
    public string[]? Tags { get; set; }

    /// <summary>
    /// Gets or sets the external PIN associated with the phone number.
    /// </summary>
    /// <remarks>
    /// This can be used for additional security or verification purposes for the phone number.
    /// </remarks>
    [JsonPropertyName("external_pin")]
    public string? ExternalPin { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether HD voice is enabled for the phone number.
    /// </summary>
    /// <remarks>
    /// Enabling HD voice provides enhanced audio quality for phone calls.
    /// </remarks>
    [JsonPropertyName("hd_voice_enabled")]
    public bool? HdVoiceEnabled { get; set; }

    /// <summary>
    /// Gets or sets the customer reference associated with the phone number.
    /// </summary>
    /// <remarks>
    /// Use this field to store a custom identifier or note for the customer or project linked to the phone number.
    /// </remarks>
    [JsonPropertyName("customer_reference")]
    public string? CustomerReference { get; set; }

    /// <summary>
    /// Gets or sets the connection ID associated with the phone number.
    /// </summary>
    /// <remarks>
    /// This identifies the connection that routes the phone number's voice traffic.
    /// </remarks>
    [JsonPropertyName("connection_id")]
    public string? ConnectionId { get; set; }

    /// <summary>
    /// Gets or sets the billing group ID associated with the phone number.
    /// </summary>
    /// <remarks>
    /// Use this field to link the phone number to a specific billing group for accounting purposes.
    /// </remarks>
    [JsonPropertyName("billing_group_id")]
    public string? BillingGroupId { get; set; }
}