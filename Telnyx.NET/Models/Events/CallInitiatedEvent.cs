using System.Text.Json.Serialization;
using Telnyx.NET.Voice.Models.CallCommands.Requests;

namespace Telnyx.NET.Models.Events;

/// <summary>
/// Represents an event indicating that a call has been initiated.
/// This event contains a payload with details about the initiated call,
/// including identifiers, state, and custom headers from the SIP invite.
/// </summary>
public class CallInitiatedEvent : BaseEvent
{
    /// <summary>
    /// Gets or sets the payload of the call initiated event.
    /// This payload contains various details regarding the call initiation.
    /// </summary>
    [JsonPropertyName("payload")]
    public CallInitiatedPayload Payload { get; set; }
}

/// <summary>
/// Represents the payload containing details of the initiated call.
/// This includes identifiers for the call control, connection, call leg,
/// session, client state, and the call's origin and destination.
/// </summary>
public class CallInitiatedPayload
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
    /// Gets or sets the custom headers associated with the call.
    /// These headers are from the SIP invite and include name-value pairs.
    /// </summary>
    [JsonPropertyName("custom_headers")]
    public List<CustomHeader> Custom_headers { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the call session.
    /// This ID can be used to correlate webhook events and represents a group of 
    /// related call legs that logically belong to the same phone call.
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
    /// Gets or sets the direction of the call.
    /// Possible values are: [incoming, outgoing].
    /// </summary>
    [JsonPropertyName("direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Gets or sets the current state of the call.
    /// Possible values include: [parked, bridging].
    /// This state is also received from a command.
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; }
}