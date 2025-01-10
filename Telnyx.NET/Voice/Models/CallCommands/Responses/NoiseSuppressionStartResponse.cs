using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for a noise suppression start operation.
    /// </summary>
    public class NoiseSuppressionStartResponse : TelnyxResponse<NoiseSuppressionStartData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for a noise suppression start operation.
    /// </summary>
    public class NoiseSuppressionStartData
    {
        /// <summary>
        /// Gets or sets the result of the noise suppression start operation.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}