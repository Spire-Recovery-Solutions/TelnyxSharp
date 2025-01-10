using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the available bidirectional codecs for stream communication.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StreamBidirectionalCodec
    {
        /// <summary>
        /// PCMU codec (Pulse Code Modulation, A-law).
        /// </summary>
        [JsonPropertyName("PCMU")]
        Pcmu,

        /// <summary>
        /// PCMA codec (Pulse Code Modulation, U-law).
        /// </summary>
        [JsonPropertyName("PCMA")]
        Pcma,

        /// <summary>
        /// G722 codec (Wideband speech codec).
        /// </summary>
        [JsonPropertyName("G722")]
        G722
    }
}