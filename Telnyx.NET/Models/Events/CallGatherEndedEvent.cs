using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a call gather operation ends.
    /// A gather operation collects user input during a call, such as DTMF tones.
    /// </summary>
    public class CallGatherEndedEvent : BaseEvent
    {
        /// <summary>
        /// Contains detailed information about the call gather ended event.
        /// </summary>
        [JsonPropertyName("payload")]
        public CallGatherEndedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a call gather ended event.
    /// </summary>
    public class CallGatherEndedPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier for call control actions.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string Call_control_id { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the connection associated with the call.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the specific leg of the call.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string Call_leg_id { get; set; }

        /// <summary>
        /// Gets or sets the unique session identifier for the call.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the custom client state for the call, if provided.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// Gets or sets the number or address of the call's originator.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; }

        /// <summary>
        /// Gets or sets the number or address of the call's recipient.
        /// </summary>
        [JsonPropertyName("to")]
        public string To { get; set; }

        /// <summary>
        /// Gets or sets the digits collected during the gather operation.
        /// This typically contains user input, such as DTMF tones.
        /// </summary>
        [JsonPropertyName("digits")]
        public string Digits { get; set; }

        /// <summary>
        /// Gets or sets the status of the gather operation.
        /// The status indicates whether the operation was successful or encountered issues.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}