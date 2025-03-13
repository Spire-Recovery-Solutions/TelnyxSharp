using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the different possible statuses of brand identity verification.
    /// </summary>
    [JsonConverter(typeof(BrandIdentityStatusConverter))]
    public enum BrandIdentityStatus
    {
         /// <summary>
        /// The brand identity has been verified.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("VERIFIED")]
        Verified,

        /// <summary>
        /// The brand identity has not been verified.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("UNVERIFIED")]
        Unverified,

        /// <summary>
        /// The brand identity has been self-declared.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("SELF_DECLARED")]
        SelfDeclared,

        /// <summary>
        /// The brand identity has been vetted and verified.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("VETTED_VERIFIED")]
        VettedVerified
    }
}