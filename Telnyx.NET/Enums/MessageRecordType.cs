using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageRecordType
    {
        Unknown,

        [JsonPropertyName("messaging_phone_number")]
        MessagingPhoneNumber,

        [JsonPropertyName("messaging_settings")]
        MessagingSettings,

        [JsonPropertyName("messaging_profile")]
        MessageProfile,

        [JsonPropertyName("short_code")]
        ShortCode,

        [JsonPropertyName("messaging_profile_metrics")]
        MessageProfileMetrics,

        [JsonPropertyName("message")]
        Message,

        [JsonPropertyName("messaging_numbers_bulk_update")]
        MessageNumbersBulkUpdate
    }
}
