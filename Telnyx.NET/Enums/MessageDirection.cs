using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    public enum MessageDirection
    {
        [JsonPropertyName("Unknown")]
        Unknown,

        [JsonPropertyName("outbound")]
        Outbound,

        [JsonPropertyName("inbound")]
        Inbound
    }
}