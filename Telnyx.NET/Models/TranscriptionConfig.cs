using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the configuration settings for transcribing audio in a call.
    /// This includes settings for the transcription engine, language, interim results,
    /// client state, transcription tracks, and command ID to avoid duplicate commands.
    /// Default values and possible options for each setting are also specified.
    /// </summary>
    public class TranscriptionConfig
    {
        /// <summary>
        /// Gets or sets the transcription engine to be used. 
        /// Possible values: [A (Google), B (Telnyx)]. Default value: A.
        /// This specifies which engine will handle the transcription of the audio.
        /// </summary>
        [JsonPropertyName("transcription_engine")]
        public string? TranscriptionEngine { get; set; }

        /// <summary>
        /// Gets or sets the language code for the transcription. 
        /// This specifies the language in which the audio is being spoken.
        /// Possible values include: [af, sq, am, ar, hy, az, eu, bn, bs, bg, my, ca, yue, zh,
        /// hr, cs, da, nl, en, et, fil, fi, fr, gl, ka, de, el, gu, iw, hi, hu, is, id, it, 
        /// ja, jv, kn, kk, km, ko, lo, lv, lt, mk, ms, ml, mr, mn, ne, no, fa, pl, pt, pa, 
        /// ro, ru, rw, sr, si, sk, sl, ss, st, es, su, sw, sv, ta, te, th, tn, tr, ts, 
        /// uk, ur, uz, ve, vi, xh, zu].
        /// </summary>
        [JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether interim results are requested. 
        /// If true, interim results will be provided as they become available.
        /// This applies only to the Google transcription engine.
        /// </summary>
        [JsonPropertyName("interim_results")]
        public bool? InterimResults { get; set; }

        /// <summary>
        /// Gets or sets the client state for associating the transcription with the client's state. 
        /// This must be a valid Base-64 encoded string.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the transcription tracks to be used. 
        /// Default value: inbound. This specifies which audio tracks to transcribe 
        /// if multiple tracks are available. Options include: inbound, outbound, both.
        /// </summary>
        [JsonPropertyName("transcription_tracks")]
        public string? TranscriptionTracks { get; set; }

        /// <summary>
        /// Gets or sets the command ID to avoid duplicate commands. 
        /// Telnyx will ignore any command with the same command_id for the same call_control_id.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}