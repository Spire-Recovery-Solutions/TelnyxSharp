using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.CallCommands.Responses
{
    public class GatherResponse : TelnyxResponse<GatherResponseData>
    {
    }

    /// <summary>
    /// Represents the data object in the gather response.
    /// </summary>
    public class GatherResponseData
    {
        [JsonPropertyName("result")]
        public string? Result { get; set; }
    }
}
