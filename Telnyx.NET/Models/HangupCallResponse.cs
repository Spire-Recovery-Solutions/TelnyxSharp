using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Telnyx API for the Hangup Call command.
    /// </summary>
    public class HangupCallResponse : TelnyxResponse<HangupCallResponseData>
    {
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
