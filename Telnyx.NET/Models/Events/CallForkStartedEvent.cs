using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event triggered when a call fork starts.
    /// Call forking refers to splitting the audio of a call into multiple streams.
    /// </summary>
    public class CallForkStartedEvent : BaseEvent
    {
        /// <summary>
        /// Contains detailed information about the call fork started event.
        /// </summary>
        [JsonPropertyName("payload")]
        public CallForkStartedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a call fork started event.
    /// </summary>
    public class CallForkStartedPayload
    {
        /// <summary>
        /// Gets or sets the identifier for the connection associated with the call.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for call control actions.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string Call_control_id { get; set; }

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
        /// Gets or sets the type of stream associated with the forked audio.
        /// Common values might include audio formats or specific fork stream identifiers.
        /// </summary>
        [JsonPropertyName("stream_type")]
        public string Stream_type { get; set; }
    }
}