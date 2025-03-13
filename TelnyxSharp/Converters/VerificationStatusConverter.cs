using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="VerificationStatus"/> enum.
    /// </summary>
    public class VerificationStatusConverter : JsonConverter<VerificationStatus>
    {
        public override VerificationStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "Verified" => VerificationStatus.Verified,
                "Rejected" => VerificationStatus.Rejected,
                "Waiting For Vendor" => VerificationStatus.WaitingForVendor,
                "Waiting For Customer" => VerificationStatus.WaitingForCustomer,
                "In Progress" => VerificationStatus.InProgress,
                "Unknown" => VerificationStatus.Unknown,
                _ => throw new JsonException($"Value '{value}' is not supported for VerificationStatus enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, VerificationStatus value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                VerificationStatus.Verified => "Verified",
                VerificationStatus.Rejected => "Rejected",
                VerificationStatus.WaitingForVendor => "Waiting For Vendor",
                VerificationStatus.WaitingForCustomer => "Waiting For Customer",
                VerificationStatus.InProgress => "In Progress",
                VerificationStatus.Unknown => "Unknown",
                _ => throw new JsonException($"Value '{value}' is not supported for VerificationStatus enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
