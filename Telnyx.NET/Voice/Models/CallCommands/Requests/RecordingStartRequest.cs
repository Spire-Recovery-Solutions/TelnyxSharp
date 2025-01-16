using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to start recording a call.
    /// </summary>
    public class RecordingStartRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the format of the recording. Defines whether the recording is in MP3, WAV, etc.
        /// </summary>
        [JsonPropertyName("format")]
        public RecordFormat Format { get; set; }

        /// <summary>
        /// Gets or sets the channels for the recording. Defines whether the recording is mono or stereo.
        /// </summary>
        [JsonPropertyName("channels")]
        public RecordChannels Channels { get; set; }

        /// <summary>
        /// Gets or sets the client state associated with the recording start request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for the recording start request.
        /// This ID can be used for tracking and managing multiple requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to play a beep at the start of the recording.
        /// </summary>
        [JsonPropertyName("play_beep")]
        public bool? PlayBeep { get; set; }

        /// <summary>
        /// Gets or sets the maximum length of the recording in seconds.
        /// </summary>
        [JsonPropertyName("max_length")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Gets or sets the timeout duration in seconds for the recording.
        /// </summary>
        [JsonPropertyName("timeout_secs")]
        public int? TimeoutSecs { get; set; }

        /// <summary>
        /// Gets or sets the recording track type. Defines if the recording is inbound, outbound, or both.
        /// </summary>
        [JsonPropertyName("recording_track")]
        public RecordTrack? RecordingTrack { get; set; }

        /// <summary>
        /// Gets or sets whether to trim silence from the recording. Defaults to "trim-silence".
        /// </summary>
        [JsonPropertyName("trim")]
        public string? Trim { get; set; } = "trim-silence";

        /// <summary>
        /// Gets or sets a custom file name for the recording.
        /// </summary>
        [JsonPropertyName("custom_file_name")]
        public string? CustomFileName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether transcription is enabled for the recording.
        /// </summary>
        [JsonPropertyName("transcription")]
        public bool? Transcription { get; set; }

        /// <summary>
        /// Gets or sets the transcription engine to use (e.g., Google, Telnyx).
        /// </summary>
        [JsonPropertyName("transcription_engine")]
        public TranscriptionEngine? TranscriptionEngine { get; set; }

        /// <summary>
        /// Gets or sets the configuration for the transcription language.
        /// </summary>
        [JsonPropertyName("transcription_language")]
        public TranscriptionLanguageConfig? TranscriptionLanguage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to filter profanity in the transcription.
        /// </summary>
        [JsonPropertyName("transcription_profanity_filter")]
        public bool? TranscriptionProfanityFilter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether speaker diarization (identifying multiple speakers) is enabled in the transcription.
        /// </summary>
        [JsonPropertyName("transcription_speaker_diarization")]
        public bool? TranscriptionSpeakerDiarization { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of speakers expected in the transcription.
        /// </summary>
        [JsonPropertyName("transcription_min_speaker_count")]
        public int? TranscriptionMinSpeakerCount { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of speakers expected in the transcription.
        /// </summary>
        [JsonPropertyName("transcription_max_speaker_count")]
        public int? TranscriptionMaxSpeakerCount { get; set; }
    }

    /// <summary>
    /// Base class for transcription language configuration.
    /// </summary>
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(GoogleTranscriptionLanguageConfig), "google")]
    [JsonDerivedType(typeof(TelnyxTranscriptionLanguageConfig), "telnyx")]
    public abstract class TranscriptionLanguageConfig
    {
    }

    /// <summary>
    /// Represents a Google-specific transcription language configuration.
    /// </summary>
    public class GoogleTranscriptionLanguageConfig : TranscriptionLanguageConfig
    {
        /// <summary>
        /// Gets or sets the language code for Google transcription.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }  // Accepts Google-specific language codes
    }

    /// <summary>
    /// Represents a Telnyx-specific transcription language configuration.
    /// </summary>
    public class TelnyxTranscriptionLanguageConfig : TranscriptionLanguageConfig
    {
        /// <summary>
        /// Gets or sets the language code for Telnyx transcription.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }  // Accepts Telnyx-specific language codes
    }
}