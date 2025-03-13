using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="BrandRelationship"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from string representations.
    /// </summary>
    public class BrandRelationshipConverter : JsonConverter<BrandRelationship>
    {
        /// <summary>
        /// Reads and deserializes a JSON string into a <see cref="BrandRelationship"/> enum value.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (always <see cref="BrandRelationship"/>).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A corresponding <see cref="BrandRelationship"/> enum value.</returns>
        /// <exception cref="JsonException">Thrown when the JSON value is not recognized.</exception>
        public override BrandRelationship Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "UNKNOWN" => BrandRelationship.Unknown,
                "BASIC_ACCOUNT" => BrandRelationship.BasicAccount,
                "SMALL_ACCOUNT" => BrandRelationship.SmallAccount,
                "MEDIUM_ACCOUNT" => BrandRelationship.MediumAccount,
                "LARGE_ACCOUNT" => BrandRelationship.LargeAccount,
                "KEY_ACCOUNT" => BrandRelationship.KeyAccount,
                _ => throw new JsonException($"Value '{value}' is not supported for BrandRelationship enum")
            };
        }

        /// <summary>
        /// Serializes a <see cref="BrandRelationship"/> enum value into its corresponding string representation.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="BrandRelationship"/> enum value to serialize.</param>
        /// <param name="options">Serialization options.</param>
        /// <exception cref="JsonException">Thrown when an unsupported enum value is encountered.</exception>
        public override void Write(Utf8JsonWriter writer, BrandRelationship value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                BrandRelationship.Unknown => "UNKNOWN",
                BrandRelationship.BasicAccount => "BASIC_ACCOUNT",
                BrandRelationship.SmallAccount => "SMALL_ACCOUNT",
                BrandRelationship.MediumAccount => "MEDIUM_ACCOUNT",
                BrandRelationship.LargeAccount => "LARGE_ACCOUNT",
                BrandRelationship.KeyAccount => "KEY_ACCOUNT",
                _ => throw new JsonException($"Value '{value}' is not supported for BrandRelationship enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}
