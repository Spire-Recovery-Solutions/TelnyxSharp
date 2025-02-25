using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="RequirementSort"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class RequirementSortConverter : JsonConverter<RequirementSort>
    {
        public override RequirementSort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "action" => RequirementSort.Action,
                "country_code" => RequirementSort.CountryCode,
                "locality" => RequirementSort.Locality,
                "phone_number_type" => RequirementSort.PhoneNumberType,
                _ => throw new JsonException($"Value '{value}' is not supported for RequirementSort enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, RequirementSort value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                RequirementSort.Action => "action",
                RequirementSort.CountryCode => "country_code",
                RequirementSort.Locality => "locality",
                RequirementSort.PhoneNumberType => "phone_number_type",
                _ => throw new JsonException($"Value '{value}' is not supported for RequirementSort enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
