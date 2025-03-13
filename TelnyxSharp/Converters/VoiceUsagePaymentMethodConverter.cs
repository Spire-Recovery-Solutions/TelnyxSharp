using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="VoiceUsagePaymentMethod"/> enum.
    /// </summary>
    public class VoiceUsagePaymentMethodConverter : JsonConverter<VoiceUsagePaymentMethod>
    {
        public override VoiceUsagePaymentMethod Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "pay-per-minute" => VoiceUsagePaymentMethod.PayPerMinute,
                "channel" => VoiceUsagePaymentMethod.Channel,
                _ => throw new JsonException($"Value '{value}' is not supported for VoiceUsagePaymentMethod enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, VoiceUsagePaymentMethod value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                VoiceUsagePaymentMethod.PayPerMinute => "pay-per-minute",
                VoiceUsagePaymentMethod.Channel => "channel",
                _ => throw new JsonException($"Value '{value}' is not supported for VoiceUsagePaymentMethod enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
