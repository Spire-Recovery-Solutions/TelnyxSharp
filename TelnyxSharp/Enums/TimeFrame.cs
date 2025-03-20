using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
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
        [JsonStringEnumMemberName("1h")]
        OneHour,

        /// <summary>
        /// Represents a time frame of 3 hours.
        /// </summary>
        [JsonStringEnumMemberName("3h")]
        ThreeHours,

        /// <summary>
        /// Represents a time frame of 24 hours.
        /// </summary>
        [JsonStringEnumMemberName("24h")]
        TwentyFourHours,

        /// <summary>
        /// Represents a time frame of 3 days.
        /// </summary>
        [JsonStringEnumMemberName("3d")]
        ThreeDays,

        /// <summary>
        /// Represents a time frame of 7 days.
        /// </summary>
        [JsonStringEnumMemberName("7d")]
        SevenDays,

        /// <summary>
        /// Represents a time frame of 30 days.
        /// </summary>
        [JsonStringEnumMemberName("30d")]
        ThirtyDays
    }
}