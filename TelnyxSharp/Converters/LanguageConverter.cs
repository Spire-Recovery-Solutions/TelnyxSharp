using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Converters
{
    /// <summary>
    /// A custom JSON converter for the <see cref="Language"/> enum.
    /// This converter handles the serialization and deserialization of enum values to and from their string representations.
    /// </summary>
    public class LanguageConverter : JsonConverter<Language>
    {
        public override Language Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value switch
            {
                "arb" => Language.ARB,
                "cmn-CN" => Language.CmnCN,
                "cy-GB" => Language.CyGB,
                "da-DK" => Language.DaDK,
                "de-DE" => Language.DeDE,
                "en-AU" => Language.EnAU,
                "en-GB" => Language.EnGB,
                "en-GB-WLS" => Language.EnGBWLS,
                "en-IN" => Language.EnIN,
                "en-US" => Language.EnUS,
                "es-ES" => Language.EsES,
                "es-MX" => Language.EsMX,
                "es-US" => Language.EsUS,
                "fr-CA" => Language.FrCA,
                "fr-FR" => Language.FrFR,
                "hi-IN" => Language.HiIN,
                "is-IS" => Language.IsIS,
                "it-IT" => Language.ItIT,
                "ja-JP" => Language.JaJP,
                "ko-KR" => Language.KoKR,
                "nb-NO" => Language.NbNO,
                "nl-NL" => Language.NlNL,
                "pl-PL" => Language.PlPL,
                "pt-BR" => Language.PtBR,
                "pt-PT" => Language.PtPT,
                "ro-RO" => Language.RoRO,
                "ru-RU" => Language.RuRU,
                "sv-SE" => Language.SvSE,
                "tr-TR" => Language.TrTR,
                _ => throw new System.Text.Json.JsonException($"Value '{value}' is not supported for Language enum")
            };
        }

        public override void Write(System.Text.Json.Utf8JsonWriter writer, Language value, System.Text.Json.JsonSerializerOptions options)
        {
            var stringValue = value switch
            {
                Language.ARB => "arb",
                Language.CmnCN => "cmn-CN",
                Language.CyGB => "cy-GB",
                Language.DaDK => "da-DK",
                Language.DeDE => "de-DE",
                Language.EnAU => "en-AU",
                Language.EnGB => "en-GB",
                Language.EnGBWLS => "en-GB-WLS",
                Language.EnIN => "en-IN",
                Language.EnUS => "en-US",
                Language.EsES => "es-ES",
                Language.EsMX => "es-MX",
                Language.EsUS => "es-US",
                Language.FrCA => "fr-CA",
                Language.FrFR => "fr-FR",
                Language.HiIN => "hi-IN",
                Language.IsIS => "is-IS",
                Language.ItIT => "it-IT",
                Language.JaJP => "ja-JP",
                Language.KoKR => "ko-KR",
                Language.NbNO => "nb-NO",
                Language.NlNL => "nl-NL",
                Language.PlPL => "pl-PL",
                Language.PtBR => "pt-BR",
                Language.PtPT => "pt-PT",
                Language.RoRO => "ro-RO",
                Language.RuRU => "ru-RU",
                Language.SvSE => "sv-SE",
                Language.TrTR => "tr-TR",
                _ => throw new System.Text.Json.JsonException($"Value '{value}' is not supported for Language enum")
            };

            writer.WriteStringValue(stringValue);
        }
    }
}
