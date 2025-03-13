using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="PortoutEventType"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class PortoutEventTypeConverter : JsonConverter<PortoutEventType>
    {
        public override PortoutEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "portout.status_changed" => PortoutEventType.StatusChanged,
                "portout.new_comment" => PortoutEventType.NewComment,
                "portout.foc_date_changed" => PortoutEventType.FocDateChanged,
                _ => throw new JsonException($"Value '{value}' is not supported for PortoutEventType enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, PortoutEventType value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                PortoutEventType.StatusChanged => "portout.status_changed",
                PortoutEventType.NewComment => "portout.new_comment",
                PortoutEventType.FocDateChanged => "portout.foc_date_changed",
                _ => throw new JsonException($"Value '{value}' is not supported for PortoutEventType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
