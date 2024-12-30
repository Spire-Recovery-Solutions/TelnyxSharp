using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the different types of message records.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageRecordType
    {
        /// <summary>
        /// Unknown message record type.
        /// </summary>
        Unknown,

        /// <summary>
        /// Represents a messaging phone number record.
        /// </summary>
        [JsonPropertyName("messaging_phone_number")]
        MessagingPhoneNumber,

        /// <summary>
        /// Represents a messaging settings record.
        /// </summary>
        [JsonPropertyName("messaging_settings")]
        MessagingSettings,

        /// <summary>
        /// Represents a messaging profile record.
        /// </summary>
        [JsonPropertyName("messaging_profile")]
        MessageProfile,

        /// <summary>
        /// Represents a short code message record.
        /// </summary>
        [JsonPropertyName("short_code")]
        ShortCode,

        /// <summary>
        /// Represents a messaging profile metrics record.
        /// </summary>
        [JsonPropertyName("messaging_profile_metrics")]
        MessageProfileMetrics,

        /// <summary>
        /// Represents a message record.
        /// </summary>
        [JsonPropertyName("message")]
        Message,

        /// <summary>
        /// Represents a bulk update of messaging numbers.
        /// </summary>
        [JsonPropertyName("messaging_numbers_bulk_update")]
        MessageNumbersBulkUpdate
    }
}