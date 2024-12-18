using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Transfer Call API.
    /// </summary>
    public class TransferCallResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the data object containing the result of the Transfer Call operation.
        /// </summary>
        [JsonPropertyName("data")]
        public TransferCallResponseData? Data { get; set; }

        /// <summary>
        /// Gets or sets the list of errors encountered during the API call, if any.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
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