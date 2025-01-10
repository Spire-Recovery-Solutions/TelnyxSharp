using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for stopping the AI assistant in a call.
    /// </summary>
    public class AiAssistantStopResponse : TelnyxResponse<AiAssistantStopData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for stopping the AI assistant.
    /// </summary>
    public class AiAssistantStopData
    {
        /// <summary>
        /// Gets or sets the result of the AI assistant stop operation.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}