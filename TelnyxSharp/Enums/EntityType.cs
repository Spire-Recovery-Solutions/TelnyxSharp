using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing different entity types for business or organization classifications.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<EntityType>))]
    public enum EntityType
    {
        /// <summary>
        /// The entity type is unknown or unspecified.
        /// </summary>
        [JsonStringEnumMemberName("Unknown")]
        Unknown,

        /// <summary>
        /// The entity is a private profit-driven business.
        /// </summary>
        [JsonStringEnumMemberName("PRIVATE_PROFIT")]
        PrivateProfit,

        /// <summary>
        /// The entity is a public profit-driven business.
        /// </summary>
        [JsonStringEnumMemberName("PUBLIC_PROFIT")]
        PublicProfit,

        /// <summary>
        /// The entity is a non-profit organization.
        /// </summary>
        [JsonStringEnumMemberName("NON_PROFIT")]
        NonProfit,

        /// <summary>
        /// The entity is a sole proprietor business.
        /// </summary>
        [JsonStringEnumMemberName("SOLE_PROPRIETOR")]
        SoleProprietor,

        /// <summary>
        /// The entity is a government organization.
        /// </summary>
        [JsonStringEnumMemberName("GOVERNMENT")]
        Government
    }
}