using System.Text.Json.Serialization;

namespace TelnyxSharp.Components.BlazorWebRTC.Models;

/// <summary>
/// Notification event from Telnyx
/// </summary>
public class TelnyxNotification
{
    [JsonPropertyName("type")] public string Type { get; set; } = string.Empty;

    [JsonPropertyName("call")] public CallState? Call { get; set; }

    [JsonPropertyName("error")] public string? Error { get; set; }
}