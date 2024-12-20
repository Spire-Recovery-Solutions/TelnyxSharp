
using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public sealed class SendMessageRequest :  MessageBaseRequest, ITelnyxRequest
    {
           /// <summary>
        /// The phone number the message will be sent from.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; } = string.Empty;

        /// <summary>
        /// Id of the messaging profile settings to use
        /// </summary>
        [JsonPropertyName("messaging_profile_id")] 
        public string? MessagingProfileId { get; set; }
    }
}
