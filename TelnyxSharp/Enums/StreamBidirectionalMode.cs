using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the available modes for bidirectional stream communication.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<StreamBidirectionalMode>))]
    public enum StreamBidirectionalMode
    {
        /// <summary>
        /// MP3 mode, used for audio streams in MP3 format.
        /// </summary>
        Mp3,

        /// <summary>
        /// RTP (Real-time Transport Protocol) mode, used for streaming real-time data like audio and video.
        /// </summary>
        Rtp
    }
}