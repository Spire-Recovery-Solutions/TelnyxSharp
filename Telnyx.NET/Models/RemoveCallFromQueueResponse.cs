using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Telnyx API when removing a call from a queue.
    /// </summary>
    public class RemoveCallFromQueueResponse : TelnyxResponse<RemoveCallFromQueueResponseData>
    {
        
    }

    /// <summary>
    /// Represents the result of the remove call operation from the queue.
    /// This class holds the specific details returned by the Telnyx API.
    /// </summary>
    public class RemoveCallFromQueueResponseData
    {
        /// <summary>
        /// Gets or sets the result message of the remove call operation.
        /// The default value is set to "Unexpected error" in case of failure.
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = "Unexpected error"; // Default value
    }
}