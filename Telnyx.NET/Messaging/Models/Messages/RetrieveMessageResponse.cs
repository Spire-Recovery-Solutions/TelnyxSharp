using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.Messages
{
    /// <summary>
    /// Represents the response for a message retrieval request.
    /// </summary>
    public class RetrieveMessageResponse : TelnyxResponse<RetrieveMessageData>
    {
    }

    /// <summary>
    /// Represents the detailed data for a retrieved message.
    /// </summary>
    public class RetrieveMessageData : MessageBaseResponse
    {
        /// <summary>
        /// Gets or sets the list of "cc" (carbon copy) recipients for the message.
        /// Only for Inbound Messages.
        /// </summary>
        [JsonPropertyName("cc")]
        public List<FromTo>? Cc { get; set; }
    }
}