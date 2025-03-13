using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents the types of events associated with port-out operations.
    /// Each event type corresponds to a specific action or update in the port-out process.
    /// </summary>
    [JsonConverter(typeof(Converters.PortoutEventTypeConverter))]
    public enum PortoutEventType
    {
       /// <summary>
        /// Indicates that the status of the port-out request has changed.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("portout.status_changed")]
        StatusChanged,

        /// <summary>
        /// Indicates that a new comment has been added to the port-out request.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("portout.new_comment")]
        NewComment,

        /// <summary>
        /// Indicates that the FOC (Firm Order Commitment) date for the port-out request has changed.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("portout.foc_date_changed")]
        FocDateChanged
    }
}