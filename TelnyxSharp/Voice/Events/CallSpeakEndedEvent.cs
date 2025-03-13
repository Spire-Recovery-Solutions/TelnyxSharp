using System.Text.Json.Serialization;
using TelnyxSharp.Models.Events;

namespace TelnyxSharp.Voice.Events;

/// <summary>
/// Represents an event indicating that a speaking action has ended in a call.
/// This event provides information about the call's control, session, and status at the end of the speak action.
/// </summary>
public class CallSpeakEndedEvent : BaseEvent
{
    /// <summary>
    /// Gets or sets the payload containing details about the speak-ended event, 
    /// including call control identifiers, session details, and the command status.
    /// </summary>
    [JsonPropertyName("payload")]
    public CallSpeakEndedPayload Payload { get; set; }
}

/// <summary>
/// Represents the payload containing detailed information about the call and the 
/// speaking action that has ended, including session identifiers and final status.
/// </summary>
public class CallSpeakEndedPayload
{
    /// <summary>
    /// Gets or sets the unique identifier for the call control. This ID is used to issue commands via the Call Control API.
    /// </summary>
    [JsonPropertyName("call_control_id")]
    public string Call_control_id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the call control app (formerly Telnyx connection ID) used in the call.
    /// </summary>
    [JsonPropertyName("connection_id")]
    public string Connection_id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the call leg. This ID can be used to correlate specific webhook events related to this call.
    /// </summary>
    [JsonPropertyName("call_leg_id")]
    public string Call_leg_id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the call session. This ID correlates events belonging to the same session, 
    /// which may include multiple call legs (e.g., inbound and outbound legs of a transferred call).
    /// </summary>
    [JsonPropertyName("call_session_id")]
    public string Call_session_id { get; set; }

    /// <summary>
    /// Gets or sets the state information received from a previous command at the time the speak action ended.
    /// </summary>
    [JsonPropertyName("client_state")]
    public string Client_state { get; set; }

    /// <summary>
    /// Gets or sets the status indicating how the speaking action ended. Possible values include: completed, call_hangup, or cancelled_amd.
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
}