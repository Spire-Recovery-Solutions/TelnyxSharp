using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event indicating that a call has left a queue.
    /// </summary>
    public class CallLeftQueueEvent : BaseEvent
    {
        /// <summary>
        /// Gets or sets the payload containing details about the call left queue event.
        /// </summary>
        [JsonPropertyName("payload")]
        public CallLeftQueuePayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload containing details of the call left queue event.
    /// </summary>
    public class CallLeftQueuePayload
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
        /// Gets or sets the unique identifier for the call leg that can be used to correlate webhook events.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string Call_leg_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the call session that can be used to correlate webhook events.
        /// Call session is a group of related call legs that logically belong to the same phone call.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the state received from a command when the call left the queue.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// Gets or sets the name of the queue from which the call left.
        /// </summary>
        [JsonPropertyName("queue")]
        public string Queue { get; set; }

        /// <summary>
        /// Gets or sets the last position of the call in the queue when it left.
        /// </summary>
        [JsonPropertyName("queue_position")]
        public int Queue_position { get; set; }

        /// <summary>
        /// Gets or sets the reason the call left the queue.
        /// Possible values include: [bridged, bridging-in-process, hangup, leave, timeout].
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}