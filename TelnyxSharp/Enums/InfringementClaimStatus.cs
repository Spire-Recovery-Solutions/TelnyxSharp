using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the lifecycle status of an infringement claim filed against a Display Identity Record (DIR).
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<InfringementClaimStatus>))]
    public enum InfringementClaimStatus
    {
        /// <summary>
        /// Newly filed; the DIR is auto-suspended.
        /// </summary>
        [JsonStringEnumMemberName("pending")]
        Pending,

        /// <summary>
        /// Contest evidence has been submitted; awaiting Telnyx review.
        /// </summary>
        [JsonStringEnumMemberName("contested")]
        Contested,

        /// <summary>
        /// Final state; the claim has been resolved.
        /// </summary>
        [JsonStringEnumMemberName("resolved")]
        Resolved
    }
}
