using System.Text.Json.Serialization;
using Telnyx.NET.Models.Events;

namespace Telnyx.NET.Voice.Events
{
    /// <summary>
    /// Represents an event triggered when a DTMF (Dual-Tone Multi-Frequency) signal is received during a call.
    /// </summary>
    public class CallDtmfReceivedEvent : BaseEvent
    {
        /// <summary>
        /// Contains detailed information about the DTMF received event.
        /// </summary>
        [JsonPropertyName("payload")]
        public CallDtmfReceivedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a DTMF received event.
    /// </summary>
    public class CallDtmfReceivedPayload
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
        /// Gets or sets the originating phone number.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; }

        /// <summary>
        /// Gets or sets the destination phone number.
        /// </summary>
        [JsonPropertyName("to")]
        public string To { get; set; }

        /// <summary>
        /// Gets or sets the DTMF digit that was received.
        /// </summary>
        [JsonPropertyName("digit")]
        public string Digit { get; set; }
    }
}