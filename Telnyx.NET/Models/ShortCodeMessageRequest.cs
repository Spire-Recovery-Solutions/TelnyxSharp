using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents a request for sending a short code message through Telnyx API.
    /// </summary>
    public class ShortCodeMessageRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the sender's short code or phone number.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; } = string.Empty;
    }
}