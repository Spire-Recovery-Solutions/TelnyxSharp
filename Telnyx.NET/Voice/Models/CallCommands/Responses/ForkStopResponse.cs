using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    public class ForkStopResponse : TelnyxResponse<ForkStopResponseData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response.
    /// </summary>
    public class ForkStopResponseData
    {
        /// <summary>
        /// Gets or sets the result of the fork media stop operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}
