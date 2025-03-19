using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FilterOperator
    {
        /// <summary>
        /// Represents an equality check.
        /// Serializes as "eq".
        /// </summary>
        [JsonStringEnumMemberName("eq")]
        Equals,

        /// <summary>
        /// Represents a non-equality check.
        /// Serializes as "ne".
        /// </summary>
        [JsonStringEnumMemberName("ne")]
        NotEquals,

        /// <summary>
        /// Represents a "greater than" comparison.
        /// Serializes as "gt".
        /// </summary>
        [JsonStringEnumMemberName("gt")]
        GreaterThan,

        /// <summary>
        /// Represents a "greater than or equal to" comparison.
        /// Serializes as "gte".
        /// </summary>
        [JsonStringEnumMemberName("gte")]
        GreaterThanOrEqualTo,

        /// <summary>
        /// Represents a "less than" comparison.
        /// Serializes as "lt".
        /// </summary>
        [JsonStringEnumMemberName("lt")]
        LessThan,

        /// <summary>
        /// Represents a "less than or equal to" comparison.
        /// Serializes as "lte".
        /// </summary>
        [JsonStringEnumMemberName("lte")]
        LessThanOrEqualTo,

        /// <summary>
        /// Checks if the target string starts with a specified value.
        /// Serializes as "starts_with".
        /// </summary>
        [JsonStringEnumMemberName("starts_with")]
        StartsWith,

        /// <summary>
        /// Checks if the target string ends with a specified value.
        /// Serializes as "ends_with".
        /// </summary>
        [JsonStringEnumMemberName("ends_with")]
        EndsWith,

        /// <summary>
        /// Checks if the target string contains a specified value.
        /// Serializes as "contains".
        /// </summary>
        [JsonStringEnumMemberName("contains")]
        Contains
    }
}