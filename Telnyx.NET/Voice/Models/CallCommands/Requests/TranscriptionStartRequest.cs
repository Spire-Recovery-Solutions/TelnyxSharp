using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to start transcription for a call, with configurations for transcription engine, 
    /// language, speaker diarization, and other related options.
    /// </summary>
    public class TranscriptionStartRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the transcription engine to be used for processing the transcription.
        /// Default is set to Google transcription engine.
        /// </summary>
        [JsonPropertyName("transcription_engine")]
        public TranscriptionEngine TranscriptionEngine { get; set; } = TranscriptionEngine.Google;

        /// <summary>
        /// Gets or sets the transcription language configuration. This property can specify a specific language 
        /// model for the transcription engine to use (e.g., Google or Telnyx specific language configurations).
        /// </summary>
        [JsonPropertyName("language")]
        public TranscriptionLanguageConfig? Language { get; set; }

        /// <summary>
        /// Gets or sets a flag to determine whether interim (in-progress) results should be provided during transcription.
        /// </summary>
        [JsonPropertyName("interim_results")]
        public bool? InterimResults { get; set; }

        /// <summary>
        /// Gets or sets a flag to enable speaker diarization (distinguishing between different speakers) during transcription.
        /// </summary>
        [JsonPropertyName("enable_speaker_diarization")]
        public bool? EnableSpeakerDiarization { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of speakers expected for transcription.
        /// Default is 2 speakers.
        /// </summary>
        [JsonPropertyName("min_speaker_count")]
        public int MinSpeakerCount { get; set; } = 2;

        /// <summary>
        /// Gets or sets the maximum number of speakers expected for transcription.
        /// Default is 6 speakers.
        /// </summary>
        [JsonPropertyName("max_speaker_count")]
        public int MaxSpeakerCount { get; set; } = 6;

        /// <summary>
        /// Gets or sets the client state associated with the transcription request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the specific tracks to be transcribed (e.g., inbound or outbound tracks).
        /// Default is set to "inbound".
        /// </summary>
        [JsonPropertyName("transcription_tracks")]
        public string TranscriptionTracks { get; set; } = "inbound";

        /// <summary>
        /// Gets or sets the unique command ID for the transcription start request.
        /// This ID is used for tracking and managing multiple requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}