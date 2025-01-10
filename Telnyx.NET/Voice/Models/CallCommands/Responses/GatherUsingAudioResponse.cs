using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for a gather operation using audio in a call.
    /// </summary>
    public class GatherUsingAudioResponse : TelnyxResponse<GatherUsingAudioData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for a gather operation using audio.
    /// </summary>
    public class GatherUsingAudioData
    {
        /// <summary>
        /// Gets or sets the result of the gather operation using audio.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}