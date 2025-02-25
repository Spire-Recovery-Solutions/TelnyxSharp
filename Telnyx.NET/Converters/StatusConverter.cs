using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using System.Text.Json;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="Status"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their JSON string representations.
    /// </summary>
    public class StatusConverter : JsonConverter<Status>
    {
        public override Status Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "Unknown" => Status.Unknown,
                "deleted" => Status.Deleted,
                "failed" => Status.Failed,
                "pending" => Status.Pending,
                "successful" => Status.Successful,
                "Verified" => Status.Verified,
                "Rejected" => Status.Rejected,
                "Waiting For Vendor" => Status.WaitingForVendor,
                "Waiting For Customer" => Status.WaitingForCustomer,
                "In Progress" => Status.InProgress,
                _ => throw new JsonException($"Value '{value}' is not supported for Status enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                Status.Unknown => "Unknown",
                Status.Deleted => "deleted",
                Status.Failed => "failed",
                Status.Pending => "pending",
                Status.Successful => "successful",
                Status.Verified => "Verified",
                Status.Rejected => "Rejected",
                Status.WaitingForVendor => "Waiting For Vendor",
                Status.WaitingForCustomer => "Waiting For Customer",
                Status.InProgress => "In Progress",
                _ => throw new JsonException($"Value '{value}' is not supported for Status enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
