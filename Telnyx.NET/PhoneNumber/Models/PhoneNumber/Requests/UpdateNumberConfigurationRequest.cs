using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests;

/// <summary>
/// Represents a request to update the configuration of a phone number.
/// This class allows for specifying various settings such as tags, address information, customer references, and routing options.
/// </summary>
public class UpdateNumberConfigurationRequest : ITelnyxRequest
{
    /// <summary>
    /// Gets or sets a list of tags associated with the phone number.
    /// Tags can be used for categorization or filtering purposes.
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }

    /// <summary>
    /// Gets or sets the address ID associated with the phone number.
    /// This is typically used to specify the physical address for compliance or billing purposes.
    /// </summary>
    [JsonPropertyName("address_id")]
    public string? AddressId { get; set; }

    /// <summary>
    /// Gets or sets an external PIN associated with the phone number.
    /// This field can be used to provide additional security or identification.
    /// </summary>
    [JsonPropertyName("external_pin")]
    public string? ExternalPin { get; set; }

    /// <summary>
    /// Gets or sets the customer reference for the phone number.
    /// This is a user-defined value that can be used to associate the number with a specific customer or account.
    /// </summary>
    [JsonPropertyName("customer_reference")]
    public string? CustomerReference { get; set; }

    /// <summary>
    /// Gets or sets the connection ID associated with the phone number.
    /// This field links the phone number to a specific voice or messaging connection.
    /// </summary>
    [JsonPropertyName("connection_id")]
    public string? ConnectionId { get; set; }

    /// <summary>
    /// Gets or sets the billing group ID for the phone number.
    /// This can be used to group phone numbers for billing or accounting purposes.
    /// </summary>
    [JsonPropertyName("billing_group_id")]
    public string? BillingGroupId { get; set; }

    /// <summary>
    /// Gets or sets the number-level routing configuration for the phone number.
    /// This field determines how calls to the phone number are routed.
    /// </summary>
    [JsonPropertyName("number_level_routing")]
    public string? NumberLevelRouting { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether HD (High Definition) voice is enabled for the phone number.
    /// Enabling HD voice can improve the quality of voice calls.
    /// </summary>
    [JsonPropertyName("hd_voice_enabled")]
    public bool? HdVoiceEnabled { get; set; }
}