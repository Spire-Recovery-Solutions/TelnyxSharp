using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request model for bridging two calls in the Telnyx API.
    /// </summary>
    public class BridgeCallRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the Call Control ID of the call to bridge with.
        /// Cannot be used together with the queue or video_room_id parameters.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public required string CallControlId { get; set; }

        /// <summary>
        /// Gets or sets the client state to include in subsequent webhooks.
        /// Must be a valid Base-64 encoded string.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the command ID to prevent duplicate commands.
        /// Telnyx ignores commands with the same command_id for the same call_control_id.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets the name of the queue to bridge with.
        /// Cannot be used together with call_control_id or video_room_id parameters.
        /// </summary>
        [JsonPropertyName("queue")]
        public string? Queue { get; set; }

        /// <summary>
        /// Gets or sets the ID of the video room to bridge with.
        /// Cannot be used together with call_control_id or queue parameters.
        /// </summary>
        [JsonPropertyName("video_room_id")]
        public string? VideoRoomId { get; set; }

        /// <summary>
        /// Gets or sets additional parameters for the video conference.
        /// Can only be used with the video_room_id parameter.
        /// </summary>
        [JsonPropertyName("video_room_context")]
        public string? VideoRoomContext { get; set; }

        /// <summary>
        /// Gets or sets the behavior after the bridge ends.
        /// Use "self" to park the current leg after unbridge.
        /// Default behavior is to hang up the leg.
        /// </summary>
        [JsonPropertyName("park_after_unbridge")]
        public string? ParkAfterUnbridge { get; set; }

        /// <summary>
        /// Gets or sets whether to play a ringtone if the call to bridge with has not been answered.
        /// </summary>
        [JsonPropertyName("play_ringtone")]
        public bool? PlayRingtone { get; set; }

        /// <summary>
        /// Gets or sets the country ringtone to play.
        /// Default is "us".
        /// </summary>
        [JsonPropertyName("ringtone")]
        public RingtoneCountry? Ringtone { get; set; }

        /// <summary>
        /// Gets or sets the recording option to start automatically after an event.
        /// Disabled by default.
        /// </summary>
        [JsonPropertyName("record")]
        public string? Record { get; set; }

        /// <summary>
        /// Gets or sets the recording channel configuration.
        /// Default is "dual".
        /// </summary>
        [JsonPropertyName("record_channels")]
        public RecordChannels? RecordChannels { get; set; } = Enums.RecordChannels.Dual;

        /// <summary>
        /// Gets or sets the recording format.
        /// Default is "mp3".
        /// </summary>
        [JsonPropertyName("record_format")]
        public RecordFormat? RecordFormat { get; set; } = Enums.RecordFormat.Mp3;

        /// <summary>
        /// Gets or sets the maximum length for the recording in seconds.
        /// Default is 0 (infinite).
        /// </summary>
        [JsonPropertyName("record_max_length")]
        public int? RecordMaxLength { get; set; } = 0;

        /// <summary>
        /// Gets or sets the timeout in seconds for stopping the recording if silence is detected.
        /// Default is 0 (infinite).
        /// </summary>
        [JsonPropertyName("record_timeout_secs")]
        public int? RecordTimeoutSecs { get; set; } = 0;

        /// <summary>
        /// Gets or sets the audio track to be recorded.
        /// Default is "both".
        /// </summary>
        [JsonPropertyName("record_track")]
        public RecordTrack? RecordTrack { get; set; } = Enums.RecordTrack.Both;

        /// <summary>
        /// Gets or sets the option to trim silence from the recording.
        /// </summary>
        [JsonPropertyName("record_trim")]
        public string? RecordTrim { get; set; }

        /// <summary>
        /// Gets or sets the custom recording file name.
        /// Cannot exceed 40 characters.
        /// </summary>
        [JsonPropertyName("record_custom_file_name")]
        public string? RecordCustomFileName { get; set; }
    }
}
