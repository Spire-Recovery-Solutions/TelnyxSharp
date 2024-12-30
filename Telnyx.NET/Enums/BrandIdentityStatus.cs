using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the different possible statuses of brand identity verification.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BrandIdentityStatus
    {
        /// <summary>
        /// The brand identity has been verified.
        /// </summary>
        [JsonPropertyName("VERIFIED")]
        Verified,

        /// <summary>
        /// The brand identity has not been verified.
        /// </summary>
        [JsonPropertyName("UNVERIFIED")]
        Unverified,

        /// <summary>
        /// The brand identity has been self-declared.
        /// </summary>
        [JsonPropertyName("SELF_DECLARED")]
        SelfDeclared,

        /// <summary>
        /// The brand identity has been vetted and verified.
        /// </summary>
        [JsonPropertyName("VETTED_VERIFIED")]
        VettedVerified
    }
}