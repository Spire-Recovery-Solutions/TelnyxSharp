using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for a gather operation using AI in a call.
    /// </summary>
    public class GatherUsingAiResponse : TelnyxResponse<GatherUsingAiResult>
    {
    }

    /// <summary>
    /// Represents the result data returned in the response for a gather operation using AI.
    /// </summary>
    public class GatherUsingAiResult
    {
        /// <summary>
        /// Gets or sets the result of the gather operation using AI.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}