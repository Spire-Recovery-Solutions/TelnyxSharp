using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the types of events associated with port-out operations.
    /// Each event type corresponds to a specific action or update in the port-out process.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PortoutEventType
    {
        /// <summary>
        /// Indicates that the status of the port-out request has changed.
        /// </summary>
        [JsonPropertyName("portout.status_changed")]
        StatusChanged,

        /// <summary>
        /// Indicates that a new comment has been added to the port-out request.
        /// </summary>
        [JsonPropertyName("portout.new_comment")]
        NewComment,

        /// <summary>
        /// Indicates that the FOC (Firm Order Commitment) date for the port-out request has changed.
        /// </summary>
        [JsonPropertyName("portout.foc_date_changed")]
        FocDateChanged
    }
}