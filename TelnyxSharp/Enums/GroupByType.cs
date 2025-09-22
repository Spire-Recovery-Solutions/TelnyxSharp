using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Specifies the grouping options for inventory coverage queries.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<GroupByType>))]
    public enum GroupByType
    {
        /// <summary>
        /// Group results by locality.
        /// </summary>
        [JsonStringEnumMemberName("locality")]
        Locality,

        /// <summary>
        /// Group results by Numbering Plan Area (NPA).
        /// </summary>
        [JsonStringEnumMemberName("npa")]
        Npa,

        /// <summary>
        /// Group results by National Destination Code (NDC).
        /// </summary>
        [JsonStringEnumMemberName("national_destination_code")]
        NationalDestinationCode
    }
}