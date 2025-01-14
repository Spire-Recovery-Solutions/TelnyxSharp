using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for starting the recording of a conference call.
    /// This model allows configuration of various recording settings such as format, beep, trimming, and file naming.
    /// </summary>
    public class StartConferenceRecordingRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the format of the recording (e.g., WAV, MP3).
        /// Default is `Wav`.
        /// </summary>
        [JsonPropertyName("format")]
        public RecordFormat Format { get; set; } = RecordFormat.Wav;

        /// <summary>
        /// Gets or sets the command ID associated with the recording request.
        /// This can be used to track or manage the request.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets whether to play a beep at the start of the recording.
        /// If `true`, a beep sound will be played when the recording starts.
        /// </summary>
        [JsonPropertyName("play_beep")]
        public bool? PlayBeep { get; set; }

        /// <summary>
        /// Gets or sets the trimming option for the recording.
        /// The default value is "trim-silence", which trims silence from the beginning and end of the recording.
        /// </summary>
        [JsonPropertyName("trim")]
        public string? Trim { get; set; } = "trim-silence";

        /// <summary>
        /// Gets or sets a custom file name for the recording.
        /// If not specified, a default file name will be used.
        /// </summary>
        [JsonPropertyName("custom_file_name")]
        public string? CustomFileName { get; set; }
    }
}