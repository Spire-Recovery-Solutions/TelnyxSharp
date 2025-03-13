using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.InboundChannels.Requests
{
    /// <summary>
    /// Represents a request to update the number of inbound channels for a specific configuration.
    /// This request is used to adjust the capacity for receiving inbound calls.
    /// </summary>
    public class UpdateInboundChannelsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of inbound channels to allocate.
        /// This value specifies the maximum number of simultaneous inbound calls allowed.
        /// </summary>
        [JsonPropertyName("channels")]
        public int Channels { get; set; }
    }
}