using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the different possible statuses of brand identity verification.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<BrandIdentityStatus>))]
    public enum BrandIdentityStatus
    {
        /// <summary>
        /// The brand identity has been verified.
        /// </summary>
        [JsonStringEnumMemberName("VERIFIED")]
        Verified,

        /// <summary>
        /// The brand identity has not been verified.
        /// </summary>
        [JsonStringEnumMemberName("UNVERIFIED")]
        Unverified,

        /// <summary>
        /// The brand identity has been self-declared.
        /// </summary>
        [JsonStringEnumMemberName("SELF_DECLARED")]
        SelfDeclared,

        /// <summary>
        /// The brand identity has been vetted and verified.
        /// </summary>
        [JsonStringEnumMemberName("VETTED_VERIFIED")]
        VettedVerified
    }
}