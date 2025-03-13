using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="PhoneNumberJobType"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class PhoneNumberJobTypeConverter : JsonConverter<PhoneNumberJobType>
    {
        public override PhoneNumberJobType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "update_emergency_settings" => PhoneNumberJobType.UpdateEmergencySettings,
                "delete_phone_numbers" => PhoneNumberJobType.DeletePhoneNumbers,
                "update_phone_numbers" => PhoneNumberJobType.UpdatePhoneNumbers,
                _ => throw new JsonException($"Value '{value}' is not supported for PhoneNumberJobType enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, PhoneNumberJobType value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                PhoneNumberJobType.UpdateEmergencySettings => "update_emergency_settings",
                PhoneNumberJobType.DeletePhoneNumbers => "delete_phone_numbers",
                PhoneNumberJobType.UpdatePhoneNumbers => "update_phone_numbers",
                _ => throw new JsonException($"Value '{value}' is not supported for PhoneNumberJobType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
