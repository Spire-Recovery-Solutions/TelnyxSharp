using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing different entity types for business or organization classifications.
    /// </summary>
    [JsonConverter(typeof(EntityTypeConverter))]
    public enum EntityType
    {
        /// <summary>
        /// The entity type is unknown or unspecified.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Unknown")]
        Unknown,

        /// <summary>
        /// The entity is a private profit-driven business.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("PRIVATE_PROFIT")]
        PrivateProfit,

        /// <summary>
        /// The entity is a public profit-driven business.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("PUBLIC_PROFIT")]
        PublicProfit,

        /// <summary>
        /// The entity is a non-profit organization.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("NON_PROFIT")]
        NonProfit,

        /// <summary>
        /// The entity is a sole proprietor business.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("SOLE_PROPRIETOR")]
        SoleProprietor,

        /// <summary>
        /// The entity is a government organization.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("GOVERNMENT")]
        Government
    }
}