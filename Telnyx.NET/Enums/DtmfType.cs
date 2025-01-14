using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the different types of DTMF (Dual-tone multi-frequency) signaling.
    /// This is used to specify the method of DTMF signaling in voice communications.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DtmfType
    {
        /// <summary>
        /// Represents the RFC 2833 DTMF signaling method, where DTMF tones are sent in the RTP stream.
        /// </summary>
        [JsonPropertyName("RFC 2833")]
        Rfc2833,

        /// <summary>
        /// Represents the Inband DTMF signaling method, where DTMF tones are sent within the voice stream.
        /// </summary>
        [JsonPropertyName("Inband")]
        Inband,

        /// <summary>
        /// Represents the SIP INFO DTMF signaling method, where DTMF tones are sent in SIP INFO messages.
        /// </summary>
        [JsonPropertyName("SIP INFO")]
        SipInfo
    }
}