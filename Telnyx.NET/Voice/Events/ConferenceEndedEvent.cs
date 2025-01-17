using System.Text.Json.Serialization;
using Telnyx.NET.Models.Events;

namespace Telnyx.NET.Voice.Events
{
    /// <summary>
    /// Represents an event triggered when a conference call has ended.
    /// This event provides details about the conference's end, including session and connection information.
    /// </summary>
    public class ConferenceEndedEvent : BaseEvent
    {
        /// <summary>
        /// Contains detailed information about the conference ending event.
        /// </summary>
        [JsonPropertyName("payload")]
        public ConferenceEndedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a conference ended event.
    /// </summary>
    public class ConferenceEndedPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier for the call control session.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string Call_control_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the connection associated with the conference.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the call leg.
        /// A call leg represents a specific part of a call, such as an inbound or outbound connection.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string Call_leg_id { get; set; }

        /// <summary>
        /// Gets or sets the unique session identifier for the entire call session.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the state of the client involved in the conference.
        /// This value can represent various client states during the conference.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the conference.
        /// </summary>
        [JsonPropertyName("conference_id")]
        public string Conference_id { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the conference ended.
        /// </summary>
        [JsonPropertyName("occurred_at")]
        public string Occurred_at { get; set; }

        /// <summary>
        /// Gets or sets the reason why the conference ended.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}