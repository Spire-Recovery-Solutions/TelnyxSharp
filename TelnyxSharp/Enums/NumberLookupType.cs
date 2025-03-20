using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the types of number lookups that can be performed.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NumberLookupType
    {
        /// <summary>
        /// Lookup to retrieve carrier information for a given phone number.
        /// </summary>
        Carrier,

        /// <summary>
        /// Lookup to retrieve the caller's name associated with a phone number.
        /// </summary>
        CallerName
    }
}