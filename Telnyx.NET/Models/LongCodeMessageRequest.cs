using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents a request to send a long code message using the Telnyx API.
    /// Includes various properties for message configuration, such as recipients, message content, media, and webhooks.
    /// </summary>
    public class LongCodeMessageRequest : MessageBaseRequest, ITelnyxRequest
    {
        /// <summary>
        /// The phone number the message will be sent from.
        /// This is a required field and should be a valid long code number.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; } = string.Empty;
    }
}