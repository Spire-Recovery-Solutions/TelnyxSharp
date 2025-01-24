using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.InboundChannels.Responses
{
    /// <summary>
    /// Represents the response for a request to list inbound channels.
    /// This response encapsulates the details about the inbound channels for a specific configuration.
    /// </summary>
    public class ListInboundChannelsResponse : TelnyxResponse<InboundChannels>
    {
    }

    /// <summary>
    /// Represents the details of inbound channels.
    /// This includes information about the number of channels and the type of record being returned.
    /// </summary>
    public class InboundChannels
    {
        /// <summary>
        /// Gets or sets the number of inbound channels allocated.
        /// This value indicates the maximum number of simultaneous inbound calls supported.
        /// </summary>
        [JsonPropertyName("channels")]
        public int Channels { get; set; }

        /// <summary>
        /// Gets or sets the type of record returned.
        /// Typically used to identify the object type in the response.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }
}