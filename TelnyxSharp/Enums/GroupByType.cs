using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Specifies the grouping options for inventory coverage queries.
    /// </summary>
    [JsonConverter(typeof(Converters.GroupByTypeConverter))]
    public enum GroupByType
    {
        /// <summary>
        /// Group results by locality.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("locality")]
        Locality,

        /// <summary>
        /// Group results by Numbering Plan Area (NPA).
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("npa")]
        Npa,

        /// <summary>
        /// Group results by National Destination Code (NDC).
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("national_destination_code")]
        NationalDestinationCode
    }
}