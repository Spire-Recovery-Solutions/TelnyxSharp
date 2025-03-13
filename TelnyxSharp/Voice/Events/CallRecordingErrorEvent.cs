using System.Text.Json.Serialization;
using TelnyxSharp.Models.Events;

namespace TelnyxSharp.Voice.Events
{
    /// <summary>
    /// Represents an event indicating an error occurred during call recording.
    /// </summary>
    public class CallRecordingErrorEvent : BaseEvent
    {
        /// <summary>
        /// Gets or sets the payload containing details about the call recording error.
        /// </summary>
        [JsonPropertyName("payload")]
        public CallRecordingErrorPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload containing details of the call recording error.
    /// </summary>
    public class CallRecordingErrorPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier for the call control.
        /// This is the Call ID used to issue commands via Call Control API.
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
        /// A call session is a group of related call legs that logically belong to the same phone call,
        /// e.g., an inbound and outbound leg of a transferred call.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the state of the client at the time of the error.
        /// This is the state received from a command.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// Gets or sets the reason for the recording error.
        /// Possible values: [Failed to authorize with storage using custom credentials, 
        /// Invalid credentials json, Unsupported backend, Internal server error].
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}