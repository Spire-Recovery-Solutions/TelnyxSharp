using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="SipSubdomainReceiveSettings"/> enum.
    /// This converter handles serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class SipSubdomainReceiveSettingsConverter : JsonConverter<SipSubdomainReceiveSettings>
    {
        public override SipSubdomainReceiveSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "only_my_connections" => SipSubdomainReceiveSettings.OnlyMyConnections,
                "from_anyone" => SipSubdomainReceiveSettings.FromAnyone,
                _ => throw new JsonException($"Value '{value}' is not supported for SipSubdomainReceiveSettings enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, SipSubdomainReceiveSettings value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                SipSubdomainReceiveSettings.OnlyMyConnections => "only_my_connections",
                SipSubdomainReceiveSettings.FromAnyone => "from_anyone",
                _ => throw new JsonException($"Value '{value}' is not supported for SipSubdomainReceiveSettings enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
