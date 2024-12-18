

using System.Text.Json.Serialization;

namespace Telnyx.NET.Models;

public partial class CreateNumberOrderRegulatoryRequirement
{
    [JsonPropertyName("field_type")]
    public string? FieldType { get; set; }

    [JsonPropertyName("field_value")]
    public string? FieldValue { get; set; }

    [JsonPropertyName("record_type")]
    public string? RecordType { get; set; }

    [JsonPropertyName("requirement_id")]
    public string? RequirementId { get; set; }
}