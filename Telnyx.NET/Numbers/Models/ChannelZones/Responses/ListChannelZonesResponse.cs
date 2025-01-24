using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.ChannelZones.Responses
{
    /// <summary>
    /// Represents the response for retrieving a list of channel zones.
    /// Inherits from <see cref="TelnyxResponse{T}"/> with a list of <see cref="ChannelZone"/> as the result type.
    /// </summary>
    public class ListChannelZonesResponse : TelnyxResponse<List<ChannelZone>>
    {
    }

    /// <summary>
    /// Represents a channel zone with associated metadata.
    /// </summary>
    public class ChannelZone
    {
        /// <summary>
        /// Gets or sets the type of record, typically indicating "channel_zone".
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of countries associated with this channel zone.
        /// Each entry represents a country in ISO 3166-1 alpha-2 format (e.g., "US", "CA").
        /// </summary>
        [JsonPropertyName("countries")]
        public List<string> Countries { get; set; } = new();

        /// <summary>
        /// Gets or sets the unique identifier for the channel zone.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the channel zone.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of channels configured for this channel zone.
        /// </summary>
        [JsonPropertyName("channels")]
        public long Channels { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the channel zone was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the channel zone was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}