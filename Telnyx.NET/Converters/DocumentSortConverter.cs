using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="DocumentSort"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class DocumentSortConverter : JsonConverter<DocumentSort>
    {
        /// <summary>
        /// Reads and deserializes a JSON string into a <see cref="DocumentSort"/> enum value.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (always <see cref="DocumentSort"/>).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A corresponding <see cref="DocumentSort"/> enum value.</returns>
        /// <exception cref="JsonException">Thrown when the JSON value is not recognized.</exception>
        public override DocumentSort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "filename" => DocumentSort.FilenameAsc,
                "-filename" => DocumentSort.FilenameDesc,
                "created_at" => DocumentSort.CreatedAtAsc,
                "-created_at" => DocumentSort.CreatedAtDesc,
                "updated_at" => DocumentSort.UpdatedAtAsc,
                "-updated_at" => DocumentSort.UpdatedAtDesc,
                _ => throw new JsonException($"Value '{value}' is not supported for DocumentSort enum")
            };
        }

        /// <summary>
        /// Serializes a <see cref="DocumentSort"/> enum value into its corresponding string representation.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="DocumentSort"/> enum value to serialize.</param>
        /// <param name="options">Serialization options.</param>
        /// <exception cref="JsonException">Thrown when an unsupported enum value is encountered.</exception>
        public override void Write(Utf8JsonWriter writer, DocumentSort value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                DocumentSort.FilenameAsc => "filename",
                DocumentSort.FilenameDesc => "-filename",
                DocumentSort.CreatedAtAsc => "created_at",
                DocumentSort.CreatedAtDesc => "-created_at",
                DocumentSort.UpdatedAtAsc => "updated_at",
                DocumentSort.UpdatedAtDesc => "-updated_at",
                _ => throw new JsonException($"Value '{value}' is not supported for DocumentSort enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }

}
