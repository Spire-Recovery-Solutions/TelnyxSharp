using System.Text.Json.Serialization;

namespace TelnyxSharp.Components.BlazorWebRTC.Models;

/// <summary>
/// Configuration options for initializing a TelnyxRTC client
/// </summary>
public class TelnyxClientOptions
{
    /// <summary>
    /// The JSON Web Token (JWT) to authenticate with your SIP Connection.
    /// This is the recommended authentication strategy.
    /// </summary>
    [JsonPropertyName("login_token")]
    public string? LoginToken { get; set; }

    /// <summary>
    /// The username to authenticate with your SIP Connection.
    /// </summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>
    /// The password to authenticate with your SIP Connection.
    /// </summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>
    /// A URL to a wav/mp3 ringtone file.
    /// </summary>
    [JsonPropertyName("ringtoneFile")]
    public string? RingtoneFile { get; set; }

    /// <summary>
    /// A URL to a wav/mp3 ringback file.
    /// </summary>
    [JsonPropertyName("ringbackFile")]
    public string? RingbackFile { get; set; }

    /// <summary>
    /// Enable debug mode for this client.
    /// </summary>
    [JsonPropertyName("debug")]
    public bool Debug { get; set; } = false;

    /// <summary>
    /// Debug output option
    /// </summary>
    [JsonPropertyName("debugOutput")]
    public string? DebugOutput { get; set; }

    /// <summary>
    /// Enable or disable prefetching ICE candidates.
    /// </summary>
    [JsonPropertyName("prefetchIceCandidates")]
    public bool PrefetchIceCandidates { get; set; } = false;

    /// <summary>
    /// Force the use of a relay ICE candidate.
    /// </summary>
    [JsonPropertyName("forceRelayCandidate")]
    public bool ForceRelayCandidate { get; set; } = false;

    /// <summary>
    /// Region to use for the connection.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}