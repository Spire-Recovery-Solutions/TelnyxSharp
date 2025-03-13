using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="PhoneNumberFeature"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class PhoneNumberFeatureConverter : JsonConverter<PhoneNumberFeature>
    {
        public override PhoneNumberFeature Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "sms" => PhoneNumberFeature.Sms,
                "mms" => PhoneNumberFeature.Mms,
                "voice" => PhoneNumberFeature.Voice,
                "fax" => PhoneNumberFeature.Fax,
                "emergency" => PhoneNumberFeature.Emergency,
                "hd_voice" => PhoneNumberFeature.HdVoice,
                "international_sms" => PhoneNumberFeature.InternationalSms,
                "local_calling" => PhoneNumberFeature.LocalCalling,
                _ => throw new JsonException($"Value '{value}' is not supported for PhoneNumberFeature enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, PhoneNumberFeature value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                PhoneNumberFeature.Sms => "sms",
                PhoneNumberFeature.Mms => "mms",
                PhoneNumberFeature.Voice => "voice",
                PhoneNumberFeature.Fax => "fax",
                PhoneNumberFeature.Emergency => "emergency",
                PhoneNumberFeature.HdVoice => "hd_voice",
                PhoneNumberFeature.InternationalSms => "international_sms",
                PhoneNumberFeature.LocalCalling => "local_calling",
                _ => throw new JsonException($"Value '{value}' is not supported for PhoneNumberFeature enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
