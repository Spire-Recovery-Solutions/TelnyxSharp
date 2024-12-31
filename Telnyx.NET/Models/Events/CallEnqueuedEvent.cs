using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event indicating that a call has been enqueued.
    /// </summary>
    public class CallEnqueuedEvent : BaseEvent
    {
        /// <summary>
        /// Gets or sets the payload containing details about the enqueued call event.
        /// </summary>
        [JsonPropertyName("payload")]
        public CallEnqueuedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload containing details of the enqueued call event.
    /// </summary>
    public class CallEnqueuedPayload
    {
        /// <summary>
        /// Gets or sets the Call ID used to issue commands via the Call Control API.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string Call_control_id { get; set; }

        /// <summary>
        /// Gets or sets the Call Control App ID (formerly Telnyx connection ID) used in the call.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the call leg.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string Call_leg_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the call session.
        /// Call session is a group of related call legs that logically belong to the same phone call.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the state received from a command.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// Gets or sets the name of the queue where the call is enqueued.
        /// </summary>
        [JsonPropertyName("queue")]
        public string Queue { get; set; }

        /// <summary>
        /// Gets or sets the current position of the call in the queue.
        /// </summary>
        [JsonPropertyName("current_position")]
        public int Current_position { get; set; }
    }
}