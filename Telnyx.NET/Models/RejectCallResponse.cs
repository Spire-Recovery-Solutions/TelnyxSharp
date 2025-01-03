using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Telnyx API for the Reject Call command.
    /// </summary>
    public class RejectCallResponse : TelnyxResponse
    {
        /// <summary>
        /// The data object containing the result of the API call.
        /// </summary>
        [JsonPropertyName("data")]
        public RejectCallResponseData? Data { get; set; }

        /// <summary>
        /// List of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the data object in the Reject Call response.
    /// </summary>
    public class RejectCallResponseData
    {
        /// <summary>
        /// The result of the Reject Call command.
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = "Unexpected error";
    }
}
