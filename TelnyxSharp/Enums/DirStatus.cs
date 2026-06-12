using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the lifecycle status of a Display Identity Record (DIR) in the Branded Calling API.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<DirStatus>))]
    public enum DirStatus
    {
        /// <summary>
        /// Newly created; editable; not yet submitted.
        /// </summary>
        [JsonStringEnumMemberName("draft")]
        Draft,

        /// <summary>
        /// Submitted for vetting; Telnyx is reviewing.
        /// </summary>
        [JsonStringEnumMemberName("submitted")]
        Submitted,

        /// <summary>
        /// Telnyx is actively reviewing the DIR.
        /// </summary>
        [JsonStringEnumMemberName("in_review")]
        InReview,

        /// <summary>
        /// Approved; phone numbers may be attached.
        /// </summary>
        [JsonStringEnumMemberName("verified")]
        Verified,

        /// <summary>
        /// Telnyx rejected this submission; rejection reasons are populated and the DIR can be edited and resubmitted.
        /// </summary>
        [JsonStringEnumMemberName("rejected")]
        Rejected,

        /// <summary>
        /// A system-side error occurred during processing; the DIR can be edited and resubmitted.
        /// </summary>
        [JsonStringEnumMemberName("unsuccessful")]
        Unsuccessful,

        /// <summary>
        /// Temporarily disabled (e.g. by an active infringement claim).
        /// </summary>
        [JsonStringEnumMemberName("suspended")]
        Suspended,

        /// <summary>
        /// Verification expired; the DIR must be resubmitted.
        /// </summary>
        [JsonStringEnumMemberName("expired")]
        Expired,

        /// <summary>
        /// A trademark/impersonation claim is open against this DIR.
        /// </summary>
        [JsonStringEnumMemberName("infringement_claimed")]
        InfringementClaimed,

        /// <summary>
        /// Terminal state; the DIR cannot be resubmitted.
        /// </summary>
        [JsonStringEnumMemberName("permanently_rejected")]
        PermanentlyRejected
    }
}
