using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the various statuses of a porting order.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PortingOrderStatus
    {
        /// <summary>
        /// The activation process is in progress.
        /// </summary>
        [JsonStringEnumMemberName("activation-in-progress")]
        ActivationInProgress,

        /// <summary>
        /// The cancellation process is pending.
        /// </summary>
        [JsonStringEnumMemberName("cancel-pending")]
        CancelPending,

        /// <summary>
        /// The porting order has been cancelled.
        /// </summary>
        [JsonStringEnumMemberName("cancelled")]
        Cancelled,

        /// <summary>
        /// The porting order is in draft state.
        /// </summary>
        [JsonStringEnumMemberName("draft")]
        Draft,

        /// <summary>
        /// An exception occurred during processing.
        /// </summary>
        [JsonStringEnumMemberName("exception")]
        Exception,

        /// <summary>
        /// The Firm Order Commitment (FOC) date has been confirmed.
        /// </summary>
        [JsonStringEnumMemberName("foc-date-confirmed")]
        FocDateConfirmed,

        /// <summary>
        /// The porting order is currently in process.
        /// </summary>
        [JsonStringEnumMemberName("in-process")]
        InProcess,

        /// <summary>
        /// The phone number has been successfully ported.
        /// </summary>
        [JsonStringEnumMemberName("ported")]
        Ported,

        /// <summary>
        /// The porting order has been submitted for processing.
        /// </summary>
        [JsonStringEnumMemberName("submitted")]
        Submitted
    }
}