using System.Text.Json.Serialization;
using TelnyxSharp.Models.Events;

namespace TelnyxSharp.Voice.Events;

/// <summary>
/// Represents the Call Fork Stopped event received from Telnyx.
/// </summary>
public class CallForkStoppedEvent : BaseEvent
{
    /// <summary>
    /// Gets or sets the payload specific to the Call Fork Stopped event.
    /// </summary>
    [JsonPropertyName("payload")]
    public CallForkStoppedPayload Payload { get; set; }
}

/// <summary>
/// Represents the payload for the Call Fork Stopped event.
/// </summary>
public class CallForkStoppedPayload
{
    /// <summary>
    /// Gets or sets the Call Control App ID (formerly Telnyx connection ID) used in the call.
    /// </summary>
    [JsonPropertyName("connection_id")]
    public string Connection_id { get; set; }

    /// <summary>
    /// Gets or sets the Call Control ID used to issue commands via the Call Control API.
    /// </summary>
    [JsonPropertyName("call_control_id")]
    public string Call_control_id { get; set; }

    /// <summary>
    /// Gets or sets the ID that is unique to the call and can be used to correlate webhook events.
    /// </summary>
    [JsonPropertyName("call_leg_id")]
    public string Call_leg_id { get; set; }

    /// <summary>
    /// Gets or sets the ID that is unique to the call session and can be used to correlate webhook events.
    /// </summary>
    [JsonPropertyName("call_session_id")]
    public string Call_session_id { get; set; }

    /// <summary>
    /// Gets or sets the state received from a command.
    /// </summary>
    [JsonPropertyName("client_state")]
    public string Client_state { get; set; }

    /// <summary>
    /// Gets or sets the type of stream used during the call.
    /// </summary>
    [JsonPropertyName("stream_type")]
    public string Stream_type { get; set; }
}