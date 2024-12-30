using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Vertical
    {
        Unknown,
        REAL_ESTATE,
        HEALTHCARE,
        ENERGY,
        ENTERTAINMENT,
        RETAIL,
        AGRICULTURE,
        INSURANCE,
        EDUCATION,
        HOSPITALITY,
        FINANCIAL,
        GAMBLING,
        CONSTRUCTION,
        NGO,
        MANUFACTURING,
        GOVERNMENT,
        TECHNOLOGY,
        COMMUNICATION
    }
}
