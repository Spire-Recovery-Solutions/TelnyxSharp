using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="PortingOrderPermission"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class PortingOrderPermissionConverter : JsonConverter<PortingOrderPermission>
    {
        public override PortingOrderPermission Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "porting_order.document.read" => PortingOrderPermission.DocumentRead,
                "porting_order.document.update" => PortingOrderPermission.DocumentUpdate,
                _ => throw new JsonException($"Value '{value}' is not supported for PortingOrderPermission enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, PortingOrderPermission value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                PortingOrderPermission.DocumentRead => "porting_order.document.read",
                PortingOrderPermission.DocumentUpdate => "porting_order.document.update",
                _ => throw new JsonException($"Value '{value}' is not supported for PortingOrderPermission enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
