using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TimeFrame
    {
        [JsonPropertyName("1h")]
        OneHour,

        [JsonPropertyName("3h")]
        ThreeHours,

        [JsonPropertyName("24h")]
        TwentyFourHours,

        [JsonPropertyName("3d")]
        ThreeDays,

        [JsonPropertyName("7d")]
        SevenDays,

        [JsonPropertyName("30d")]
        ThirtyDays
    }
}
