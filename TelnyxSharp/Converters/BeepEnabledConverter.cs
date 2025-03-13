using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="BeepEnabled"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from string representations.
    /// </summary>
    public class BeepEnabledConverter : JsonConverter<BeepEnabled>
    {
        /// <summary>
        /// Reads and deserializes a JSON string into a <see cref="BeepEnabled"/> enum value.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (always <see cref="BeepEnabled"/>).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A corresponding <see cref="BeepEnabled"/> enum value.</returns>
        /// <exception cref="JsonException">Thrown when the JSON value is not recognized.</exception>
        public override BeepEnabled Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "always" => BeepEnabled.Always,
                "never" => BeepEnabled.Never,
                "on_enter" => BeepEnabled.OnEnter,
                "on_exit" => BeepEnabled.OnExit,
                _ => throw new JsonException($"Value '{value}' is not supported for BeepEnabled enum")
            };
        }

        /// <summary>
        /// Serializes a <see cref="BeepEnabled"/> enum value into its corresponding string representation.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="BeepEnabled"/> enum value to serialize.</param>
        /// <param name="options">Serialization options.</param>
        /// <exception cref="JsonException">Thrown when an unsupported enum value is encountered.</exception>
        public override void Write(Utf8JsonWriter writer, BeepEnabled value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                BeepEnabled.Always => "always",
                BeepEnabled.Never => "never",
                BeepEnabled.OnEnter => "on_enter",
                BeepEnabled.OnExit => "on_exit",
                _ => throw new JsonException($"Value '{value}' is not supported for BeepEnabled enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}
