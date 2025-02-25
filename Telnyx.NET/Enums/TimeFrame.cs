using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing different time frames.
    /// </summary>
    [JsonConverter(typeof(Converters.TimeFrameConverter))]
    public enum TimeFrame
    {
        /// <summary>
        /// Represents a time frame of 1 hour.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("1h")]
        OneHour,

        /// <summary>
        /// Represents a time frame of 3 hours.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("3h")]
        ThreeHours,

        /// <summary>
        /// Represents a time frame of 24 hours.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("24h")]
        TwentyFourHours,

        /// <summary>
        /// Represents a time frame of 3 days.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("3d")]
        ThreeDays,

        /// <summary>
        /// Represents a time frame of 7 days.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("7d")]
        SevenDays,

        /// <summary>
        /// Represents a time frame of 30 days.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("30d")]
        ThirtyDays
    }
}