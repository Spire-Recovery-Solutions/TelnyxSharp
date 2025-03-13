using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="RequirementStatus"/> enum.
    /// This converter handles serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class RequirementStatusConverter : JsonConverter<RequirementStatus>
    {
        public override RequirementStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "approved" => RequirementStatus.Approved,
                "unapproved" => RequirementStatus.Unapproved,
                "pending-approval" => RequirementStatus.PendingApproval,
                "declined" => RequirementStatus.Declined,
                _ => throw new JsonException($"Value '{value}' is not supported for RequirementStatus enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, RequirementStatus value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                RequirementStatus.Approved => "approved",
                RequirementStatus.Unapproved => "unapproved",
                RequirementStatus.PendingApproval => "pending-approval",
                RequirementStatus.Declined => "declined",
                _ => throw new JsonException($"Value '{value}' is not supported for RequirementStatus enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
