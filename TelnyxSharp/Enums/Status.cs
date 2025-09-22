using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the various statuses of a resource.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<Status>))]
    public enum Status
    {
        /// <summary>
        /// Represents an unknown status.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents a deleted status.
        /// </summary>
        [JsonStringEnumMemberName("deleted")]
        Deleted,

        /// <summary>
        /// Represents a failed status.
        /// </summary>
        [JsonStringEnumMemberName("failed")]
        Failed,

        /// <summary>
        /// Represents a pending status.
        /// </summary>
        [JsonStringEnumMemberName("pending")]
        Pending,

        /// <summary>
        /// Represents a successful status.
        /// </summary>
        [JsonStringEnumMemberName("successful")]
        Successful,

        /// <summary>
        /// Represents a verified status.
        /// </summary>
        [JsonStringEnumMemberName("Verified")]
        Verified,

        /// <summary>
        /// Represents a rejected status.
        /// </summary>
        [JsonStringEnumMemberName("Rejected")]
        Rejected,

        /// <summary>
        /// Represents a status where the resource is waiting for vendor action.
        /// </summary>
        [JsonStringEnumMemberName("Waiting For Vendor")]
        WaitingForVendor,

        /// <summary>
        /// Represents a status where the resource is waiting for customer action.
        /// </summary>
        [JsonStringEnumMemberName("Waiting For Customer")]
        WaitingForCustomer,

        /// <summary>
        /// Represents a status where the resource is in progress.
        /// </summary>
        [JsonStringEnumMemberName("In Progress")]
        InProgress
    }
}