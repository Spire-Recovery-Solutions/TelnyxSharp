using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for stopping the gather operation in a call.
    /// </summary>
    public class GatherStopResponse : TelnyxResponse<GatherStopData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for stopping the gather operation.
    /// </summary>
    public class GatherStopData
    {
        /// <summary>
        /// Gets or sets the result of the gather stop operation.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}