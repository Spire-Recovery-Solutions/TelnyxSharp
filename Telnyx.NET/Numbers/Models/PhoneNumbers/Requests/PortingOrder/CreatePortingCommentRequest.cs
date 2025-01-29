using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to create a comment on a porting order.
    /// </summary>
    public class CreatePortingCommentRequest : ITelnyxRequest
    {
        /// <summary>
        /// The content of the comment to be added to the porting order.
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; set; }
    }
}