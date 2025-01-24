using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.ChannelZones.Requests
{
    /// <summary>
    /// Represents a request to update the configuration of a channel zone.
    /// </summary>
    public class UpdateChannelZoneRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of channels for the channel zone.
        /// This property is required for updating the channel zone.
        /// </summary>
        [JsonPropertyName("channels")]
        public long Channels { get; set; }
    }
}