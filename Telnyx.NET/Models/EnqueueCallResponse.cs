using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Enqueue Call API.
    /// </summary>
    public class EnqueueCallResponse : TelnyxResponse<EnqueueCallResponseData>
    {
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