using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for a recording start operation.
    /// </summary>
    public class RecordingStartResponse : TelnyxResponse<RecordingStartData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for a recording start operation.
    /// </summary>
    public class RecordingStartData
    {
        /// <summary>
        /// Gets or sets the result of the recording start operation.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}