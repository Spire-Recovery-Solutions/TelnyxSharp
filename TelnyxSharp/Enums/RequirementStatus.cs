using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the status of a requirement, providing a standardized way to
    /// describe the approval or decline state of a given requirement.
    /// </summary>
    [JsonConverter(typeof(RequirementStatusConverter))]
    public enum RequirementStatus
    {
        /// <summary>
        /// Indicates the requirement has been approved.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("approved")]
        Approved,

        /// <summary>
        /// Indicates the requirement has not been approved.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("unapproved")]
        Unapproved,

        /// <summary>
        /// Indicates the requirement is awaiting approval.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pending-approval")]
        PendingApproval,

        /// <summary>
        /// Indicates the requirement has been declined.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("declined")]
        Declined
    }
}