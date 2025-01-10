using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for starting a stream operation.
    /// </summary>
    public class StreamingStartResponse : TelnyxResponse<StreamingStartData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for starting a stream operation.
    /// </summary>
    public class StreamingStartData
    {
        /// <summary>
        /// Gets or sets the result of the stream start operation.
        /// This field indicates the status or result of executing the start stream command.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}