using System.Text.Json.Serialization;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers;

/// <summary>
/// Represents a regulatory requirement for a Telnyx number order.
/// </summary>
public partial class NumberOrderRegulatoryRequirement
{
    /// <summary>
    /// Gets or sets the type of the field required for the number order.
    /// </summary>
    [JsonPropertyName("field_type")]
    public string? FieldType { get; set; }

    /// <summary>
    /// Gets or sets the value associated with the required field.
    /// </summary>
    [JsonPropertyName("field_value")]
    public string? FieldValue { get; set; }

    /// <summary>
    /// Gets or sets the record type of the regulatory requirement.
    /// </summary>
    [JsonPropertyName("record_type")]
    public string? RecordType { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the regulatory requirement.
    /// </summary>
    [JsonPropertyName("requirement_id")]
    public string? RequirementId { get; set; }
}