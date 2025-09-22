using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the available bidirectional codecs for stream communication.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<StreamBidirectionalCodec>))]
    public enum StreamBidirectionalCodec
    {
        /// <summary>
        /// PCMU codec (Pulse Code Modulation, A-law).
        /// </summary>
        PCMU,

        /// <summary>
        /// PCMA codec (Pulse Code Modulation, U-law).
        /// </summary>
        PCMA,

        /// <summary>
        /// G722 codec (Wideband speech codec).
        /// </summary>
        G722
    }
}