using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
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
        [JsonPropertyName("deleted")]
        Deleted,

        /// <summary>
        /// Represents a failed status.
        /// </summary>
        [JsonPropertyName("failed")]
        Failed,

        /// <summary>
        /// Represents a pending status.
        /// </summary>
        [JsonPropertyName("pending")]
        Pending,

        /// <summary>
        /// Represents a successful status.
        /// </summary>
        [JsonPropertyName("successful")]
        Successful,

        /// <summary>
        /// Represents a verified status.
        /// </summary>
        [JsonPropertyName("Verified")]
        Verified,

        /// <summary>
        /// Represents a rejected status.
        /// </summary>
        [JsonPropertyName("Rejected")]
        Rejected,

        /// <summary>
        /// Represents a status where the resource is waiting for vendor action.
        /// </summary>
        [JsonPropertyName("Waiting For Vendor")]
        WaitingForVendor,

        /// <summary>
        /// Represents a status where the resource is waiting for customer action.
        /// </summary>
        [JsonPropertyName("Waiting For Customer")]
        WaitingForCustomer,

        /// <summary>
        /// Represents a status where the resource is in progress.
        /// </summary>
        [JsonPropertyName("In Progress")]
        InProgress
    }
}