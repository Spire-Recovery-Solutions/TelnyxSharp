using System.Text.Json;
using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="RingtoneCountry"/> enum.
    /// This converter handles serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class RingtoneCountryConverter : JsonConverter<RingtoneCountry>
    {
        public override RingtoneCountry Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "at" => RingtoneCountry.Austria,
                "au" => RingtoneCountry.Australia,
                "be" => RingtoneCountry.Belgium,
                "bg" => RingtoneCountry.Bulgaria,
                "br" => RingtoneCountry.Brazil,
                "ch" => RingtoneCountry.Switzerland,
                "cl" => RingtoneCountry.Chile,
                "cn" => RingtoneCountry.China,
                "cz" => RingtoneCountry.CzechRepublic,
                "de" => RingtoneCountry.Germany,
                "dk" => RingtoneCountry.Denmark,
                "ee" => RingtoneCountry.Estonia,
                "es" => RingtoneCountry.Spain,
                "fi" => RingtoneCountry.Finland,
                "fr" => RingtoneCountry.France,
                "gr" => RingtoneCountry.Greece,
                "hu" => RingtoneCountry.Hungary,
                "il" => RingtoneCountry.Israel,
                "in" => RingtoneCountry.India,
                "it" => RingtoneCountry.Italy,
                "jp" => RingtoneCountry.Japan,
                "lt" => RingtoneCountry.Lithuania,
                "mx" => RingtoneCountry.Mexico,
                "my" => RingtoneCountry.Malaysia,
                "nl" => RingtoneCountry.Netherlands,
                "no" => RingtoneCountry.Norway,
                "nz" => RingtoneCountry.NewZealand,
                "ph" => RingtoneCountry.Philippines,
                "pl" => RingtoneCountry.Poland,
                "pt" => RingtoneCountry.Portugal,
                "ru" => RingtoneCountry.Russia,
                "se" => RingtoneCountry.Sweden,
                "sg" => RingtoneCountry.Singapore,
                "th" => RingtoneCountry.Thailand,
                "tw" => RingtoneCountry.Taiwan,
                "uk" => RingtoneCountry.UnitedKingdom,
                "us-old" => RingtoneCountry.UnitedStatesLegacy,
                "us" => RingtoneCountry.UnitedStates,
                "ve" => RingtoneCountry.Venezuela,
                "za" => RingtoneCountry.SouthAfrica,
                _ => throw new JsonException($"Value '{value}' is not supported for RingtoneCountry enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, RingtoneCountry value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                RingtoneCountry.Austria => "at",
                RingtoneCountry.Australia => "au",
                RingtoneCountry.Belgium => "be",
                RingtoneCountry.Bulgaria => "bg",
                RingtoneCountry.Brazil => "br",
                RingtoneCountry.Switzerland => "ch",
                RingtoneCountry.Chile => "cl",
                RingtoneCountry.China => "cn",
                RingtoneCountry.CzechRepublic => "cz",
                RingtoneCountry.Germany => "de",
                RingtoneCountry.Denmark => "dk",
                RingtoneCountry.Estonia => "ee",
                RingtoneCountry.Spain => "es",
                RingtoneCountry.Finland => "fi",
                RingtoneCountry.France => "fr",
                RingtoneCountry.Greece => "gr",
                RingtoneCountry.Hungary => "hu",
                RingtoneCountry.Israel => "il",
                RingtoneCountry.India => "in",
                RingtoneCountry.Italy => "it",
                RingtoneCountry.Japan => "jp",
                RingtoneCountry.Lithuania => "lt",
                RingtoneCountry.Mexico => "mx",
                RingtoneCountry.Malaysia => "my",
                RingtoneCountry.Netherlands => "nl",
                RingtoneCountry.Norway => "no",
                RingtoneCountry.NewZealand => "nz",
                RingtoneCountry.Philippines => "ph",
                RingtoneCountry.Poland => "pl",
                RingtoneCountry.Portugal => "pt",
                RingtoneCountry.Russia => "ru",
                RingtoneCountry.Sweden => "se",
                RingtoneCountry.Singapore => "sg",
                RingtoneCountry.Thailand => "th",
                RingtoneCountry.Taiwan => "tw",
                RingtoneCountry.UnitedKingdom => "uk",
                RingtoneCountry.UnitedStatesLegacy => "us-old",
                RingtoneCountry.UnitedStates => "us",
                RingtoneCountry.Venezuela => "ve",
                RingtoneCountry.SouthAfrica => "za",
                _ => throw new JsonException($"Value '{value}' is not supported for RingtoneCountry enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
