using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    public enum Vertical
    {
        Unknown,

        [JsonPropertyName("REAL_ESTATE")]
        RealEstate,

        [JsonPropertyName("HEALTHCARE")]
        Healthcare,

        [JsonPropertyName("ENERGY")]
        Energy,

        [JsonPropertyName("ENTERTAINMENT")]
        Entertainment,

        [JsonPropertyName("RETAIL")]
        Retail,

        [JsonPropertyName("AGRICULTURE")]
        Agriculture,

        [JsonPropertyName("INSURANCE")]
        Insurance,

        [JsonPropertyName("EDUCATION")]
        Education,

        [JsonPropertyName("HOSPITALITY")]
        Hospitality,

        [JsonPropertyName("FINANCIAL")]
        Financial,

        [JsonPropertyName("GAMBLING")]
        Gambling,

        [JsonPropertyName("CONSTRUCTION")]
        Construction,

        [JsonPropertyName("NGO")]
        NGO,

        [JsonPropertyName("MANUFACTURING")]
        Manufacturing,

        [JsonPropertyName("GOVERNMENT")]
        Government,

        [JsonPropertyName("TECHNOLOGY")]
        Technology,

        [JsonPropertyName("COMMUNICATION")]
        Communication
    }
}