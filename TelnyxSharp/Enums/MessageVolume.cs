using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing different message volume categories.
    /// </summary>
    [JsonConverter(typeof(Converters.MessageVolumeConverter))]
    public enum MessageVolume
    {
        /// <summary>
        /// Represents an unknown message volume.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents a message volume of 10.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("10")]
        Ten,

        /// <summary>
        /// Represents a message volume of 100.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("100")]
        OneHundred,

        /// <summary>
        /// Represents a message volume of 1,000.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("1,000")]
        Thousand,

        /// <summary>
        /// Represents a message volume of 10,000.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("10,000")]
        TenThousand,

        /// <summary>
        /// Represents a message volume of 100,000.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("100,000")]
        HundredThousand,

        /// <summary>
        /// Represents a message volume of 250,000.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("250,000")]
        TwoHundredFiftyThousand,

        /// <summary>
        /// Represents a message volume of 500,000.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("500,000")]
        FiveHundredThousand,

        /// <summary>
        /// Represents a message volume of 750,000.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("750,000")]
        SevenHundredFiftyThousand,

        /// <summary>
        /// Represents a message volume of 1,000,000.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("1,000,000")]
        OneMillion,

        /// <summary>
        /// Represents a message volume of 5,000,000.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("5,000,000")]
        FiveMillion,

        /// <summary>
        /// Represents a message volume of 10,000,000+.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("10,000,000+")]
        TenMillionPlus
    }
}