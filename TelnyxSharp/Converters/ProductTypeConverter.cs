using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="ProductType"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class ProductTypeConverter : JsonConverter<ProductType>
    {
        public override ProductType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "call_control" => ProductType.CallControl,
                "fax" => ProductType.Fax,
                "texml" => ProductType.Texml,
                _ => throw new JsonException($"Value '{value}' is not supported for ProductType enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, ProductType value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                ProductType.CallControl => "call_control",
                ProductType.Fax => "fax",
                ProductType.Texml => "texml",
                _ => throw new JsonException($"Value '{value}' is not supported for ProductType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
