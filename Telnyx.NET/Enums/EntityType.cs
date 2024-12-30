using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EntityType
    {
        [JsonPropertyName("Unknown")]
        Unknown,

        [JsonPropertyName("PRIVATE_PROFIT")]
        PrivateProfit,

        [JsonPropertyName("PUBLIC_PROFIT")]
        PublicProfit,

        [JsonPropertyName("NON_PROFIT")]
        NonProfit,

        [JsonPropertyName("SOLE_PROPRIETOR")]
        SoleProprietor,

        [JsonPropertyName("GOVERNMENT")]
        Government
    }
}