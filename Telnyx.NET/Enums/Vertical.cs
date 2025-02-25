using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing various business verticals.
    /// </summary>
    [JsonConverter(typeof(Converters.VerticalConverter))]
    public enum Vertical
    {
        /// <summary>
        /// The vertical is unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// Real estate industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("REAL_ESTATE")]
        RealEstate,

        /// <summary>
        /// Healthcare industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("HEALTHCARE")]
        Healthcare,

        /// <summary>
        /// Energy industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ENERGY")]
        Energy,

        /// <summary>
        /// Entertainment industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ENTERTAINMENT")]
        Entertainment,

        /// <summary>
        /// Retail industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("RETAIL")]
        Retail,

        /// <summary>
        /// Agriculture industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("AGRICULTURE")]
        Agriculture,

        /// <summary>
        /// Insurance industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("INSURANCE")]
        Insurance,

        /// <summary>
        /// Education industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("EDUCATION")]
        Education,

        /// <summary>
        /// Hospitality industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("HOSPITALITY")]
        Hospitality,

        /// <summary>
        /// Financial industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("FINANCIAL")]
        Financial,

        /// <summary>
        /// Gambling industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("GAMBLING")]
        Gambling,

        /// <summary>
        /// Construction industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("CONSTRUCTION")]
        Construction,

        /// <summary>
        /// Non-governmental organizations (NGOs).
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("NGO")]
        NGO,

        /// <summary>
        /// Manufacturing industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("MANUFACTURING")]
        Manufacturing,

        /// <summary>
        /// Government sector.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("GOVERNMENT")]
        Government,

        /// <summary>
        /// Technology industry.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("TECHNOLOGY")]
        Technology,

        /// <summary>
        /// Communication sector.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("COMMUNICATION")]
        Communication
    }
}