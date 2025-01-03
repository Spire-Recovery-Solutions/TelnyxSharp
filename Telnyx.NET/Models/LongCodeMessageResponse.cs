using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response received from the Telnyx API after sending a long code message.
    /// Includes data about the message and any errors encountered during the API call.
    /// </summary>
    public class LongCodeMessageResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the detailed message data returned by the API.
        /// </summary>
        [JsonPropertyName("data")]
        public LongCodeMessageData? Data { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains detailed information about the message sent via the Telnyx API.
    /// </summary>
    public class LongCodeMessageData : MessageBaseResponse
    {
    }
}