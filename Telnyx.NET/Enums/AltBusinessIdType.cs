using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AltBusinessIdType
    {
        NONE,
        DUNS,
        GIIN,
        LEI
    }
}
