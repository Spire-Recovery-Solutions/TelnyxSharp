using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="MessageRecordType"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class MessageRecordTypeConverter : JsonConverter<MessageRecordType>
    {
        public override Enums.MessageRecordType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "Unknown" => MessageRecordType.Unknown,
                "messaging_phone_number" => MessageRecordType.MessagingPhoneNumber,
                "messaging_settings" => MessageRecordType.MessagingSettings,
                "messaging_profile" => MessageRecordType.MessageProfile,
                "short_code" => MessageRecordType.ShortCode,
                "messaging_profile_metrics" => MessageRecordType.MessageProfileMetrics,
                "message" => MessageRecordType.Message,
                "messaging_numbers_bulk_update" => MessageRecordType.MessageNumbersBulkUpdate,
                _ => throw new JsonException($"Value '{value}' is not supported for MessageRecordType enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, MessageRecordType value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                MessageRecordType.Unknown => "Unknown",
                MessageRecordType.MessagingPhoneNumber => "messaging_phone_number",
                MessageRecordType.MessagingSettings => "messaging_settings",
                MessageRecordType.MessageProfile => "messaging_profile",
                MessageRecordType.ShortCode => "short_code",
                MessageRecordType.MessageProfileMetrics => "messaging_profile_metrics",
                MessageRecordType.Message => "message",
                MessageRecordType.MessageNumbersBulkUpdate => "messaging_numbers_bulk_update",
                _ => throw new JsonException($"Value '{value}' is not supported for MessageRecordType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
