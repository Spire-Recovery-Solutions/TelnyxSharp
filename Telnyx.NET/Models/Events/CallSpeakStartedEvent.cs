using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event indicating that the speaking action has started in a call.
    /// This event contains a payload with details about the call, including identifiers for the call control, connection, call leg, call session, and client state.
    /// </summary>
    public class CallSpeakStartedEvent : BaseEvent
    {
        /// <summary>
        /// Gets or sets the payload containing details about the speak started event.
        /// </summary>
        [JsonPropertyName("payload")]
        public CallSpeakStartedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload containing details of the speak started event.
    /// This payload includes identifiers for the call control, connection, call leg, call session, and the client state.
    /// </summary>
    public class CallSpeakStartedPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier for the call control.
        /// This is the Call ID used to issue commands via the Call Control API.
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
        /// This ID is unique to the call session and can be used to correlate webhook events.
        /// A call session is a group of related call legs that logically belong to the same phone call.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the state of the client at the time the speaking action started.
        /// This state is received from a command.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }
    }
}