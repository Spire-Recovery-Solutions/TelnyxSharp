using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="ConferenceStatus"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class ConferenceStatusConverter : JsonConverter<ConferenceStatus>
    {
        /// <summary>
        /// Reads and deserializes a JSON string into a <see cref="ConferenceStatus"/> enum value.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (always <see cref="ConferenceStatus"/>).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A corresponding <see cref="ConferenceStatus"/> enum value.</returns>
        /// <exception cref="JsonException">Thrown when the JSON value is not recognized.</exception>
        public override ConferenceStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "init" => ConferenceStatus.Init,
                "in_progress" => ConferenceStatus.InProgress,
                "completed" => ConferenceStatus.Completed,
                _ => throw new JsonException($"Value '{value}' is not supported for ConferenceStatus enum")
            };
        }

        /// <summary>
        /// Serializes a <see cref="ConferenceStatus"/> enum value into its corresponding string representation.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="ConferenceStatus"/> enum value to serialize.</param>
        /// <param name="options">Serialization options.</param>
        /// <exception cref="JsonException">Thrown when an unsupported enum value is encountered.</exception>
        public override void Write(Utf8JsonWriter writer, ConferenceStatus value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                ConferenceStatus.Init => "init",
                ConferenceStatus.InProgress => "in_progress",
                ConferenceStatus.Completed => "completed",
                _ => throw new JsonException($"Value '{value}' is not supported for ConferenceStatus enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
