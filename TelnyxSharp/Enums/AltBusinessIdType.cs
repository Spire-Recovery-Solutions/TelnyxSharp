using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing different types of alternative business IDs used for verification.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<AltBusinessIdType>))]
    public enum AltBusinessIdType
    {
        /// <summary>
        /// No alternative business ID provided.
        /// </summary>
        [JsonStringEnumMemberName("NONE")]
        None,

        /// <summary>
        /// DUNS (Data Universal Numbering System) - a unique nine-digit identifier issued by Dun & Bradstreet.
        /// </summary>
        [JsonStringEnumMemberName("DUNS")]
        Duns,

        /// <summary>
        /// GIIN (Global Intermediary Identification Number) - an identifier issued by the U.S. IRS for financial institutions.
        /// </summary>
        [JsonStringEnumMemberName("GIIN")]
        Giin,

        /// <summary>
        /// LEI (Legal Entity Identifier) - a unique identifier for legal entities involved in financial transactions.
        /// </summary>
        [JsonStringEnumMemberName("LEI")]
        Lei
    }
}