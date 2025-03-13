using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="AltBusinessIdType"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from string representations.
    /// </summary>
    public class AltBusinessIdTypeConverter : JsonConverter<AltBusinessIdType>
    {
        /// <summary>
        /// Reads and deserializes a JSON string into a <see cref="AltBusinessIdType"/> enum value.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (always <see cref="AltBusinessIdType"/>).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A corresponding <see cref="AltBusinessIdType"/> enum value.</returns>
        /// <exception cref="JsonException">Thrown when the JSON value is not recognized.</exception>
        public override AltBusinessIdType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "NONE" => AltBusinessIdType.None,
                "DUNS" => AltBusinessIdType.Duns,
                "GIIN" => AltBusinessIdType.Giin,
                "LEI" => AltBusinessIdType.Lei,
                _ => throw new JsonException($"Value '{value}' is not supported for AltBusinessIdType enum")
            };
        }

        /// <summary>
        /// Serializes a <see cref="AltBusinessIdType"/> enum value into its corresponding string representation.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="AltBusinessIdType"/> enum value to serialize.</param>
        /// <param name="options">Serialization options.</param>
        /// <exception cref="JsonException">Thrown when an unsupported enum value is encountered.</exception>
        public override void Write(Utf8JsonWriter writer, AltBusinessIdType value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                AltBusinessIdType.None => "NONE",
                AltBusinessIdType.Duns => "DUNS",
                AltBusinessIdType.Giin => "GIIN",
                AltBusinessIdType.Lei => "LEI",
                _ => throw new JsonException($"Value '{value}' is not supported for AltBusinessIdType enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}
