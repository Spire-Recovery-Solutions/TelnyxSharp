using System.Text.Json.Serialization;
using TelnyxSharp.Models.Events;

namespace TelnyxSharp.Voice.Events
{
    /// <summary>
    /// Represents an event indicating that audio playback has started in a call using the Telnyx platform.
    /// </summary>
    public class CallPlaybackStartedEvent : BaseEvent
    {
        /// <summary>
        /// The payload containing details about the playback started event, including call identifiers and playback details.
        /// </summary>
        [JsonPropertyName("payload")]
        public CallPlaybackStartedPayload Payload { get; set; }
    }

    /// <summary>
    /// Contains the data for the playback started event, including details about the call and the media being played.
    /// </summary>
    public class CallPlaybackStartedPayload
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
        /// A string representing the client state at the time the playback action started. This is the state received from a previous command.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string Client_state { get; set; }

        /// <summary>
        /// The URL of the audio being played back, if an audio URL was used to start playback.
        /// </summary>
        [JsonPropertyName("media_url")]
        public string Media_url { get; set; }

        /// <summary>
        /// The name of the audio media file being played back, if a media name was used to start playback.
        /// </summary>
        [JsonPropertyName("media_name")]
        public string Media_name { get; set; }

        /// <summary>
        /// A boolean value indicating whether the audio is being played in overlay mode, allowing the audio to be mixed with existing audio on the call.
        /// </summary>
        [JsonPropertyName("overlay")]
        public bool Overlay { get; set; }
    }
}