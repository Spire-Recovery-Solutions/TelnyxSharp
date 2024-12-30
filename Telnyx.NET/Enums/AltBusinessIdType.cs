using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
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