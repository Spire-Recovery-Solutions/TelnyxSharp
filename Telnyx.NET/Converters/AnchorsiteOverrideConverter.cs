using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    public class AnchorsiteOverrideConverter : JsonConverter<AnchorsiteOverride>
    {
        public override AnchorsiteOverride Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "Latency" => AnchorsiteOverride.Latency,
                "Chicago, IL" => AnchorsiteOverride.Chicago,
                "Ashburn, VA" => AnchorsiteOverride.Ashburn,
                "San Jose, CA" => AnchorsiteOverride.SanJose,
                _ => throw new JsonException($"Value '{value}' is not supported for AnchorsiteOverride enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, AnchorsiteOverride value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                AnchorsiteOverride.Latency => "Latency",
                AnchorsiteOverride.Chicago => "Chicago, IL",
                AnchorsiteOverride.Ashburn => "Ashburn, VA",
                AnchorsiteOverride.SanJose => "San Jose, CA",
                _ => throw new JsonException($"Value '{value}' is not supported for AnchorsiteOverride enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}
