using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="JobStatusType"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class JobStatusTypeConverter : JsonConverter<JobStatusType>
    {
        public override JobStatusType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "pending" => JobStatusType.Pending,
                "in_progress" => JobStatusType.InProgress,
                "completed" => JobStatusType.Completed,
                "failed" => JobStatusType.Failed,
                _ => throw new JsonException($"Value '{value}' is not supported for JobStatusType enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, JobStatusType value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                JobStatusType.Pending => "pending",
                JobStatusType.InProgress => "in_progress",
                JobStatusType.Completed => "completed",
                JobStatusType.Failed => "failed",
                _ => throw new JsonException($"Value '{value}' is not supported for JobStatusType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
