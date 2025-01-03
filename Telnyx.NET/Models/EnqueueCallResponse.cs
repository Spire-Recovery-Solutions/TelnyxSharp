using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Enqueue Call API.
    /// </summary>
    public class EnqueueCallResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the data returned from the API, containing the result of the enqueue operation.
        /// </summary>
        [JsonPropertyName("data")]
        public EnqueueCallResponseData? Data { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// This property is nullable to indicate that it may not always be present.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the data returned in the Enqueue Call response.
    /// </summary>
    public class EnqueueCallResponseData
    {
        /// <summary>
        /// Gets or sets the result of the enqueue operation.
        /// Default value is "Unexpected error" to handle cases where the result is not provided.
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = "Unexpected error"; // Default value
    }
}