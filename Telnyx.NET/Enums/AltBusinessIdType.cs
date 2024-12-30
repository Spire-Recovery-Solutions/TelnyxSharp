using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AltBusinessIdType
    {
        [JsonPropertyName("NONE")]
        None,

        [JsonPropertyName("DUNS")]
        Duns,

        [JsonPropertyName("GIIN")]
        Giin,

        [JsonPropertyName("LEI")]
        Lei
    }
}