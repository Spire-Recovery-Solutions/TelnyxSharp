using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TimeFrame
    {
        [JsonPropertyName("1h")]
        OneHour, // Corresponds to "1h"

        [JsonPropertyName("3h")]
        ThreeHours, // Corresponds to "3h"

        [JsonPropertyName("24h")]
        TwentyFourHours, // Corresponds to "24h"

        [JsonPropertyName("3d")]
        ThreeDays, // Corresponds to "3d"

        [JsonPropertyName("7d")]
        SevenDays, // Corresponds to "7d"

        [JsonPropertyName("30d")]
        ThirtyDays // Corresponds to "30d"
    }
}
