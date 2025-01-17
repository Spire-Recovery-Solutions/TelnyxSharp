using System.Text.Json.Serialization;
using Telnyx.NET.Models.Events;

namespace Telnyx.NET.Voice.Events
{
    /// <summary>
    /// Represents the SIPREC stopped event received from Telnyx.
    /// </summary>
    public class CallSipRecStoppedEvent : BaseEvent
    {
        /// <summary>
        /// Gets or sets the payload specific to the SIPREC stopped event.
        /// </summary>
        [JsonPropertyName("payload")]
        public new SipRecStoppedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload for the SIPREC stopped event.
    /// </summary>
    public class SipRecStoppedPayload
    {
        /// <summary>
        /// Gets or sets the call control ID used to issue commands via the Call Control API.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string CallControlId { get; set; }

        /// <summary>
        /// Gets or sets the Call Control App ID (formerly Telnyx connection ID) used in the call.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the ID that is unique to the call and can be used to correlate webhook events.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string CallLegId { get; set; }

        /// <summary>
        /// Gets or sets the ID that is unique to the call session and can be used to correlate webhook events.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string CallSessionId { get; set; }

        /// <summary>
        /// Gets or sets the state received from a command.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string ClientState { get; set; }

        /// <summary>
        /// Gets or sets the Q850 reason why the SIPREC session was stopped.
        /// </summary>
        [JsonPropertyName("hangup_cause")]
        public string HangupCause { get; set; }
    }
}
