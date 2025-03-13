using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
   /// <summary>
    /// Enum representing the different types of call tracks.
    /// </summary>
    [JsonConverter(typeof(Converters.TrackConverter))]
    public enum Track
    {
        /// <summary>
        /// Represents the inbound track for a call.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("inbound_track")]
        InboundTrack,

        /// <summary>
        /// Represents the outbound track for a call.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("outbound_track")]
        OutboundTrack,

        /// <summary>
        /// Represents both inbound and outbound tracks for a call.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("both_tracks")]
        BothTracks
    }
}