using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="VoiceType"/> enum.
    /// </summary>
    public class VoiceTypeConverter : JsonConverter<VoiceType>
    {
        public override VoiceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "Telnyx.LibriTTS.0" => VoiceType.TelnyxLibriTTS,
                "AWS.Polly" => VoiceType.AWSPolly,
                "ElevenLabs" => VoiceType.ElevenLabs,
                _ => throw new JsonException($"Value '{value}' is not supported for VoiceType enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, VoiceType value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                VoiceType.TelnyxLibriTTS => "Telnyx.LibriTTS.0",
                VoiceType.AWSPolly => "AWS.Polly",
                VoiceType.ElevenLabs => "ElevenLabs",
                _ => throw new JsonException($"Value '{value}' is not supported for VoiceType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
