using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for a short code message sent through the Telnyx API.
    /// </summary>
    public class ShortCodeMessageResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the data associated with the short code message response.
        /// </summary>
        [JsonPropertyName("data")]
        public ShortCodeMessageData? Data { get; set; }

        
        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains detailed information about a short code message.
    /// </summary>
    public class ShortCodeMessageData : MessageBaseResponse
    {
    }
}