using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for starting an AI assistant in a call.
    /// </summary>
    public class AiAssistantStartResponse : TelnyxResponse<AiAssistantStartData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for starting the AI assistant.
    /// </summary>
    public class AiAssistantStartData
    {
        /// <summary>
        /// Gets or sets the result of the AI assistant start operation.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}