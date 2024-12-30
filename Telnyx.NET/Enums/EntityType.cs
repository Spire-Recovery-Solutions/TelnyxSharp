using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EntityType
    {
        Unknown,
        PRIVATE_PROFIT,
        PUBLIC_PROFIT,
        NON_PROFIT,
        SOLE_PROPRIETOR,
        GOVERNMENT
    }
}
