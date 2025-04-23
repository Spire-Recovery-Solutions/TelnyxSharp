using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the type of record for CDR reports.
    /// </summary>
    [JsonConverter(typeof(JsonNumberEnumConverter<RecordType>))]
    public enum RecordType
    {
        /// <summary>
        /// Complete records.
        /// </summary>
        Complete = 1,

        /// <summary>
        /// Incomplete records.
        /// </summary>
        Incomplete = 2,

        /// <summary>
        /// Error records.
        /// </summary>
        Errors = 3
    }
}
