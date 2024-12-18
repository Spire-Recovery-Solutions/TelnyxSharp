using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Telnyx API for the Hangup Call command.
    /// </summary>
    public class HangupCallResponse : ITelnyxResponse
    {
        /// <summary>
        /// The data object containing the result of the API call.
        /// </summary>
        [JsonPropertyName("data")]
        public HangupCallResponseData? Data { get; set; }

        /// <summary>
        /// List of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the data object in the Hangup Call response.
    /// </summary>
    public class HangupCallResponseData
    {
         /// <summary>
        /// Result containing the output
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = "Unexpected error";
    }
}
