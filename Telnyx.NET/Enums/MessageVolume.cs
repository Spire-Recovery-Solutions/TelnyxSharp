using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing different message volume categories.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageVolume
    {
        /// <summary>
        /// Represents an unknown message volume.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents a message volume of 10.
        /// </summary>
        [JsonPropertyName("10")]
        Ten,

        /// <summary>
        /// Represents a message volume of 100.
        /// </summary>
        [JsonPropertyName("100")]
        OneHundred,

        /// <summary>
        /// Represents a message volume of 1,000.
        /// </summary>
        [JsonPropertyName("1,000")]
        Thousand,

        /// <summary>
        /// Represents a message volume of 10,000.
        /// </summary>
        [JsonPropertyName("10,000")]
        TenThousand,

        /// <summary>
        /// Represents a message volume of 100,000.
        /// </summary>
        [JsonPropertyName("100,000")]
        HundredThousand,

        /// <summary>
        /// Represents a message volume of 250,000.
        /// </summary>
        [JsonPropertyName("250,000")]
        TwoHundredFiftyThousand,

        /// <summary>
        /// Represents a message volume of 500,000.
        /// </summary>
        [JsonPropertyName("500,000")]
        FiveHundredThousand,

        /// <summary>
        /// Represents a message volume of 750,000.
        /// </summary>
        [JsonPropertyName("750,000")]
        SevenHundredFiftyThousand,

        /// <summary>
        /// Represents a message volume of 1,000,000.
        /// </summary>
        [JsonPropertyName("1,000,000")]
        OneMillion,

        /// <summary>
        /// Represents a message volume of 5,000,000.
        /// </summary>
        [JsonPropertyName("5,000,000")]
        FiveMillion,

        /// <summary>
        /// Represents a message volume of 10,000,000+.
        /// </summary>
        [JsonPropertyName("10,000,000+")]
        TenMillionPlus
    }
}