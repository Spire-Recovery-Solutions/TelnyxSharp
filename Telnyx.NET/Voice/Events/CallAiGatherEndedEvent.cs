using System.Text.Json.Serialization;
using Telnyx.NET.Models.Events;
using Telnyx.NET.Voice.Models.CallCommands.Requests;

namespace Telnyx.NET.Voice.Events
{
    /// <summary>
    /// Represents the Call AI Gather Ended event received from Telnyx.
    /// </summary>
    public class CallAiGatherEndedEvent : BaseEvent
    {
        /// <summary>
        /// Gets or sets the payload specific to the Call AI Gather Ended event.
        /// </summary>
        [JsonPropertyName("payload")]
        public new AiGatherEndedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload for the Call AI Gather Ended event.
    /// </summary>
    public class AiGatherEndedPayload
    {
        /// <summary>
        /// Gets or sets the Call Control ID used to issue commands via the Call Control API.
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
        /// Gets or sets the number or SIP URI placing the call.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; }

        /// <summary>
        /// Gets or sets the destination number or SIP URI of the call.
        /// </summary>
        [JsonPropertyName("to")]
        public string To { get; set; }

        /// <summary>
        /// Gets or sets the history of the messages exchanged during the AI gather.
        /// </summary>
        [JsonPropertyName("message_history")]
        public MessageHistory[] MessageHistory { get; set; }

        /// <summary>
        /// Gets or sets the result of the AI gather. The type depends on the parameters provided in the command.
        /// </summary>
        [JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// Gets or sets the status of the AI gather.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
