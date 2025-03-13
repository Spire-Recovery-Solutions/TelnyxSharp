using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="SortNumberConfiguration"/> enum.
    /// This converter handles serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class SortNumberConfigurationConverter : JsonConverter<SortNumberConfiguration>
    {
        public override SortNumberConfiguration Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "purchased_at" => SortNumberConfiguration.PurchasedAt,
                "phone_number" => SortNumberConfiguration.PhoneNumber,
                "connection_name" => SortNumberConfiguration.ConnectionName,
                "usage_payment_method" => SortNumberConfiguration.UsagePaymentMethod,
                _ => throw new JsonException($"Value '{value}' is not supported for SortNumberConfiguration enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, SortNumberConfiguration value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                SortNumberConfiguration.PurchasedAt => "purchased_at",
                SortNumberConfiguration.PhoneNumber => "phone_number",
                SortNumberConfiguration.ConnectionName => "connection_name",
                SortNumberConfiguration.UsagePaymentMethod => "usage_payment_method",
                _ => throw new JsonException($"Value '{value}' is not supported for SortNumberConfiguration enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
