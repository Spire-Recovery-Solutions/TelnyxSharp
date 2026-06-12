using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the resolution of an infringement claim. Set only when the claim status is resolved.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<InfringementClaimResolution>))]
    public enum InfringementClaimResolution
    {
        /// <summary>
        /// The claim was upheld against the DIR.
        /// </summary>
        [JsonStringEnumMemberName("upheld")]
        Upheld,

        /// <summary>
        /// The claim was rejected.
        /// </summary>
        [JsonStringEnumMemberName("rejected")]
        Rejected,

        /// <summary>
        /// The claim was resolved with modifications to the DIR.
        /// </summary>
        [JsonStringEnumMemberName("modified")]
        Modified
    }
}
