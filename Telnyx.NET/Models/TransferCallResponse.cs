using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Transfer Call API.
    /// </summary>
    public class TransferCallResponse : TelnyxResponse<TransferCallResponseData>
    {
    }

    /// <summary>
    /// Represents the data object contained within the Transfer Call response.
    /// </summary>
    public class TransferCallResponseData
    {
        /// <summary>
        /// Gets or sets the result of the Transfer Call operation.
        /// A successful operation will contain a success message, while an error may provide details about what went wrong.
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}