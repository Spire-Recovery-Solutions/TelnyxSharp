using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event indicating that the audio playback action has ended in a call using the Telnyx platform.
    /// </summary>
    public class CallPlaybackEndedEvent : BaseEvent
    {
        /// <summary>
        /// The payload containing details about the playback ended event, including call identifiers and playback details.
        /// </summary>
        [JsonPropertyName("payload")]
        public CallPlaybackEndedPayload Payload { get; set; }
    }

    /// <summary>
    /// Contains the data for the playback ended event, including details about the call and the media that was played.
    /// </summary>
    public class CallPlaybackEndedPayload
    {
        /// <summary>
        /// Unique identifier for the call control, used to issue commands via the Telnyx Call Control API.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string Call_control_id { get; set; }

        /// <summary>
        /// Unique identifier for the connection (Call Control App ID), formerly known as Telnyx connection ID, used in the call.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string Connection_id { get; set; }

        /// <summary>
        /// Unique identifier for the specific call leg, which can be used to correlate webhook events related to that call leg.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string Call_leg_id { get; set; }

        /// <summary>
        /// Unique identifier for the call session, which groups related call legs that logically belong to the same phone call (e.g., an inbound and outbound leg of a transferred call).
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string Call_session_id { get; set; }

        /// <summary>
        /// A string representing the client state at the time the playback action ended. This is the state received from a previous command.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// The URL of the audio that was played back, if an audio URL was used.
        /// </summary>
        [JsonPropertyName("media_url")]
        public string Media_url { get; set; }

        /// <summary>
        /// The name of the audio media file that was played back, if a media name was used.
        /// </summary>
        [JsonPropertyName("media_name")]
        public string Media_name { get; set; }

        /// <summary>
        /// A boolean value indicating whether the audio was played in overlay mode, allowing the audio to be mixed with existing audio on the call.
        /// </summary>
        [JsonPropertyName("overlay")]
        public bool Overlay { get; set; }

        /// <summary>
        /// The status reflecting how the playback command ended. Possible values are: [file_not_found, call_hangup, unknown, failed, cancelled_amd, completed, failed].
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}