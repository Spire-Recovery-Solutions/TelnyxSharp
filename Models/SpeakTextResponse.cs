using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Speak Text API call.
    /// </summary>
    public class SpeakTextResponse : ITelnyxResponse
    {
        /// <summary>
        /// The data object containing the result of the Speak Text API call.
        /// </summary>
        [JsonPropertyName("data")]
        public SpeakTextResponseData? Data { get; set; }

        /// <summary>
        /// List of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
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