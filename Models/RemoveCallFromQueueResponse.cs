using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Telnyx API when removing a call from a queue.
    /// Implements the <see cref="ITelnyxResponse"/> interface for unified response handling.
    /// </summary>
    public class RemoveCallFromQueueResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the result of the remove call operation.
        /// This property contains information about the outcome of the API request.
        /// </summary>
        [JsonPropertyName("data")]
        public RemoveCallFromQueueResponseData? Data { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// This property is nullable to indicate that it may not always be present.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
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