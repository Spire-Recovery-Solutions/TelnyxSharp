using System.Text.Json.Serialization;
using Telnyx.NET.Models.Events;

namespace Telnyx.NET.Voice.Events;

/// <summary>
/// Represents an event indicating that a call has been bridged.
/// This event contains a payload with details about the bridged call,
/// including identifiers, state, and the origin and destination of the call.
/// </summary>
public class CallBridgedEvent : BaseEvent
{
    /// <summary>
    /// Gets or sets the payload of the call bridged event.
    /// This payload contains various details regarding the bridged call.
    /// </summary>
    [JsonPropertyName("payload")]
    public CallBridgedPayload Payload { get; set; }
}

/// <summary>
/// Represents the payload containing details of the bridged call.
/// This includes identifiers for call control, connection, call leg,
/// session, client state, and the call's origin and destination.
/// </summary>
public class CallBridgedPayload
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
    public string? Call_session_id { get; set; }

    /// <summary>
    /// Gets or sets the state of the client at the time of the event.
    /// This state is received from a command.
    /// </summary>
    [JsonPropertyName("client_state")]
    public string Client_state { get; set; }

    /// <summary>
    /// Gets or sets the phone number or SIP URI from which the call originated.
    /// </summary>
    [JsonPropertyName("from")]
    public string From { get; set; }

    /// <summary>
    /// Gets or sets the destination number or SIP URI of the call.
    /// </summary>
    [JsonPropertyName("to")]
    public string To { get; set; }

    /// <summary>
    /// Gets or sets the current state of the call.
    /// Possible values include: [bridged].
    /// This state is also received from a command.
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; }
}
