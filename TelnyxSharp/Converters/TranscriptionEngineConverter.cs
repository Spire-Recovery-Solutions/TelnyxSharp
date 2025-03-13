using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="TranscriptionEngine"/> enum.
    /// </summary>
    public class TranscriptionEngineConverter : JsonConverter<TranscriptionEngine>
    {
        public override TranscriptionEngine Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "A" => TranscriptionEngine.Google,
                "B" => TranscriptionEngine.Telnyx,
                _ => throw new JsonException($"Value '{value}' is not supported for TranscriptionEngine enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, TranscriptionEngine value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                TranscriptionEngine.Google => "A",
                TranscriptionEngine.Telnyx => "B",
                _ => throw new JsonException($"Value '{value}' is not supported for TranscriptionEngine enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}
