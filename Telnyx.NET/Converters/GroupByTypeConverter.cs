using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="GroupByType"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class GroupByTypeConverter : JsonConverter<GroupByType>
    {
        public override GroupByType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "locality" => GroupByType.Locality,
                "npa" => GroupByType.Npa,
                "national_destination_code" => GroupByType.NationalDestinationCode,
                _ => throw new JsonException($"Value '{value}' is not supported for GroupByType enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, GroupByType value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                GroupByType.Locality => "locality",
                GroupByType.Npa => "npa",
                GroupByType.NationalDestinationCode => "national_destination_code",
                _ => throw new JsonException($"Value '{value}' is not supported for GroupByType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
