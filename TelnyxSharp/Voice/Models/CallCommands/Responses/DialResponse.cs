using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Voice.Models.CallCommands.Responses;

/// <summary>
/// Represents the response received from Telnyx after initiating a Dial request.
/// This includes details about the call session, along with potential errors
/// if the API call was unsuccessful.
/// </summary>
public class DialResponse : TelnyxResponse<DialResponseData>
{
}

/// <summary>
/// Contains detailed information about the call session returned by the API.
/// </summary>
public class DialResponseData
{
    /// <summary>
    /// The unique identifier for controlling the call using the Telnyx Call Control API.
    /// </summary>
    [JsonPropertyName("call_control_id")]
    public string CallControlId { get; set; } = string.Empty;

    /// <summary>
    /// The unique identifier for the specific leg of the call.
    /// </summary>
    [JsonPropertyName("call_leg_id")]
    public string CallLegId { get; set; } = string.Empty;

    /// <summary>
    /// The unique identifier for the entire call session.
    /// </summary>
    [JsonPropertyName("call_session_id")]
    public string CallSessionId { get; set; } = string.Empty;

    /// <summary>
    /// Specifies the type of the call record returned (e.g., "call", "conference", etc.).
    /// </summary>
    [JsonPropertyName("record_type")]
    public string RecordType { get; set; } = string.Empty;

    /// <summary>
    /// Indicates whether the call is still active.
    /// </summary>
    [JsonPropertyName("is_alive")]
    public bool IsAlive { get; set; }

    /// <summary>
    /// A custom state associated with the client, if provided in the original request.
    /// </summary>
    [JsonPropertyName("client_state")]
    public string? ClientState { get; set; }

    /// <summary>
    /// The total duration of the call in seconds, if applicable.
    /// </summary>
    [JsonPropertyName("call_duration")]
    public int? CallDuration { get; set; }

    // Add other relevant properties as needed
}