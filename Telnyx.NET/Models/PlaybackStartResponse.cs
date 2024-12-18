using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response received from the Telnyx API when stopping audio playback on a call.
    /// </summary>
    public class PlaybackStartResponse : ITelnyxResponse
    {
        /// <summary>
        /// The data returned from the API response.
        /// </summary>
        [JsonPropertyName("data")]
        public PlaybackStartResponseData? Data { get; set; }

        /// <summary>
        /// The list of errors, if any, returned from the API response.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains the result of the stop audio playback request.
    /// </summary>
    public class PlaybackStartResponseData
    {
        /// <summary>
        /// The result of the stop playback operation. 
        /// Default value is "Unexpected error" in case of an issue.
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = "Unexpected error"; // Default value
    }
}