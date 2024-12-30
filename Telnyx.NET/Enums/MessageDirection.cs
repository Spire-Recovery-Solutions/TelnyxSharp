using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
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