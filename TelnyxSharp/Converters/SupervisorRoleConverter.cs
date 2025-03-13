using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="SupervisorRole"/> enum.
    /// </summary>
    public class SupervisorRoleConverter : JsonConverter<SupervisorRole>
    {
        public override SupervisorRole Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "barge" => SupervisorRole.Barge,
                "monitor" => SupervisorRole.Monitor,
                "none" => SupervisorRole.None,
                "whisper" => SupervisorRole.Whisper,
                _ => throw new JsonException($"Value '{value}' is not supported for SupervisorRole enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, SupervisorRole value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                SupervisorRole.Barge => "barge",
                SupervisorRole.Monitor => "monitor",
                SupervisorRole.None => "none",
                SupervisorRole.Whisper => "whisper",
                _ => throw new JsonException($"Value '{value}' is not supported for SupervisorRole enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}
