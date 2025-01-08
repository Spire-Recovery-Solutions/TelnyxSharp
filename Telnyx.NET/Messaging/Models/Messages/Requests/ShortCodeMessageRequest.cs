using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;
using Telnyx.NET.Messaging.Models.Messages.Responses;

namespace Telnyx.NET.Messaging.Models.Messages.Requests
{
    /// <summary>
    /// Represents a request for sending a short code message through Telnyx API.
    /// </summary>
    public class ShortCodeMessageRequest : MessageBaseRequest, ITelnyxRequest
    {

        /// <summary>
        /// The type of message being sent (e.g., "sms", "mms").
        /// </summary>
        [JsonPropertyName("type")]
        public MessageType? Type { get; set; }

        /// <summary>
        /// Indicates whether to automatically detect the message type.
        /// </summary>W
        [JsonPropertyName("auto_detect")]
        public bool? AutoDetect { get; set; }

        /// <summary>
        /// Gets or sets the sender's short code or phone number.
        /// </summary>
        [JsonPropertyName("from")]
        public required string From { get; set; }
    }
}