using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageVolume
    {
        Unknown,

        [JsonPropertyName("10")]
        Ten,

        [JsonPropertyName("100")]
        OneHundred,

        [JsonPropertyName("1,000")]
        Thousand,

        [JsonPropertyName("10,000")]
        TenThousand,

        [JsonPropertyName("100,000")]
        HundredThousand,

        [JsonPropertyName("250,000")]
        TwoHundredFiftyThousand,

        [JsonPropertyName("500,000")]
        FiveHundredThousand,

        [JsonPropertyName("750,000")]
        SevenHundredFiftyThousand,

        [JsonPropertyName("1,000,000")]
        OneMillion,

        [JsonPropertyName("5,000,000")]
        FiveMillion,

        [JsonPropertyName("10,000,000+")]
        TenMillionPlus
    }
}
