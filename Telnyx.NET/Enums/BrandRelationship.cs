using System.Text.Json.Serialization;
using Telnyx.NET.Converters;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the possible brand relationships with Telnyx.
    /// </summary>
    [JsonConverter(typeof(BrandRelationshipConverter))]
    public enum BrandRelationship
    {
       /// <summary>
        /// Unknown brand relationship status.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("UNKNOWN")]
        Unknown,

        /// <summary>
        /// Basic account relationship.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("BASIC_ACCOUNT")]
        BasicAccount,

        /// <summary>
        /// Small account relationship.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("SMALL_ACCOUNT")]
        SmallAccount,

        /// <summary>
        /// Medium account relationship.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("MEDIUM_ACCOUNT")]
        MediumAccount,

        /// <summary>
        /// Large account relationship.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("LARGE_ACCOUNT")]
        LargeAccount,

        /// <summary>
        /// Key account relationship.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("KEY_ACCOUNT")]
        KeyAccount
    }
}