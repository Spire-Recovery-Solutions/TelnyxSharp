using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="SortVoice"/> enum.
    /// This converter handles serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class SortVoiceConverter : JsonConverter<SortVoice>
    {
        public override SortVoice Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "created_at" => SortVoice.CreatedAt,
                "connection_name" => SortVoice.ConnectionName,
                "active" => SortVoice.Active,
                _ => throw new JsonException($"Value '{value}' is not supported for SortVoice enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, SortVoice value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                SortVoice.CreatedAt => "created_at",
                SortVoice.ConnectionName => "connection_name",
                SortVoice.Active => "active",
                _ => throw new JsonException($"Value '{value}' is not supported for SortVoice enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
