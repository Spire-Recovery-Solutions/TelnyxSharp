using System.Text.Json.Serialization;
using TelnyxSharp.Models.Events;

namespace TelnyxSharp.Voice.Events;

/// <summary>
/// Represents an event indicating that a call has been hung up.
/// This event contains a payload with details about the hung-up call,
/// including identifiers, state, hangup reasons, and the origin and destination of the call.
/// </summary>
public class CallHangupEvent : BaseEvent
{
    /// <summary>
    /// Gets or sets the payload of the call hangup event.
    /// This payload contains various details regarding the hung-up call.
    /// </summary>
    [JsonPropertyName("payload")]
    public CallHangupPayload Payload { get; set; }
}

/// <summary>
/// Represents the payload containing details of the hung-up call.
/// This includes identifiers for call control, connection, call leg,
/// session, client state, hangup reasons, and the call's origin and destination.
/// </summary>
public class CallHangupPayload
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
    /// Gets or sets the start time of the call.
    /// This is represented in ISO 8601 DateTimeOffset? format.
    /// </summary>
    [JsonPropertyName("start_time")]
    public DateTimeOffset? Start_time { get; set; }

    /// <summary>
    /// Gets or sets the start time of the call.
    /// This is represented in ISO 8601 DateTimeOffset? format.
    /// </summary>
    [JsonPropertyName("end_time")]
    public DateTimeOffset? End_time { get; set; }

    /// <summary>
    /// Gets or sets the current state of the call.
    /// Possible values include: [hangup].
    /// This state is also received from a command.
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or sets the reason for the hangup.
    /// Possible values include: [call_rejected, normal_clearing, originator_cancel, timeout, time_limit, user_busy, not_found, unspecified].
    /// </summary>
    [JsonPropertyName("hangup_cause")]
    public string Hangup_cause { get; set; }

    /// <summary>
    /// Gets or sets the source of the hangup.
    /// Possible values include: [caller, callee, unknown].
    /// </summary>
    [JsonPropertyName("hangup_source")]
    public string Hangup_source { get; set; }

    /// <summary>
    /// Gets or sets the SIP hangup cause code.
    /// This represents the reason the call was ended as per SIP response code.
    /// If the SIP response is unavailable (in inbound calls for example), this is set to unspecified.
    /// </summary>
    [JsonPropertyName("sip_hangup_cause")]
    public string Sip_hangup_cause { get; set; }
}