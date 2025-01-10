using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    /// <summary>
    /// Represents a response model for bridging two calls in the Telnyx API.
    /// </summary>
    public class BridgeCallResponse : TelnyxResponse<BridgeCallResponseData>
    {
    }

    /// <summary>
    /// Represents the data returned in the response.
    /// </summary>
    public class BridgeCallResponseData
    {
        /// <summary>
        /// Gets or sets the result of the bridge call operation.
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}
