using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="RequirementTypeSort"/> enum.
    /// This converter handles serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class RequirementTypeSortConverter : JsonConverter<RequirementTypeSort>
    {
        public override RequirementTypeSort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "created_at" => RequirementTypeSort.CreatedAtAsc,
                "-created_at" => RequirementTypeSort.CreatedAtDesc,
                "name" => RequirementTypeSort.NameAsc,
                "-name" => RequirementTypeSort.NameDesc,
                "updated_at" => RequirementTypeSort.UpdatedAtAsc,
                "-updated_at" => RequirementTypeSort.UpdatedAtDesc,
                _ => throw new JsonException($"Value '{value}' is not supported for RequirementTypeSort enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, RequirementTypeSort value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                RequirementTypeSort.CreatedAtAsc => "created_at",
                RequirementTypeSort.CreatedAtDesc => "-created_at",
                RequirementTypeSort.NameAsc => "name",
                RequirementTypeSort.NameDesc => "-name",
                RequirementTypeSort.UpdatedAtAsc => "updated_at",
                RequirementTypeSort.UpdatedAtDesc => "-updated_at",
                _ => throw new JsonException($"Value '{value}' is not supported for RequirementTypeSort enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
