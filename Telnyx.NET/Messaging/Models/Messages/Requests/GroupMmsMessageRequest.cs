using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.Messages.Requests
{
    /// <summary>
    /// Represents a request to send a group MMS message.
    /// </summary>
    public class GroupMmsMessageRequest : MessageBaseRequest, ITelnyxRequest
    {
        /// <summary>
        /// The phone number used to send the message.
        /// </summary>
        [JsonPropertyName("from")]
        public required string From { get; set; }
    }
}