using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Speak Text API call.
    /// </summary>
    public class SpeakTextResponse : TelnyxResponse<SpeakTextResponseData>
    {
    }

    /// <summary>
    /// Represents the data object in the Speak Text response.
    /// </summary>
    public class SpeakTextResponseData
    {
        /// <summary>
        /// The result of the Speak Text command.
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = "Unexpected error";
    }
}