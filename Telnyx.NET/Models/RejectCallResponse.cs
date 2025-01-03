using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Telnyx API for the Reject Call command.
    /// </summary>
    public class RejectCallResponse : TelnyxResponse<RejectCallResponseData>
    {
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
