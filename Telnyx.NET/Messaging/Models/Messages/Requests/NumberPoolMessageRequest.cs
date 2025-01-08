using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;
using Telnyx.NET.Messaging.Models.Messages.Responses;

namespace Telnyx.NET.Messaging.Models.Messages.Requests
{
    /// <summary>
    /// Represents a request to send a message using a number pool via the Telnyx API.
    /// </summary>
    public class NumberPoolMessageRequest : MessageBaseRequest, ITelnyxRequest
    {
        /// <summary>
        /// Unique identifier for a messaging profile. This field is required.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public required string MessagingProfileId { get; set; }

        /// <summary>
        /// The type of message being sent (e.g., "sms", "mms").
        /// </summary>
        [JsonPropertyName("type")]
        public MessageType? Type { get; set; }

        /// <summary>
        /// Indicates whether to automatically detect the message type.
        /// </summary>
        [JsonPropertyName("auto_detect")]
        public bool? AutoDetect { get; set; }
    }
}