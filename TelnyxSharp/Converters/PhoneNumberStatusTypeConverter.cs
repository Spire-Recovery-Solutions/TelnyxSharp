using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="PhoneNumberStatusType"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class PhoneNumberStatusTypeConverter : JsonConverter<PhoneNumberStatusType>
    {
        public override PhoneNumberStatusType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "purchase_pending" => PhoneNumberStatusType.PurchasePending,
                "purchase_failed" => PhoneNumberStatusType.PurchaseFailed,
                "port_pending" => PhoneNumberStatusType.PortPending,
                "active" => PhoneNumberStatusType.Active,
                "deleted" => PhoneNumberStatusType.Deleted,
                "port_failed" => PhoneNumberStatusType.PortFailed,
                "emergency_only" => PhoneNumberStatusType.EmergencyOnly,
                "ported_out" => PhoneNumberStatusType.PortedOut,
                "port_out_pending" => PhoneNumberStatusType.PortOutPending,
                _ => throw new JsonException($"Value '{value}' is not supported for PhoneNumberStatusType enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, PhoneNumberStatusType value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                PhoneNumberStatusType.PurchasePending => "purchase_pending",
                PhoneNumberStatusType.PurchaseFailed => "purchase_failed",
                PhoneNumberStatusType.PortPending => "port_pending",
                PhoneNumberStatusType.Active => "active",
                PhoneNumberStatusType.Deleted => "deleted",
                PhoneNumberStatusType.PortFailed => "port_failed",
                PhoneNumberStatusType.EmergencyOnly => "emergency_only",
                PhoneNumberStatusType.PortedOut => "ported_out",
                PhoneNumberStatusType.PortOutPending => "port_out_pending",
                _ => throw new JsonException($"Value '{value}' is not supported for PhoneNumberStatusType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
