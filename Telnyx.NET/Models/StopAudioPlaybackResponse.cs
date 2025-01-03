using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response received after attempting to stop audio playback on a call.
    /// </summary>
    public class StopAudioPlaybackResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the data returned in the response, which contains the result of the stop audio playback action.
        /// </summary>
        [JsonPropertyName("data")]
        public StopAudioPlaybackResponseData? Data { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the request.
        /// This will contain details of errors if the operation was unsuccessful.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the data portion of the response for the stop audio playback request.
    /// </summary>
    public class StopAudioPlaybackResponseData
    {
        /// <summary>
        /// Gets or sets the result of the stop audio playback action.
        /// This indicates the outcome of the request. The default value is "Unexpected error".
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = "Unexpected error"; // Default value.
    }
}