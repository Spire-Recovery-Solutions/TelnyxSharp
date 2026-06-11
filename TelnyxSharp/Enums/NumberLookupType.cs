using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the types of number lookups that can be performed.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<NumberLookupType>))]
    public enum NumberLookupType
    {
        /// <summary>
        /// Lookup to retrieve carrier information for a given phone number.
        /// Also returns portability data (lrn, ocn, spid, ported_status) in the same response.
        /// </summary>
        Carrier,

        /// <summary>
        /// Lookup to retrieve the caller's name associated with a phone number.
        /// </summary>
        CallerName,

        /// <summary>
        /// Lookup to retrieve portability information (LRN, OCN, SPID, ported_status, ported_date)
        /// for a given phone number. Returns structured NPAC/LERG identifiers for deterministic
        /// carrier identification independent of normalized_carrier free-text strings.
        /// </summary>
        Portability
    }
}