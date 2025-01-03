using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Telnyx API for the Answer Call command.
    /// </summary>
    public class AnswerCallResponse : TelnyxResponse<AnswerCallResponseData>
    {

    }

    /// <summary>
    /// Represents the data object in the Answer Call response.
    /// </summary>
    public class AnswerCallResponseData
    {
        /// <summary>
        /// The result of the Answer Call command.
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = "Unexpected error";
    }
}
