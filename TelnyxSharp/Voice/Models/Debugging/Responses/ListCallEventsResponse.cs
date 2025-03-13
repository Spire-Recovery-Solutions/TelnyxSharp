using System.Text.Json.Serialization;
using TelnyxSharp.Enums;
using TelnyxSharp.Models;

namespace TelnyxSharp.Voice.Models.Debugging.Responses
{
    /// <summary>
    /// Represents the response containing a list of call events.
    /// Inherits from <see cref="TelnyxResponse{TData}"/>.
    /// </summary>
    public class ListCallEventsResponse : TelnyxResponse<ListCallEventsData>
    {
    }

    /// <summary>
    /// Represents the data for individual call events.
    /// Contains details such as call leg ID, session ID, event timestamp, event type, and metadata.
    /// </summary>
    public class ListCallEventsData
    {
        /// <summary>
        /// The type of record, which is always "call_event" for this response.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = "call_event";

        /// <summary>
        /// The unique identifier for the call leg.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string CallLegId { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier for the call session.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string CallSessionId { get; set; } = string.Empty;

        /// <summary>
        /// The timestamp of the event.
        /// </summary>
        [JsonPropertyName("event_timestamp")]
        public string EventTimestamp { get; set; } = string.Empty;

        /// <summary>
        /// The name of the event.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The type of the event (e.g., Command, Webhook).
        /// </summary>
        [JsonPropertyName("type")]
        public EventType Type { get; set; }

        /// <summary>
        /// Additional metadata related to the call event.
        /// This can contain key-value pairs that provide extra details about the event.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, object> Metadata { get; set; } = new();
    }
}