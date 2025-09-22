using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the status of a requirement, providing a standardized way to
    /// describe the approval or decline state of a given requirement.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<RequirementStatus>))]
    public enum RequirementStatus
    {
        /// <summary>
        /// Indicates the requirement has been approved.
        /// </summary>
        [JsonStringEnumMemberName("approved")]
        Approved,

        /// <summary>
        /// Indicates the requirement has not been approved.
        /// </summary>
        [JsonStringEnumMemberName("unapproved")]
        Unapproved,

        /// <summary>
        /// Indicates the requirement is awaiting approval.
        /// </summary>
        [JsonStringEnumMemberName("pending-approval")]
        PendingApproval,

        /// <summary>
        /// Indicates the requirement has been declined.
        /// </summary>
        [JsonStringEnumMemberName("declined")]
        Declined
    }
}