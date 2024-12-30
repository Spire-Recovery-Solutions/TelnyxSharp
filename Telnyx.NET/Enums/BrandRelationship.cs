using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the possible brand relationships with Telnyx.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BrandRelationship
    {
        /// <summary>
        /// Unknown brand relationship status.
        /// </summary>
        [JsonPropertyName("UNKNOWN")]
        Unknown,

        /// <summary>
        /// Basic account relationship.
        /// </summary>
        [JsonPropertyName("BASIC_ACCOUNT")]
        BasicAccount,

        /// <summary>
        /// Small account relationship.
        /// </summary>
        [JsonPropertyName("SMALL_ACCOUNT")]
        SmallAccount,

        /// <summary>
        /// Medium account relationship.
        /// </summary>
        [JsonPropertyName("MEDIUM_ACCOUNT")]
        MediumAccount,

        /// <summary>
        /// Large account relationship.
        /// </summary>
        [JsonPropertyName("LARGE_ACCOUNT")]
        LargeAccount,

        /// <summary>
        /// Key account relationship.
        /// </summary>
        [JsonPropertyName("KEY_ACCOUNT")]
        KeyAccount
    }
}