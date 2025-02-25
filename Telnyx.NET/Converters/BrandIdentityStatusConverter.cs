using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="BrandIdentityStatus"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from string representations.
    /// </summary>
    public class BrandIdentityStatusConverter : JsonConverter<BrandIdentityStatus>
    {
        /// <summary>
        /// Reads and deserializes a JSON string into a <see cref="BrandIdentityStatus"/> enum value.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (always <see cref="BrandIdentityStatus"/>).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A corresponding <see cref="BrandIdentityStatus"/> enum value.</returns>
        /// <exception cref="JsonException">Thrown when the JSON value is not recognized.</exception>
        public override BrandIdentityStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "VERIFIED" => BrandIdentityStatus.Verified,
                "UNVERIFIED" => BrandIdentityStatus.Unverified,
                "SELF_DECLARED" => BrandIdentityStatus.SelfDeclared,
                "VETTED_VERIFIED" => BrandIdentityStatus.VettedVerified,
                _ => throw new JsonException($"Value '{value}' is not supported for BrandIdentityStatus enum")
            };
        }

        /// <summary>
        /// Serializes a <see cref="BrandIdentityStatus"/> enum value into its corresponding string representation.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="BrandIdentityStatus"/> enum value to serialize.</param>
        /// <param name="options">Serialization options.</param>
        /// <exception cref="JsonException">Thrown when an unsupported enum value is encountered.</exception>
        public override void Write(Utf8JsonWriter writer, BrandIdentityStatus value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                BrandIdentityStatus.Verified => "VERIFIED",
                BrandIdentityStatus.Unverified => "UNVERIFIED",
                BrandIdentityStatus.SelfDeclared => "SELF_DECLARED",
                BrandIdentityStatus.VettedVerified => "VETTED_VERIFIED",
                _ => throw new JsonException($"Value '{value}' is not supported for BrandIdentityStatus enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}
