using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing different time frames.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TimeFrame
    {
        /// <summary>
        /// Represents a time frame of 1 hour.
        /// </summary>
        [JsonPropertyName("1h")]
        OneHour,

        /// <summary>
        /// Represents a time frame of 3 hours.
        /// </summary>
        [JsonPropertyName("3h")]
        ThreeHours,

        /// <summary>
        /// Represents a time frame of 24 hours.
        /// </summary>
        [JsonPropertyName("24h")]
        TwentyFourHours,

        /// <summary>
        /// Represents a time frame of 3 days.
        /// </summary>
        [JsonPropertyName("3d")]
        ThreeDays,

        /// <summary>
        /// Represents a time frame of 7 days.
        /// </summary>
        [JsonPropertyName("7d")]
        SevenDays,

        /// <summary>
        /// Represents a time frame of 30 days.
        /// </summary>
        [JsonPropertyName("30d")]
        ThirtyDays
    }
}