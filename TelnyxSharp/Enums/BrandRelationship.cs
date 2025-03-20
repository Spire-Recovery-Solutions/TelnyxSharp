using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
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
        [JsonStringEnumMemberName("UNKNOWN")]
        Unknown,

        /// <summary>
        /// Basic account relationship.
        /// </summary>
        [JsonStringEnumMemberName("BASIC_ACCOUNT")]
        BasicAccount,

        /// <summary>
        /// Small account relationship.
        /// </summary>
        [JsonStringEnumMemberName("SMALL_ACCOUNT")]
        SmallAccount,

        /// <summary>
        /// Medium account relationship.
        /// </summary>
        [JsonStringEnumMemberName("MEDIUM_ACCOUNT")]
        MediumAccount,

        /// <summary>
        /// Large account relationship.
        /// </summary>
        [JsonStringEnumMemberName("LARGE_ACCOUNT")]
        LargeAccount,

        /// <summary>
        /// Key account relationship.
        /// </summary>
        [JsonStringEnumMemberName("KEY_ACCOUNT")]
        KeyAccount
    }
}