using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the various statuses of a port-out request.
    /// Each status reflects the current state of the port-out process.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PortoutStatus
    {
        /// <summary>
        /// The port-out request is pending and awaiting further action.
        /// </summary>
        [JsonPropertyName("pending")]
        Pending,

        /// <summary>
        /// The port-out request has been authorized for processing.
        /// </summary>
        [JsonPropertyName("authorized")]
        Authorized,

        /// <summary>
        /// The port-out process has been completed, and the number has been successfully ported.
        /// </summary>
        [JsonPropertyName("ported")]
        Ported,

        /// <summary>
        /// The port-out request has been rejected.
        /// </summary>
        [JsonPropertyName("rejected")]
        Rejected,

        /// <summary>
        /// The port-out request was initially rejected but is now pending further review or updates.
        /// </summary>
        [JsonPropertyName("rejected-pending")]
        RejectedPending,

        /// <summary>
        /// The port-out request has been canceled.
        /// </summary>
        [JsonPropertyName("canceled")]
        Canceled,

        /// <summary>
        /// The port-out process has been completed successfully.
        /// </summary>
        [JsonPropertyName("completed")]
        Completed
    }
}