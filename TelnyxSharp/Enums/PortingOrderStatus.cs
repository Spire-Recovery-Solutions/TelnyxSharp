using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the various statuses of a porting order.
    /// </summary>
    [JsonConverter(typeof(Converters.PortingOrderStatusConverter))]
    public enum PortingOrderStatus
    {
         /// <summary>
        /// The activation process is in progress.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("activation-in-progress")]
        ActivationInProgress,

        /// <summary>
        /// The cancellation process is pending.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("cancel-pending")]
        CancelPending,

        /// <summary>
        /// The porting order has been cancelled.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("cancelled")]
        Cancelled,

        /// <summary>
        /// The porting order is in draft state.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("draft")]
        Draft,

        /// <summary>
        /// An exception occurred during processing.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("exception")]
        Exception,

        /// <summary>
        /// The Firm Order Commitment (FOC) date has been confirmed.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("foc-date-confirmed")]
        FocDateConfirmed,

        /// <summary>
        /// The porting order is currently in process.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("in-process")]
        InProcess,

        /// <summary>
        /// The phone number has been successfully ported.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ported")]
        Ported,

        /// <summary>
        /// The porting order has been submitted for processing.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("submitted")]
        Submitted
    }
}