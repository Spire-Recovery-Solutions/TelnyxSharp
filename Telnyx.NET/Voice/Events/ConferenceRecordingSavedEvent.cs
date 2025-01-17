using System.Text.Json.Serialization;
using Telnyx.NET.Models.Events;

namespace Telnyx.NET.Voice.Events
{
    /// <summary>
    /// Represents an event triggered when a conference recording is saved.
    /// </summary>
    public class ConferenceRecordingSavedEvent : BaseEvent
    {
        /// <summary>
        /// Contains the details of the saved conference recording event.
        /// </summary>
        [JsonPropertyName("payload")]
        public ConferenceRecordingSavedPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload data for a conference recording-saved event.
    /// </summary>
    public class ConferenceRecordingSavedPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier for the call control of the conference.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string Call_control_id { get; set; }

        /// <summary>
        /// Gets or sets the session ID associated with the call in the conference.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the state of the client associated with the conference.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// Gets or sets the channels included in the conference recording.
        /// </summary>
        [JsonPropertyName("channels")]
        public string Channels { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the conference.
        /// </summary>
        [JsonPropertyName("conference_id")]
        public string Conference_id { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the connection within the conference.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the format of the saved recording (e.g., MP3, WAV).
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the public URLs of the saved recording.
        /// </summary>
        [JsonPropertyName("public_recording_urls")]
        public object Public_recording_urls { get; set; }

        /// <summary>
        /// Gets or sets the timestamp indicating when the recording ended.
        /// </summary>
        [JsonPropertyName("recording_ended_at")]
        public string Recording_ended_at { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the saved recording.
        /// </summary>
        [JsonPropertyName("recording_id")]
        public string Recording_id { get; set; }

        /// <summary>
        /// Gets or sets the timestamp indicating when the recording started.
        /// </summary>
        [JsonPropertyName("recording_started_at")]
        public string Recording_started_at { get; set; }

        /// <summary>
        /// Gets or sets the URLs of the saved recording.
        /// </summary>
        [JsonPropertyName("recording_urls")]
        public object Recording_urls { get; set; }
    }
}