using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the categorisation of a comment on a Display Identity Record (DIR).
    /// Customers post <see cref="CustomerInquiry"/>; the Telnyx team posts the remaining categories.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<DirCommentType>))]
    public enum DirCommentType
    {
        /// <summary>
        /// A comment from the Telnyx vetting team about the vetting process.
        /// </summary>
        [JsonStringEnumMemberName("vetting_comment")]
        VettingComment,

        /// <summary>
        /// A comment explaining why the DIR was rejected.
        /// </summary>
        [JsonStringEnumMemberName("rejection_reason")]
        RejectionReason,

        /// <summary>
        /// An internal note. Filtered out of customer-visible responses.
        /// </summary>
        [JsonStringEnumMemberName("internal_note")]
        InternalNote,

        /// <summary>
        /// A notification from the Telnyx team.
        /// </summary>
        [JsonStringEnumMemberName("notification")]
        Notification,

        /// <summary>
        /// A status update from the Telnyx team.
        /// </summary>
        [JsonStringEnumMemberName("status_update")]
        StatusUpdate,

        /// <summary>
        /// An inquiry posted by the customer.
        /// </summary>
        [JsonStringEnumMemberName("customer_inquiry")]
        CustomerInquiry,

        /// <summary>
        /// A response from the Telnyx team to a customer inquiry.
        /// </summary>
        [JsonStringEnumMemberName("admin_response")]
        AdminResponse
    }
}
