using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing various business verticals.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Vertical
    {
        /// <summary>
        /// The vertical is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// Real estate industry.
        /// </summary>
        [JsonPropertyName("REAL_ESTATE")]
        RealEstate,

        /// <summary>
        /// Healthcare industry.
        /// </summary>
        [JsonPropertyName("HEALTHCARE")]
        Healthcare,

        /// <summary>
        /// Energy industry.
        /// </summary>
        [JsonPropertyName("ENERGY")]
        Energy,

        /// <summary>
        /// Entertainment industry.
        /// </summary>
        [JsonPropertyName("ENTERTAINMENT")]
        Entertainment,

        /// <summary>
        /// Retail industry.
        /// </summary>
        [JsonPropertyName("RETAIL")]
        Retail,

        /// <summary>
        /// Agriculture industry.
        /// </summary>
        [JsonPropertyName("AGRICULTURE")]
        Agriculture,

        /// <summary>
        /// Insurance industry.
        /// </summary>
        [JsonPropertyName("INSURANCE")]
        Insurance,

        /// <summary>
        /// Education industry.
        /// </summary>
        [JsonPropertyName("EDUCATION")]
        Education,

        /// <summary>
        /// Hospitality industry.
        /// </summary>
        [JsonPropertyName("HOSPITALITY")]
        Hospitality,

        /// <summary>
        /// Financial industry.
        /// </summary>
        [JsonPropertyName("FINANCIAL")]
        Financial,

        /// <summary>
        /// Gambling industry.
        /// </summary>
        [JsonPropertyName("GAMBLING")]
        Gambling,

        /// <summary>
        /// Construction industry.
        /// </summary>
        [JsonPropertyName("CONSTRUCTION")]
        Construction,

        /// <summary>
        /// Non-governmental organizations (NGOs).
        /// </summary>
        [JsonPropertyName("NGO")]
        NGO,

        /// <summary>
        /// Manufacturing industry.
        /// </summary>
        [JsonPropertyName("MANUFACTURING")]
        Manufacturing,

        /// <summary>
        /// Government sector.
        /// </summary>
        [JsonPropertyName("GOVERNMENT")]
        Government,

        /// <summary>
        /// Technology industry.
        /// </summary>
        [JsonPropertyName("TECHNOLOGY")]
        Technology,

        /// <summary>
        /// Communication sector.
        /// </summary>
        [JsonPropertyName("COMMUNICATION")]
        Communication
    }
}