using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageDirection
    {
        Unknown,
        [JsonPropertyName("outbound")]
        Outbound, // Corresponds to "outbound"

        [JsonPropertyName("inbound")]
        Inbound // Corresponds to "inbound"
    }
}
