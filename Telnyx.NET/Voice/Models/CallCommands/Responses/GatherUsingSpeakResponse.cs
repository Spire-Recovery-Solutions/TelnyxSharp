using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for a gather operation using speech in a call.
    /// </summary>
    public class GatherUsingSpeakResponse : TelnyxResponse<GatherUsingSpeakData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for a gather operation using speech.
    /// </summary>
    public class GatherUsingSpeakData
    {
        /// <summary>
        /// Gets or sets the result of the gather operation using speech.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}