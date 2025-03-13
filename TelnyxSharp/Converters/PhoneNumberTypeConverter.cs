using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="PhoneNumberType"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class PhoneNumberTypeConverter : JsonConverter<PhoneNumberType>
    {
        public override PhoneNumberType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "local" => PhoneNumberType.Local,
                "national" => PhoneNumberType.National,
                "toll_free" => PhoneNumberType.TollFree,
                "mobile" => PhoneNumberType.Mobile,
                "landline" => PhoneNumberType.Landline,
                "voip" => PhoneNumberType.VoIP,
                "shared_cost" => PhoneNumberType.SharedCost,
                _ => throw new JsonException($"Value '{value}' is not supported for PhoneNumberType enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, PhoneNumberType value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                PhoneNumberType.Local => "local",
                PhoneNumberType.National => "national",
                PhoneNumberType.TollFree => "toll_free",
                PhoneNumberType.Mobile => "mobile",
                PhoneNumberType.Landline => "landline",
                PhoneNumberType.VoIP => "voip",
                PhoneNumberType.SharedCost => "shared_cost",
                _ => throw new JsonException($"Value '{value}' is not supported for PhoneNumberType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
