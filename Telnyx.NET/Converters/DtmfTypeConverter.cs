using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="DtmfType"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class DtmfTypeConverter : JsonConverter<DtmfType>
    {
        /// <summary>
        /// Reads and deserializes a JSON string into a <see cref="DtmfType"/> enum value.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (always <see cref="DtmfType"/>).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A corresponding <see cref="DtmfType"/> enum value.</returns>
        /// <exception cref="JsonException">Thrown when the JSON value is not recognized.</exception>
        public override DtmfType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "RFC 2833" => DtmfType.Rfc2833,
                "Inband" => DtmfType.Inband,
                "SIP INFO" => DtmfType.SipInfo,
                _ => throw new JsonException($"Value '{value}' is not supported for DtmfType enum")
            };
        }

        /// <summary>
        /// Serializes a <see cref="DtmfType"/> enum value into its corresponding string representation.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="DtmfType"/> enum value to serialize.</param>
        /// <param name="options">Serialization options.</param>
        /// <exception cref="JsonException">Thrown when an unsupported enum value is encountered.</exception>
        public override void Write(Utf8JsonWriter writer, DtmfType value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                DtmfType.Rfc2833 => "RFC 2833",
                DtmfType.Inband => "Inband",
                DtmfType.SipInfo => "SIP INFO",
                _ => throw new JsonException($"Value '{value}' is not supported for DtmfType enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
