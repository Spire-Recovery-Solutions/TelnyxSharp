using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents the response for a noise suppression stop operation.
    /// </summary>
    public class NoiseSuppressionStopResponse : TelnyxResponse<NoiseSuppressionStopData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response for a noise suppression stop operation.
    /// </summary>
    public class NoiseSuppressionStopData
    {
        /// <summary>
        /// Gets or sets the result of the noise suppression stop operation.
        /// This field provides the status or result of the operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}