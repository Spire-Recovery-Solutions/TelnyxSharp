﻿using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the various statuses of a port-out request.
    /// Each status reflects the current state of the port-out process.
    /// </summary>
    [JsonConverter(typeof(Converters.PortoutStatusConverter))]
    public enum PortoutStatus
    {
       /// <summary>
        /// The port-out request is pending and awaiting further action.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pending")]
        Pending,

        /// <summary>
        /// The port-out request has been authorized for processing.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("authorized")]
        Authorized,

        /// <summary>
        /// The port-out process has been completed, and the number has been successfully ported.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ported")]
        Ported,

        /// <summary>
        /// The port-out request has been rejected.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("rejected")]
        Rejected,

        /// <summary>
        /// The port-out request was initially rejected but is now pending further review or updates.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("rejected-pending")]
        RejectedPending,

        /// <summary>
        /// The port-out request has been canceled.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("canceled")]
        Canceled,

        /// <summary>
        /// The port-out process has been completed successfully.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("completed")]
        Completed
    }
}