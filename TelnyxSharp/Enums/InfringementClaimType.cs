using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the category of infringement being claimed against a Display Identity Record (DIR).
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<InfringementClaimType>))]
    public enum InfringementClaimType
    {
        /// <summary>
        /// A trademark infringement claim.
        /// </summary>
        [JsonStringEnumMemberName("trademark")]
        Trademark,

        /// <summary>
        /// A copyright infringement claim.
        /// </summary>
        [JsonStringEnumMemberName("copyright")]
        Copyright
    }
}
