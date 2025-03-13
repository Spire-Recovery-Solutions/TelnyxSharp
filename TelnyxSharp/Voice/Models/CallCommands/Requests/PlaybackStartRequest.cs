using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to play an audio file on a call using the Telnyx Call Control API.
    /// This request supports playing audio from a URL or from previously uploaded media.
    /// Additional features include looping, overlaying audio, and stopping currently playing audio.
    /// </summary>
    public class PlaybackStartRequest : ITelnyxRequest
    {
        /// <summary>
        /// The URL of the audio file to be played on the call. Only WAV and MP3 files are supported.
        /// Either `audio_url` or `media_name` must be provided, but not both.
        /// </summary>
        [JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// The name of a media file previously uploaded to the Telnyx platform.
        /// Only WAV and MP3 files are supported. This cannot be used in conjunction with `audio_url`.
        /// </summary>
        [JsonPropertyName("media_name")]
        public string? MediaName { get; set; } // Optional, can be null

        /// <summary>
        /// Specifies how many times the audio file should be played.
        /// The value can be an integer between 1 and 100, or the string "infinity" for endless playback.
        /// </summary>
        [JsonPropertyName("loop")]
        public string? Loop { get; set; } // Use string for "infinity" or other loop values

        /// <summary>
        /// If enabled, the audio will be mixed on top of any currently playing audio.
        /// Overlay works only if there is already audio being played on the call.
        /// </summary>
        [JsonPropertyName("overlay")]
        public bool? Overlay { get; set; }

        /// <summary>
        /// Stops the current audio playback. Set to "current" to stop the current file and play the next in queue,
        /// or set to "all" to stop and clear all queued audio files.
        /// </summary>
        [JsonPropertyName("stop")]
        public string? Stop { get; set; } // Options: "current" or "all"

        /// <summary>
        /// Specifies the leg(s) on which the audio will be played.
        /// Valid values are "self" (default), "opposite", or "both".
        /// </summary>
        [JsonPropertyName("target_legs")]
        public string? TargetLegs { get; set; } // Default: "self"

        /// <summary>
        /// Determines if the audio file should be cached for reuse during the call.
        /// The default value is true, which is useful for playing the same audio multiple times.
        /// </summary>
        [JsonPropertyName("cache_audio")]
        public bool? CacheAudio { get; set; } // Default value

        /// <summary>
        /// Specifies the type of audio provided in `audio_url` or `playback_content`. 
        /// The valid values are "mp3" (default) and "wav".
        /// </summary>
        [JsonPropertyName("audio_type")]
        public string? AudioType { get; set; } // Default value, can be "mp3" or "wav"

        /// <summary>
        /// A Base64 encoded string representing the audio content. This can be used instead of `audio_url` or `media_name`.
        /// </summary>
        [JsonPropertyName("playback_content")]
        public string? PlaybackContent { get; set; } // Optional, can be null

        /// <summary>
        /// A Base64 encoded string that will be passed with each subsequent webhook for tracking state.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; } // Base64 encoded string

        /// <summary>
        /// A unique identifier used to prevent duplicate commands. Any command with the same
        /// `command_id` for the same `call_control_id` will be ignored.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; } // Unique command identifier
    }
}