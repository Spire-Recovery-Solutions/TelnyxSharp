using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the different types of message records.
    /// </summary>
    [JsonConverter(typeof(MessageRecordTypeConverter))]
    public enum MessageRecordType
    {
         /// <summary>
        /// Unknown message record type.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents a messaging phone number record.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("messaging_phone_number")]
        MessagingPhoneNumber,

        /// <summary>
        /// Represents a messaging settings record.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("messaging_settings")]
        MessagingSettings,

        /// <summary>
        /// Represents a messaging profile record.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("messaging_profile")]
        MessageProfile,

        /// <summary>
        /// Represents a short code message record.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("short_code")]
        ShortCode,

        /// <summary>
        /// Represents a messaging profile metrics record.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("messaging_profile_metrics")]
        MessageProfileMetrics,

        /// <summary>
        /// Represents a message record.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("message")]
        Message,

        /// <summary>
        /// Represents a bulk update of messaging numbers.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("messaging_numbers_bulk_update")]
        MessageNumbersBulkUpdate
    }
}