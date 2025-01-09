using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response received from the Telnyx API when stopping audio playback on a call.
    /// </summary>
    public class PlaybackStartResponse : TelnyxResponse<PlaybackStartResponseData>
    {
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