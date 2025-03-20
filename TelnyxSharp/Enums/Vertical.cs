using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
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
        [JsonStringEnumMemberName("REAL_ESTATE")]
        RealEstate,

        /// <summary>
        /// Healthcare industry.
        /// </summary>
        [JsonStringEnumMemberName("HEALTHCARE")]
        Healthcare,

        /// <summary>
        /// Energy industry.
        /// </summary>
        [JsonStringEnumMemberName("ENERGY")]
        Energy,

        /// <summary>
        /// Entertainment industry.
        /// </summary>
        [JsonStringEnumMemberName("ENTERTAINMENT")]
        Entertainment,

        /// <summary>
        /// Retail industry.
        /// </summary>
        [JsonStringEnumMemberName("RETAIL")]
        Retail,

        /// <summary>
        /// Agriculture industry.
        /// </summary>
        [JsonStringEnumMemberName("AGRICULTURE")]
        Agriculture,

        /// <summary>
        /// Insurance industry.
        /// </summary>
        [JsonStringEnumMemberName("INSURANCE")]
        Insurance,

        /// <summary>
        /// Education industry.
        /// </summary>
        [JsonStringEnumMemberName("EDUCATION")]
        Education,

        /// <summary>
        /// Hospitality industry.
        /// </summary>
        [JsonStringEnumMemberName("HOSPITALITY")]
        Hospitality,

        /// <summary>
        /// Financial industry.
        /// </summary>
        [JsonStringEnumMemberName("FINANCIAL")]
        Financial,

        /// <summary>
        /// Gambling industry.
        /// </summary>
        [JsonStringEnumMemberName("GAMBLING")]
        Gambling,

        /// <summary>
        /// Construction industry.
        /// </summary>
        [JsonStringEnumMemberName("CONSTRUCTION")]
        Construction,

        /// <summary>
        /// Non-governmental organizations (NGOs).
        /// </summary>
        [JsonStringEnumMemberName("NGO")]
        NGO,

        /// <summary>
        /// Manufacturing industry.
        /// </summary>
        [JsonStringEnumMemberName("MANUFACTURING")]
        Manufacturing,

        /// <summary>
        /// Government sector.
        /// </summary>
        [JsonStringEnumMemberName("GOVERNMENT")]
        Government,

        /// <summary>
        /// Technology industry.
        /// </summary>
        [JsonStringEnumMemberName("TECHNOLOGY")]
        Technology,

        /// <summary>
        /// Communication sector.
        /// </summary>
        [JsonStringEnumMemberName("COMMUNICATION")]
        Communication
    }
}