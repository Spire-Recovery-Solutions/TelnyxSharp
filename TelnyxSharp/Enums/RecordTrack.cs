using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the available options for recording tracks.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<RecordTrack>))]
    public enum RecordTrack
    {
        /// <summary>
        /// Records both inbound and outbound tracks.
        /// </summary>
        Both,

        /// <summary>
        /// Records only the inbound track.
        /// </summary>
        Inbound,

        /// <summary>
        /// Records only the outbound track.
        /// </summary>
        Outbound
    }
}