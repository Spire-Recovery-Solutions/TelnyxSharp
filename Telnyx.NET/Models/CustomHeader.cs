using System.Text.Json.Serialization;

namespace Telnyx.NET.Models;

/// <summary>
/// Represents a custom header that can be added to SIP INVITE requests.
/// Each custom header consists of a name and a value.
/// Both the name and value are required for the header to be valid.
/// </summary>
public class CustomHeader
{
    /// <summary>
    /// The name of the custom header. This field is required.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The value associated with the custom header. This field is required.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; };
}