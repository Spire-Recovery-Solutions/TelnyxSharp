using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response received after attempting to stop audio playback on a call.
    /// </summary>
    public class StopAudioPlaybackResponse : TelnyxResponse<StopAudioPlaybackResponseData>
    {
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