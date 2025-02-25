using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="CountryCode"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class CountryCodeConverter : JsonConverter<CountryCode>
    {
        /// <summary>
        /// Reads and deserializes a JSON string into a <see cref="CountryCode"/> enum value.
        /// </summary>
        /// <param name="reader">The UTF-8 JSON reader.</param>
        /// <param name="typeToConvert">The type to convert (always <see cref="CountryCode"/>).</param>
        /// <param name="options">Serialization options.</param>
        /// <returns>A corresponding <see cref="CountryCode"/> enum value.</returns>
        /// <exception cref="JsonException">Thrown when the JSON value is not recognized.</exception>
        public override CountryCode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "AT" => CountryCode.Austria,
                "AU" => CountryCode.Australia,
                "BE" => CountryCode.Belgium,
                "BG" => CountryCode.Bulgaria,
                "CA" => CountryCode.Canada,
                "CH" => CountryCode.Switzerland,
                "CN" => CountryCode.China,
                "CY" => CountryCode.Cyprus,
                "CZ" => CountryCode.CzechRepublic,
                "DE" => CountryCode.Germany,
                "DK" => CountryCode.Denmark,
                "EE" => CountryCode.Estonia,
                "ES" => CountryCode.Spain,
                "FI" => CountryCode.Finland,
                "FR" => CountryCode.France,
                "GB" => CountryCode.UnitedKingdom,
                "GR" => CountryCode.Greece,
                "HU" => CountryCode.Hungary,
                "HR" => CountryCode.Croatia,
                "IE" => CountryCode.Ireland,
                "IT" => CountryCode.Italy,
                "LT" => CountryCode.Lithuania,
                "LU" => CountryCode.Luxembourg,
                "LV" => CountryCode.Latvia,
                "NL" => CountryCode.Netherlands,
                "NZ" => CountryCode.NewZealand,
                "MX" => CountryCode.Mexico,
                "NO" => CountryCode.Norway,
                "PL" => CountryCode.Poland,
                "PT" => CountryCode.Portugal,
                "RO" => CountryCode.Romania,
                "SE" => CountryCode.Sweden,
                "SG" => CountryCode.Singapore,
                "SI" => CountryCode.Slovenia,
                "SK" => CountryCode.Slovakia,
                "US" => CountryCode.UnitedStates,
                _ => throw new JsonException($"Value '{value}' is not supported for CountryCode enum")
            };
        }

        /// <summary>
        /// Serializes a <see cref="CountryCode"/> enum value into its corresponding string representation.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="CountryCode"/> enum value to serialize.</param>
        /// <param name="options">Serialization options.</param>
        /// <exception cref="JsonException">Thrown when an unsupported enum value is encountered.</exception>
        public override void Write(Utf8JsonWriter writer, CountryCode value, JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                CountryCode.Austria => "AT",
                CountryCode.Australia => "AU",
                CountryCode.Belgium => "BE",
                CountryCode.Bulgaria => "BG",
                CountryCode.Canada => "CA",
                CountryCode.Switzerland => "CH",
                CountryCode.China => "CN",
                CountryCode.Cyprus => "CY",
                CountryCode.CzechRepublic => "CZ",
                CountryCode.Germany => "DE",
                CountryCode.Denmark => "DK",
                CountryCode.Estonia => "EE",
                CountryCode.Spain => "ES",
                CountryCode.Finland => "FI",
                CountryCode.France => "FR",
                CountryCode.UnitedKingdom => "GB",
                CountryCode.Greece => "GR",
                CountryCode.Hungary => "HU",
                CountryCode.Croatia => "HR",
                CountryCode.Ireland => "IE",
                CountryCode.Italy => "IT",
                CountryCode.Lithuania => "LT",
                CountryCode.Luxembourg => "LU",
                CountryCode.Latvia => "LV",
                CountryCode.Netherlands => "NL",
                CountryCode.NewZealand => "NZ",
                CountryCode.Mexico => "MX",
                CountryCode.Norway => "NO",
                CountryCode.Poland => "PL",
                CountryCode.Portugal => "PT",
                CountryCode.Romania => "RO",
                CountryCode.Sweden => "SE",
                CountryCode.Singapore => "SG",
                CountryCode.Slovenia => "SI",
                CountryCode.Slovakia => "SK",
                CountryCode.UnitedStates => "US",
                _ => throw new JsonException($"Value '{value}' is not supported for CountryCode enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
