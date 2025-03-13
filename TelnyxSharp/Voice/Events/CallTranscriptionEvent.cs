using System.Text.Json.Serialization;
using TelnyxSharp.Models.Events;

namespace TelnyxSharp.Voice.Events
{
    /// <summary>
    /// Represents an event related to transcription in a call session.
    /// </summary>
    public class CallTranscriptionEvent : BaseEvent
    {
        /// <summary>
        /// Gets or sets the payload containing transcription data and associated details.
        /// </summary>
        [JsonPropertyName("payload")]
        public TranscriptionPayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload of a transcription event.
    /// </summary>
    public class TranscriptionPayload
    {
        /// <summary>
        /// Gets or sets the call control ID.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string Call_control_id { get; set; }

        /// <summary>
        /// Gets or sets the call leg ID.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string Call_leg_id { get; set; }

        /// <summary>
        /// Gets or sets the call session ID.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// Gets or sets the client state associated with the transcription.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// Gets or sets the connection ID related to the transcription.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Gets or sets the transcription data, including confidence, finality, and the transcript.
        /// </summary>
        [JsonPropertyName("transcription_data")]
        public TranscriptionData Transcription_data { get; set; }
    }
}