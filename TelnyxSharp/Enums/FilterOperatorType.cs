using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{

    [JsonConverter(typeof(FilterOperatorConverter))]
    public enum FilterOperator
    {
        /// <summary>
        /// Represents an equality check.
        /// Serializes as "eq".
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("eq")]
        Eq,

        /// <summary>
        /// Represents a non-equality check.
        /// Serializes as "ne".
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ne")]
        Ne,

        /// <summary>
        /// Represents a "greater than" comparison.
        /// Serializes as "gt".
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("gt")]
        Gt,

        /// <summary>
        /// Represents a "greater than or equal to" comparison.
        /// Serializes as "gte".
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("gte")]
        Gte,

        /// <summary>
        /// Represents a "less than" comparison.
        /// Serializes as "lt".
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("lt")]
        Lt,

        /// <summary>
        /// Represents a "less than or equal to" comparison.
        /// Serializes as "lte".
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("lte")]
        Lte,

        /// <summary>
        /// Checks if the target string starts with a specified value.
        /// Serializes as "starts_with".
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("starts_with")]
        StartsWith,

        /// <summary>
        /// Checks if the target string ends with a specified value.
        /// Serializes as "ends_with".
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ends_with")]
        EndsWith,

        /// <summary>
        /// Checks if the target string contains a specified value.
        /// Serializes as "contains".
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("contains")]
        Contains
    }
}
