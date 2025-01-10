using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the available options for recording tracks.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordTrack
    {
        /// <summary>
        /// Records both inbound and outbound tracks.
        /// </summary>
        [JsonPropertyName("both")]
        Both,

        /// <summary>
        /// Records only the inbound track.
        /// </summary>
        [JsonPropertyName("inbound")]
        Inbound,

        /// <summary>
        /// Records only the outbound track.
        /// </summary>
        [JsonPropertyName("outbound")]
        Outbound
    }
}