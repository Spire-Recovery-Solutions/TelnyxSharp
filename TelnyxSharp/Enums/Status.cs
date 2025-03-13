using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
     /// <summary>
    /// Enum representing the various statuses of a resource.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status
    {
        /// <summary>
        /// Represents an unknown status.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents a deleted status.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("deleted")]
        Deleted,

        /// <summary>
        /// Represents a failed status.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("failed")]
        Failed,

        /// <summary>
        /// Represents a pending status.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pending")]
        Pending,

        /// <summary>
        /// Represents a successful status.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("successful")]
        Successful,

        /// <summary>
        /// Represents a verified status.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Verified")]
        Verified,

        /// <summary>
        /// Represents a rejected status.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Rejected")]
        Rejected,

        /// <summary>
        /// Represents a status where the resource is waiting for vendor action.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Waiting For Vendor")]
        WaitingForVendor,

        /// <summary>
        /// Represents a status where the resource is waiting for customer action.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Waiting For Customer")]
        WaitingForCustomer,

        /// <summary>
        /// Represents a status where the resource is in progress.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("In Progress")]
        InProgress
    }
}