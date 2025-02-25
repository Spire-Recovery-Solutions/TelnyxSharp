using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="PortoutStatus"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class PortoutStatusConverter : JsonConverter<PortoutStatus>
    {
        public override PortoutStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "pending" => PortoutStatus.Pending,
                "authorized" => PortoutStatus.Authorized,
                "ported" => PortoutStatus.Ported,
                "rejected" => PortoutStatus.Rejected,
                "rejected-pending" => PortoutStatus.RejectedPending,
                "canceled" => PortoutStatus.Canceled,
                "completed" => PortoutStatus.Completed,
                _ => throw new JsonException($"Value '{value}' is not supported for PortoutStatus enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, PortoutStatus value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                PortoutStatus.Pending => "pending",
                PortoutStatus.Authorized => "authorized",
                PortoutStatus.Ported => "ported",
                PortoutStatus.Rejected => "rejected",
                PortoutStatus.RejectedPending => "rejected-pending",
                PortoutStatus.Canceled => "canceled",
                PortoutStatus.Completed => "completed",
                _ => throw new JsonException($"Value '{value}' is not supported for PortoutStatus enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
