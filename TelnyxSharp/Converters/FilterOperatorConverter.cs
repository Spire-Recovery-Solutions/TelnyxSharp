using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="FilterOperator"/> enum.
    /// This converter handles the serialization and deserialization of <see cref="FilterOperator"/>
    /// values to and from their corresponding string representations.
    /// </summary>
    public class FilterOperatorConverter : JsonConverter<FilterOperator>
    {
        /// <summary>
        /// Reads and deserializes a JSON string into a <see cref="FilterOperator"/> enum value.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (always <see cref="FilterOperator"/>).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>The corresponding <see cref="FilterOperator"/> enum value.</returns>
        /// <exception cref="JsonException">Thrown when the JSON string value is not supported.</exception>
        public override FilterOperator Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "eq" => FilterOperator.Eq,
                "ne" => FilterOperator.Ne,
                "gt" => FilterOperator.Gt,
                "gte" => FilterOperator.Gte,
                "lt" => FilterOperator.Lt,
                "lte" => FilterOperator.Lte,
                "starts_with" => FilterOperator.StartsWith,
                "ends_with" => FilterOperator.EndsWith,
                "contains" => FilterOperator.Contains,
                _ => throw new JsonException($"Value '{value}' is not supported for FilterOperator enum")
            };
        }

        /// <summary>
        /// Serializes a <see cref="FilterOperator"/> enum value into its corresponding string representation.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="FilterOperator"/> enum value to serialize.</param>
        /// <param name="options">Serialization options.</param>
        /// <exception cref="JsonException">Thrown when the enum value is not supported.</exception>
        public override void Write(Utf8JsonWriter writer, FilterOperator value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                FilterOperator.Eq => "eq",
                FilterOperator.Ne => "ne",
                FilterOperator.Gt => "gt",
                FilterOperator.Gte => "gte",
                FilterOperator.Lt => "lt",
                FilterOperator.Lte => "lte",
                FilterOperator.StartsWith => "starts_with",
                FilterOperator.EndsWith => "ends_with",
                FilterOperator.Contains => "contains",
                _ => throw new JsonException($"Value '{value}' is not supported for FilterOperator enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}