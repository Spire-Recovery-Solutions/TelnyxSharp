using System.Text.Json.Serialization;
using Telnyx.NET.Models.Events;

namespace Telnyx.NET.Voice.Events;

/// <summary>
/// Represents an event indicating that call streaming has started.
/// This event contains a payload with details about the call and the streaming information.
/// </summary>
public class CallStreamingStartedEvent : BaseEvent
{
    /// <summary>
    /// Gets or sets the payload of the call streaming started event.
    /// This payload contains various details regarding the call and streaming details.
    /// </summary>
    [JsonPropertyName("payload")]
    public CallStreamingStartedPayload Payload { get; set; }
}

/// <summary>
/// Represents the payload containing details of the started call streaming.
/// This includes identifiers for call control, connection, call leg,
/// session, client state, and the stream URL.
/// </summary>
public class CallStreamingStartedPayload
{
    /// <summary>
    /// Gets or sets the unique identifier for the call control.
    /// This ID is used to issue commands via the Call Control API.
    /// </summary>
    [JsonPropertyName("call_control_id")]
    public string Call_control_id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the connection.
    /// This is the Call Control App ID (formerly Telnyx connection ID) used in the call.
    /// </summary>
    [JsonPropertyName("connection_id")]
    public string Connection_id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the call leg.
    /// This ID is unique to the call and can be used to correlate webhook events.
    /// </summary>
    [JsonPropertyName("call_leg_id")]
    public string Call_leg_id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the call session.
    /// This ID can be used to correlate webhook events and represents a group of 
    /// related call legs that logically belong to the same phone call,
    /// e.g., an inbound and outbound leg of a transferred call.
    /// </summary>
    [JsonPropertyName("call_session_id")]
    public string Call_session_id { get; set; }

    /// <summary>
    /// Gets or sets the state of the client at the time of the event.
    /// This state is received from a command.
    /// </summary>
    [JsonPropertyName("client_state")]
    public string Client_state { get; set; }

    /// <summary>
    /// Gets or sets the destination WebSocket address where the stream is going to be delivered.
    /// </summary>
    [JsonPropertyName("stream_url")]
    public string Stream_url { get; set; }
}