using System.Text.Json.Serialization;
using TelnyxSharp.Models.Events;

namespace TelnyxSharp.Voice.Events
{
    /// <summary>
    /// Represents an event triggered when a participant stops speaking in a conference.
    /// </summary>
    public class ConferenceParticipantSpeakEndedEvent : BaseEvent
    {
        /// <summary>
        /// Contains the details of the event when a participant stops speaking in a conference.
        /// </summary>
        [JsonPropertyName("payload")]
        public ConferenceParticipantSpeakEndedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a conference participant speak-ended event.
    /// </summary>
    public class ConferenceParticipantSpeakEndedPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier for the call control session.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string Call_control_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the call leg in the conference.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string Call_leg_id { get; set; }

        /// <summary>
        /// Gets or sets the unique session identifier for the entire call session.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the state of the client who was speaking in the conference.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the connection in the conference.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the session ID of the participant who initiated the speaking action.
        /// </summary>
        [JsonPropertyName("creator_call_session_id")]
        public string Creator_call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the conference.
        /// </summary>
        [JsonPropertyName("conference_id")]
        public string Conference_id { get; set; }

        /// <summary>
        /// Gets or sets the timestamp indicating when the participant stopped speaking.
        /// </summary>
        [JsonPropertyName("occurred_at")]
        public string Occurred_at { get; set; }
    }
}