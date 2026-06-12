using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the lifecycle status of a phone number attached to a Display Identity Record (DIR)
    /// in the Branded Calling API.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<DirPhoneNumberStatus>))]
    public enum DirPhoneNumberStatus
    {
        /// <summary>
        /// The batch this number belongs to has been submitted for vetting.
        /// </summary>
        [JsonStringEnumMemberName("submitted")]
        Submitted,

        /// <summary>
        /// Telnyx is reviewing the batch this number belongs to.
        /// </summary>
        [JsonStringEnumMemberName("in_review")]
        InReview,

        /// <summary>
        /// Approved; the DIR's display identity will be shown on outbound calls from this number.
        /// </summary>
        [JsonStringEnumMemberName("verified")]
        Verified,

        /// <summary>
        /// Telnyx rejected this submission; the customer may re-add the number to retry.
        /// </summary>
        [JsonStringEnumMemberName("unsuccessful")]
        Unsuccessful,

        /// <summary>
        /// Temporarily disabled (e.g. by an active infringement claim on the DIR).
        /// </summary>
        [JsonStringEnumMemberName("suspended")]
        Suspended,

        /// <summary>
        /// Verification expired; re-add the number to renew.
        /// </summary>
        [JsonStringEnumMemberName("expired")]
        Expired,

        /// <summary>
        /// Terminal state; the number cannot be re-added on this or any other DIR the customer owns.
        /// </summary>
        [JsonStringEnumMemberName("permanently_rejected")]
        PermanentlyRejected
    }
}
