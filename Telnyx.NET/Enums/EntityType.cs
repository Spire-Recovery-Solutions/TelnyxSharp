using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing different entity types for business or organization classifications.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EntityType
    {
        /// <summary>
        /// The entity type is unknown or unspecified.
        /// </summary>
        [JsonPropertyName("Unknown")]
        Unknown,

        /// <summary>
        /// The entity is a private profit-driven business.
        /// </summary>
        [JsonPropertyName("PRIVATE_PROFIT")]
        PrivateProfit,

        /// <summary>
        /// The entity is a public profit-driven business.
        /// </summary>
        [JsonPropertyName("PUBLIC_PROFIT")]
        PublicProfit,

        /// <summary>
        /// The entity is a non-profit organization.
        /// </summary>
        [JsonPropertyName("NON_PROFIT")]
        NonProfit,

        /// <summary>
        /// The entity is a sole proprietor business.
        /// </summary>
        [JsonPropertyName("SOLE_PROPRIETOR")]
        SoleProprietor,

        /// <summary>
        /// The entity is a government organization.
        /// </summary>
        [JsonPropertyName("GOVERNMENT")]
        Government
    }
}