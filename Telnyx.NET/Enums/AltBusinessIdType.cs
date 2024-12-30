using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing different types of alternative business IDs used for verification.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AltBusinessIdType
    {
        /// <summary>
        /// No alternative business ID provided.
        /// </summary>
        [JsonPropertyName("NONE")]
        None,

        /// <summary>
        /// DUNS (Data Universal Numbering System) - a unique nine-digit identifier issued by Dun & Bradstreet.
        /// </summary>
        [JsonPropertyName("DUNS")]
        Duns,

        /// <summary>
        /// GIIN (Global Intermediary Identification Number) - an identifier issued by the U.S. IRS for financial institutions.
        /// </summary>
        [JsonPropertyName("GIIN")]
        Giin,

        /// <summary>
        /// LEI (Legal Entity Identifier) - a unique identifier for legal entities involved in financial transactions.
        /// </summary>
        [JsonPropertyName("LEI")]
        Lei
    }
}