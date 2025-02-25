using System.Text.Json.Serialization;
using Telnyx.NET.Converters;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing different types of alternative business IDs used for verification.
    /// </summary>
    [JsonConverter(typeof(AltBusinessIdTypeConverter))]
    public enum AltBusinessIdType
    {
       /// <summary>
        /// No alternative business ID provided.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("NONE")]
        None,

        /// <summary>
        /// DUNS (Data Universal Numbering System) - a unique nine-digit identifier issued by Dun & Bradstreet.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("DUNS")]
        Duns,

        /// <summary>
        /// GIIN (Global Intermediary Identification Number) - an identifier issued by the U.S. IRS for financial institutions.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("GIIN")]
        Giin,

        /// <summary>
        /// LEI (Legal Entity Identifier) - a unique identifier for legal entities involved in financial transactions.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("LEI")]
        Lei
    }
}