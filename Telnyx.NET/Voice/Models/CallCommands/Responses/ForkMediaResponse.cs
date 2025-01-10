using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    public class ForkMediaResponse : TelnyxResponse<ForkMediaResponseData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response.
    /// </summary>
    public class ForkMediaResponseData
    {
        /// <summary>
        /// Gets or sets the result of the fork media operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}
