using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="EntityType"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class EntityTypeConverter : JsonConverter<EntityType>
    {
        /// <summary>
        /// Reads and deserializes a JSON string into a <see cref="EntityType"/> enum value.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (always <see cref="EntityType"/>).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A corresponding <see cref="EntityType"/> enum value.</returns>
        /// <exception cref="JsonException">Thrown when the JSON value is not recognized.</exception>
        public override EntityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "Unknown" => EntityType.Unknown,
                "PRIVATE_PROFIT" => EntityType.PrivateProfit,
                "PUBLIC_PROFIT" => EntityType.PublicProfit,
                "NON_PROFIT" => EntityType.NonProfit,
                "SOLE_PROPRIETOR" => EntityType.SoleProprietor,
                "GOVERNMENT" => EntityType.Government,
                _ => throw new JsonException($"Value '{value}' is not supported for EntityType enum")
            };
        }

        /// <summary>
        /// Serializes a <see cref="EntityType"/> enum value into its corresponding string representation.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="EntityType"/> enum value to serialize.</param>
        /// <param name="options">Serialization options.</param>
        /// <exception cref="JsonException">Thrown when an unsupported enum value is encountered.</exception>
        public override void Write(Utf8JsonWriter writer, EntityType value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                EntityType.Unknown => "Unknown",
                EntityType.PrivateProfit => "PRIVATE_PROFIT",
                EntityType.PublicProfit => "PUBLIC_PROFIT",
                EntityType.NonProfit => "NON_PROFIT",
                EntityType.SoleProprietor => "SOLE_PROPRIETOR",
                EntityType.Government => "GOVERNMENT",
                _ => throw new JsonException($"Value '{value}' is not supported for EntityType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
