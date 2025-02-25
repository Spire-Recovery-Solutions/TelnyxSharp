using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="TelnyxLanguage"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their JSON string representations.
    /// </summary>
    public class TelnyxLanguageConverter : JsonConverter<TelnyxLanguage>
    {
        public override TelnyxLanguage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();
            return value switch
            {
                "en" => TelnyxLanguage.English,
                "zh" => TelnyxLanguage.Chinese,
                "de" => TelnyxLanguage.German,
                "es" => TelnyxLanguage.Spanish,
                "ru" => TelnyxLanguage.Russian,
                "ko" => TelnyxLanguage.Korean,
                "fr" => TelnyxLanguage.French,
                "ja" => TelnyxLanguage.Japanese,
                "pt" => TelnyxLanguage.Portuguese,
                "tr" => TelnyxLanguage.Turkish,
                "pl" => TelnyxLanguage.Polish,
                "ca" => TelnyxLanguage.Catalan,
                "nl" => TelnyxLanguage.Dutch,
                "ar" => TelnyxLanguage.Arabic,
                "sv" => TelnyxLanguage.Swedish,
                "it" => TelnyxLanguage.Italian,
                "id" => TelnyxLanguage.Indonesian,
                "hi" => TelnyxLanguage.Hindi,
                "fi" => TelnyxLanguage.Finnish,
                "vi" => TelnyxLanguage.Vietnamese,
                "he" => TelnyxLanguage.Hebrew,
                "uk" => TelnyxLanguage.Ukrainian,
                "el" => TelnyxLanguage.Greek,
                "ms" => TelnyxLanguage.Malay,
                "cs" => TelnyxLanguage.Czech,
                "ro" => TelnyxLanguage.Romanian,
                "da" => TelnyxLanguage.Danish,
                "hu" => TelnyxLanguage.Hungarian,
                "ta" => TelnyxLanguage.Tamil,
                "no" => TelnyxLanguage.Norwegian,
                "th" => TelnyxLanguage.Thai,
                "ur" => TelnyxLanguage.Urdu,
                "hr" => TelnyxLanguage.Croatian,
                "bg" => TelnyxLanguage.Bulgarian,
                "lt" => TelnyxLanguage.Lithuanian,
                "la" => TelnyxLanguage.Latin,
                "mi" => TelnyxLanguage.Maori,
                "ml" => TelnyxLanguage.Malayalam,
                "cy" => TelnyxLanguage.Welsh,
                "sk" => TelnyxLanguage.Slovak,
                "te" => TelnyxLanguage.Telugu,
                "fa" => TelnyxLanguage.Persian,
                "lv" => TelnyxLanguage.Latvian,
                "bn" => TelnyxLanguage.Bengali,
                "sr" => TelnyxLanguage.Serbian,
                "az" => TelnyxLanguage.Azerbaijani,
                "sl" => TelnyxLanguage.Slovenian,
                "kn" => TelnyxLanguage.Kannada,
                "et" => TelnyxLanguage.Estonian,
                "mk" => TelnyxLanguage.Macedonian,
                "br" => TelnyxLanguage.Breton,
                "eu" => TelnyxLanguage.Basque,
                "is" => TelnyxLanguage.Icelandic,
                "hy" => TelnyxLanguage.Armenian,
                "ne" => TelnyxLanguage.Nepali,
                "mn" => TelnyxLanguage.Mongolian,
                "bs" => TelnyxLanguage.Bosnian,
                "kk" => TelnyxLanguage.Kazakh,
                "sq" => TelnyxLanguage.Albanian,
                "sw" => TelnyxLanguage.Swahili,
                "gl" => TelnyxLanguage.Galician,
                "mr" => TelnyxLanguage.Marathi,
                "pa" => TelnyxLanguage.Punjabi,
                "si" => TelnyxLanguage.Sinhala,
                "km" => TelnyxLanguage.Khmer,
                _ => throw new JsonException($"Value '{value}' is not supported for TelnyxLanguage enum")
            };
        }

        public override void Write(Utf8JsonWriter writer, TelnyxLanguage value, JsonSerializerOptions options)
        {
            string stringValue = value switch
            {
                TelnyxLanguage.English          => "en",
                TelnyxLanguage.Chinese          => "zh",
                TelnyxLanguage.German           => "de",
                TelnyxLanguage.Spanish          => "es",
                TelnyxLanguage.Russian          => "ru",
                TelnyxLanguage.Korean           => "ko",
                TelnyxLanguage.French           => "fr",
                TelnyxLanguage.Japanese         => "ja",
                TelnyxLanguage.Portuguese       => "pt",
                TelnyxLanguage.Turkish          => "tr",
                TelnyxLanguage.Polish           => "pl",
                TelnyxLanguage.Catalan          => "ca",
                TelnyxLanguage.Dutch            => "nl",
                TelnyxLanguage.Arabic           => "ar",
                TelnyxLanguage.Swedish          => "sv",
                TelnyxLanguage.Italian          => "it",
                TelnyxLanguage.Indonesian       => "id",
                TelnyxLanguage.Hindi            => "hi",
                TelnyxLanguage.Finnish          => "fi",
                TelnyxLanguage.Vietnamese       => "vi",
                TelnyxLanguage.Hebrew           => "he",
                TelnyxLanguage.Ukrainian        => "uk",
                TelnyxLanguage.Greek            => "el",
                TelnyxLanguage.Malay            => "ms",
                TelnyxLanguage.Czech            => "cs",
                TelnyxLanguage.Romanian         => "ro",
                TelnyxLanguage.Danish           => "da",
                TelnyxLanguage.Hungarian        => "hu",
                TelnyxLanguage.Tamil            => "ta",
                TelnyxLanguage.Norwegian        => "no",
                TelnyxLanguage.Thai             => "th",
                TelnyxLanguage.Urdu             => "ur",
                TelnyxLanguage.Croatian         => "hr",
                TelnyxLanguage.Bulgarian        => "bg",
                TelnyxLanguage.Lithuanian       => "lt",
                TelnyxLanguage.Latin            => "la",
                TelnyxLanguage.Maori            => "mi",
                TelnyxLanguage.Malayalam        => "ml",
                TelnyxLanguage.Welsh            => "cy",
                TelnyxLanguage.Slovak           => "sk",
                TelnyxLanguage.Telugu           => "te",
                TelnyxLanguage.Persian          => "fa",
                TelnyxLanguage.Latvian          => "lv",
                TelnyxLanguage.Bengali          => "bn",
                TelnyxLanguage.Serbian          => "sr",
                TelnyxLanguage.Azerbaijani      => "az",
                TelnyxLanguage.Slovenian        => "sl",
                TelnyxLanguage.Kannada          => "kn",
                TelnyxLanguage.Estonian         => "et",
                TelnyxLanguage.Macedonian       => "mk",
                TelnyxLanguage.Breton           => "br",
                TelnyxLanguage.Basque           => "eu",
                TelnyxLanguage.Icelandic        => "is",
                TelnyxLanguage.Armenian         => "hy",
                TelnyxLanguage.Nepali           => "ne",
                TelnyxLanguage.Mongolian        => "mn",
                TelnyxLanguage.Bosnian          => "bs",
                TelnyxLanguage.Kazakh           => "kk",
                TelnyxLanguage.Albanian         => "sq",
                TelnyxLanguage.Swahili          => "sw",
                TelnyxLanguage.Galician         => "gl",
                TelnyxLanguage.Marathi          => "mr",
                TelnyxLanguage.Punjabi          => "pa",
                TelnyxLanguage.Sinhala          => "si",
                TelnyxLanguage.Khmer            => "km",
                _ => throw new JsonException($"Value '{value}' is not supported for TelnyxLanguage enum")
            };
            writer.WriteStringValue(stringValue);
        }
    }
}
