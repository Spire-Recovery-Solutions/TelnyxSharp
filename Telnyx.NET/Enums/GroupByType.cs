using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Specifies the grouping options for inventory coverage queries.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GroupByType
    {
        /// <summary>
        /// Group results by locality.
        /// </summary>
        [JsonPropertyName("locality")]
        Locality,

        /// <summary>
        /// Group results by Numbering Plan Area (NPA).
        /// </summary>
        [JsonPropertyName("npa")]
        Npa,

        /// <summary>
        /// Group results by National Destination Code (NDC).
        /// </summary>
        [JsonPropertyName("national_destination_code")]
        NationalDestinationCode
    }
}