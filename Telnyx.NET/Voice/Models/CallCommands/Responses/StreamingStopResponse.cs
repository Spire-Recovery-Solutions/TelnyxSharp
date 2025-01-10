using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for stopping a stream operation.
    /// </summary>
    public class StreamingStopResponse : TelnyxResponse<StreamingStopData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for stopping a stream operation.
    /// </summary>
    public class StreamingStopData
    {
        /// <summary>
        /// Gets or sets the result of the stream stop operation.
        /// This field indicates the status or result of executing the stop stream command.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}