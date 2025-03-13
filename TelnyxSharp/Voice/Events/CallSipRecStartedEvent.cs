using System.Text.Json.Serialization;
using TelnyxSharp.Models.Events;

namespace TelnyxSharp.Voice.Events
{
    /// <summary>
    /// Represents the SIPREC started event received from Telnyx.
    /// </summary>
    public class CallSipRecStartedEvent : BaseEvent
    {
        /// <summary>
        /// Gets or sets the payload specific to the SIPREC started event.
        /// </summary>
        [JsonPropertyName("payload")]
        public new SipRecStartedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload for the SIPREC started event.
    /// </summary>
    public class SipRecStartedPayload
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
    }
}
