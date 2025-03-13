using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="MessageVolume"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class MessageVolumeConverter : JsonConverter<MessageVolume>
    {
        public override MessageVolume Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "Unknown" => MessageVolume.Unknown,
                "10" => MessageVolume.Ten,
                "100" => MessageVolume.OneHundred,
                "1,000" => MessageVolume.Thousand,
                "10,000" => MessageVolume.TenThousand,
                "100,000" => MessageVolume.HundredThousand,
                "250,000" => MessageVolume.TwoHundredFiftyThousand,
                "500,000" => MessageVolume.FiveHundredThousand,
                "750,000" => MessageVolume.SevenHundredFiftyThousand,
                "1,000,000" => MessageVolume.OneMillion,
                "5,000,000" => MessageVolume.FiveMillion,
                "10,000,000+" => MessageVolume.TenMillionPlus,
                _ => throw new JsonException($"Value '{value}' is not supported for MessageVolume enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, MessageVolume value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                MessageVolume.Unknown => "Unknown",
                MessageVolume.Ten => "10",
                MessageVolume.OneHundred => "100",
                MessageVolume.Thousand => "1,000",
                MessageVolume.TenThousand => "10,000",
                MessageVolume.HundredThousand => "100,000",
                MessageVolume.TwoHundredFiftyThousand => "250,000",
                MessageVolume.FiveHundredThousand => "500,000",
                MessageVolume.SevenHundredFiftyThousand => "750,000",
                MessageVolume.OneMillion => "1,000,000",
                MessageVolume.FiveMillion => "5,000,000",
                MessageVolume.TenMillionPlus => "10,000,000+",
                _ => throw new JsonException($"Value '{value}' is not supported for MessageVolume enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
