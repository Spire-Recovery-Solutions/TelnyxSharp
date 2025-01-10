using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the different types of call tracks.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Track
    {
        /// <summary>
        /// Represents the inbound track for a call.
        /// </summary>
        [JsonPropertyName("inbound_track")]
        InboundTrack,

        /// <summary>
        /// Represents the outbound track for a call.
        /// </summary>
        [JsonPropertyName("outbound_track")]
        OutboundTrack,

        /// <summary>
        /// Represents both inbound and outbound tracks for a call.
        /// </summary>
        [JsonPropertyName("both_tracks")]
        BothTracks
    }
}