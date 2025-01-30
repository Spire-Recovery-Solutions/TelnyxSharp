using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the status of a requirement, providing a standardized way to
    /// describe the approval or decline state of a given requirement.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RequirementStatus
    {
        /// <summary>
        /// Indicates the requirement has been approved.
        /// </summary>
        [JsonPropertyName("approved")]
        Approved,

        /// <summary>
        /// Indicates the requirement has not been approved.
        /// </summary>
        [JsonPropertyName("unapproved")]
        Unapproved,

        /// <summary>
        /// Indicates the requirement is awaiting approval.
        /// </summary>
        [JsonPropertyName("pending-approval")]
        PendingApproval,

        /// <summary>
        /// Indicates the requirement has been declined.
        /// </summary>
        [JsonPropertyName("declined")]
        Declined
    }
}