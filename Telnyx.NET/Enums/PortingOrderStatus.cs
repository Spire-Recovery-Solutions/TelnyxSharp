using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
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
        [JsonPropertyName("activation-in-progress")]
        ActivationInProgress,

        /// <summary>
        /// The cancellation process is pending.
        /// </summary>
        [JsonPropertyName("cancel-pending")]
        CancelPending,

        /// <summary>
        /// The porting order has been cancelled.
        /// </summary>
        [JsonPropertyName("cancelled")]
        Cancelled,

        /// <summary>
        /// The porting order is in draft state.
        /// </summary>
        [JsonPropertyName("draft")]
        Draft,

        /// <summary>
        /// An exception occurred during processing.
        /// </summary>
        [JsonPropertyName("exception")]
        Exception,

        /// <summary>
        /// The Firm Order Commitment (FOC) date has been confirmed.
        /// </summary>
        [JsonPropertyName("foc-date-confirmed")]
        FocDateConfirmed,

        /// <summary>
        /// The porting order is currently in process.
        /// </summary>
        [JsonPropertyName("in-process")]
        InProcess,

        /// <summary>
        /// The phone number has been successfully ported.
        /// </summary>
        [JsonPropertyName("ported")]
        Ported,

        /// <summary>
        /// The porting order has been submitted for processing.
        /// </summary>
        [JsonPropertyName("submitted")]
        Submitted
    }
}