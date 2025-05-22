using System.Text.Json.Serialization;

namespace TelnyxSharp.Components.BlazorWebRTC.Models;

/// <summary>
/// Options for creating a new call
/// </summary>
public class CallOptions
{
    /// <summary>
    /// Phone number or SIP URI to dial.
    /// </summary>
    [JsonPropertyName("destinationNumber")]
    public string? DestinationNumber { get; set; }

    /// <summary>
    /// Number to use as the caller ID when dialing out.
    /// </summary>
    [JsonPropertyName("callerNumber")]
    public string? CallerNumber { get; set; }

    /// <summary>
    /// Name to use as the caller ID name when dialing out.
    /// </summary>
    [JsonPropertyName("callerName")]
    public string? CallerName { get; set; }

    /// <summary>
    /// Custom ID to identify the call.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Enable audio for the call.
    /// </summary>
    [JsonPropertyName("audio")]
    public bool Audio { get; set; } = true;

    /// <summary>
    /// Enable video for the call.
    /// </summary>
    [JsonPropertyName("video")]
    public bool Video { get; set; } = false;

    /// <summary>
    /// HTML element ID for local media.
    /// </summary>
    [JsonPropertyName("localElement")]
    public string? LocalElement { get; set; }

    /// <summary>
    /// HTML element ID for remote media.
    /// </summary>
    [JsonPropertyName("remoteElement")]
    public string? RemoteElement { get; set; }

    /// <summary>
    /// Custom headers to add to the call.
    /// </summary>
    [JsonPropertyName("customHeaders")]
    public List<CustomHeader>? CustomHeaders { get; set; }

    /// <summary>
    /// Enable debug mode for this call.
    /// </summary>
    [JsonPropertyName("debug")]
    public bool Debug { get; set; } = false;
}

public class CustomHeader
{
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;

    [JsonPropertyName("value")] public string Value { get; set; } = string.Empty;
}