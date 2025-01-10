using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Supported languages for Telnyx transcription.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TelnyxLanguage
    {
        /// <summary> English language. </summary>
        [JsonPropertyName("en")] English,

        /// <summary> Chinese language. </summary>
        [JsonPropertyName("zh")] Chinese,

        /// <summary> German language. </summary>
        [JsonPropertyName("de")] German,

        /// <summary> Spanish language. </summary>
        [JsonPropertyName("es")] Spanish,

        /// <summary> Russian language. </summary>
        [JsonPropertyName("ru")] Russian,

        /// <summary> Korean language. </summary>
        [JsonPropertyName("ko")] Korean,

        /// <summary> French language. </summary>
        [JsonPropertyName("fr")] French,

        /// <summary> Japanese language. </summary>
        [JsonPropertyName("ja")] Japanese,

        /// <summary> Portuguese language. </summary>
        [JsonPropertyName("pt")] Portuguese,

        /// <summary> Turkish language. </summary>
        [JsonPropertyName("tr")] Turkish,

        /// <summary> Polish language. </summary>
        [JsonPropertyName("pl")] Polish,

        /// <summary> Catalan language. </summary>
        [JsonPropertyName("ca")] Catalan,

        /// <summary> Dutch language. </summary>
        [JsonPropertyName("nl")] Dutch,

        /// <summary> Arabic language. </summary>
        [JsonPropertyName("ar")] Arabic,

        /// <summary> Swedish language. </summary>
        [JsonPropertyName("sv")] Swedish,

        /// <summary> Italian language. </summary>
        [JsonPropertyName("it")] Italian,

        /// <summary> Indonesian language. </summary>
        [JsonPropertyName("id")] Indonesian,

        /// <summary> Hindi language. </summary>
        [JsonPropertyName("hi")] Hindi,

        /// <summary> Finnish language. </summary>
        [JsonPropertyName("fi")] Finnish,

        /// <summary> Vietnamese language. </summary>
        [JsonPropertyName("vi")] Vietnamese,

        /// <summary> Hebrew language. </summary>
        [JsonPropertyName("he")] Hebrew,

        /// <summary> Ukrainian language. </summary>
        [JsonPropertyName("uk")] Ukrainian,

        /// <summary> Greek language. </summary>
        [JsonPropertyName("el")] Greek,

        /// <summary> Malay language. </summary>
        [JsonPropertyName("ms")] Malay,

        /// <summary> Czech language. </summary>
        [JsonPropertyName("cs")] Czech,

        /// <summary> Romanian language. </summary>
        [JsonPropertyName("ro")] Romanian,

        /// <summary> Danish language. </summary>
        [JsonPropertyName("da")] Danish,

        /// <summary> Hungarian language. </summary>
        [JsonPropertyName("hu")] Hungarian,

        /// <summary> Tamil language. </summary>
        [JsonPropertyName("ta")] Tamil,

        /// <summary> Norwegian language. </summary>
        [JsonPropertyName("no")] Norwegian,

        /// <summary> Thai language. </summary>
        [JsonPropertyName("th")] Thai,

        /// <summary> Urdu language. </summary>
        [JsonPropertyName("ur")] Urdu,

        /// <summary> Croatian language. </summary>
        [JsonPropertyName("hr")] Croatian,

        /// <summary> Bulgarian language. </summary>
        [JsonPropertyName("bg")] Bulgarian,

        /// <summary> Lithuanian language. </summary>
        [JsonPropertyName("lt")] Lithuanian,

        /// <summary> Latin language. </summary>
        [JsonPropertyName("la")] Latin,

        /// <summary> Maori language. </summary>
        [JsonPropertyName("mi")] Maori,

        /// <summary> Malayalam language. </summary>
        [JsonPropertyName("ml")] Malayalam,

        /// <summary> Welsh language. </summary>
        [JsonPropertyName("cy")] Welsh,

        /// <summary> Slovak language. </summary>
        [JsonPropertyName("sk")] Slovak,

        /// <summary> Telugu language. </summary>
        [JsonPropertyName("te")] Telugu,

        /// <summary> Persian language. </summary>
        [JsonPropertyName("fa")] Persian,

        /// <summary> Latvian language. </summary>
        [JsonPropertyName("lv")] Latvian,

        /// <summary> Bengali language. </summary>
        [JsonPropertyName("bn")] Bengali,

        /// <summary> Serbian language. </summary>
        [JsonPropertyName("sr")] Serbian,

        /// <summary> Azerbaijani language. </summary>
        [JsonPropertyName("az")] Azerbaijani,

        /// <summary> Slovenian language. </summary>
        [JsonPropertyName("sl")] Slovenian,

        /// <summary> Kannada language. </summary>
        [JsonPropertyName("kn")] Kannada,

        /// <summary> Estonian language. </summary>
        [JsonPropertyName("et")] Estonian,

        /// <summary> Macedonian language. </summary>
        [JsonPropertyName("mk")] Macedonian,

        /// <summary> Breton language. </summary>
        [JsonPropertyName("br")] Breton,

        /// <summary> Basque language. </summary>
        [JsonPropertyName("eu")] Basque,

        /// <summary> Icelandic language. </summary>
        [JsonPropertyName("is")] Icelandic,

        /// <summary> Armenian language. </summary>
        [JsonPropertyName("hy")] Armenian,

        /// <summary> Nepali language. </summary>
        [JsonPropertyName("ne")] Nepali,

        /// <summary> Mongolian language. </summary>
        [JsonPropertyName("mn")] Mongolian,

        /// <summary> Bosnian language. </summary>
        [JsonPropertyName("bs")] Bosnian,

        /// <summary> Kazakh language. </summary>
        [JsonPropertyName("kk")] Kazakh,

        /// <summary> Albanian language. </summary>
        [JsonPropertyName("sq")] Albanian,

        /// <summary> Swahili language. </summary>
        [JsonPropertyName("sw")] Swahili,

        /// <summary> Galician language. </summary>
        [JsonPropertyName("gl")] Galician,

        /// <summary> Marathi language. </summary>
        [JsonPropertyName("mr")] Marathi,

        /// <summary> Punjabi language. </summary>
        [JsonPropertyName("pa")] Punjabi,

        /// <summary> Sinhala language. </summary>
        [JsonPropertyName("si")] Sinhala,

        /// <summary> Khmer language. </summary>
        [JsonPropertyName("km")] Khmer,

        /// <summary> Shona language. </summary>
        [JsonPropertyName("sn")] Shona,

        /// <summary> Yoruba language. </summary>
        [JsonPropertyName("yo")] Yoruba,

        /// <summary> Somali language. </summary>
        [JsonPropertyName("so")] Somali,

        /// <summary> Afrikaans language. </summary>
        [JsonPropertyName("af")] Afrikaans,

        /// <summary> Occitan language. </summary>
        [JsonPropertyName("oc")] Occitan,

        /// <summary> Georgian language. </summary>
        [JsonPropertyName("ka")] Georgian,

        /// <summary> Belarusian language. </summary>
        [JsonPropertyName("be")] Belarusian,

        /// <summary> Tajik language. </summary>
        [JsonPropertyName("tg")] Tajik,

        /// <summary> Sindhi language. </summary>
        [JsonPropertyName("sd")] Sindhi,

        /// <summary> Gujarati language. </summary>
        [JsonPropertyName("gu")] Gujarati,

        /// <summary> Amharic language. </summary>
        [JsonPropertyName("am")] Amharic,

        /// <summary> Yiddish language. </summary>
        [JsonPropertyName("yi")] Yiddish,

        /// <summary> Lao language. </summary>
        [JsonPropertyName("lo")] Lao,

        /// <summary> Uzbek language. </summary>
        [JsonPropertyName("uz")] Uzbek,

        /// <summary> Faroese language. </summary>
        [JsonPropertyName("fo")] Faroese,

        /// <summary> Haitian Creole language. </summary>
        [JsonPropertyName("ht")] HaitianCreole,

        /// <summary> Pashto language. </summary>
        [JsonPropertyName("ps")] Pashto,

        /// <summary> Turkmen language. </summary>
        [JsonPropertyName("tk")] Turkmen,

        /// <summary> Norwegian Nynorsk language. </summary>
        [JsonPropertyName("nn")] NorwegianNynorsk,

        /// <summary> Maltese language. </summary>
        [JsonPropertyName("mt")] Maltese,

        /// <summary> Sanskrit language. </summary>
        [JsonPropertyName("sa")] Sanskrit,

        /// <summary> Luxembourgish language. </summary>
        [JsonPropertyName("lb")] Luxembourgish,

        /// <summary> Burmese language. </summary>
        [JsonPropertyName("my")] Burmese,

        /// <summary> Tibetan language. </summary>
        [JsonPropertyName("bo")] Tibetan,

        /// <summary> Tagalog language. </summary>
        [JsonPropertyName("tl")] Tagalog,

        /// <summary> Malagasy language. </summary>
        [JsonPropertyName("mg")] Malagasy,

        /// <summary> Assamese language. </summary>
        [JsonPropertyName("as")] Assamese,

        /// <summary> Tatar language. </summary>
        [JsonPropertyName("tt")] Tatar,

        /// <summary> Hawaiian language. </summary>
        [JsonPropertyName("haw")] Hawaiian,

        /// <summary> Lingala language. </summary>
        [JsonPropertyName("ln")] Lingala,

        /// <summary> Hausa language. </summary>
        [JsonPropertyName("ha")] Hausa,

        /// <summary> Bashkir language. </summary>
        [JsonPropertyName("ba")] Bashkir,

        /// <summary> Javanese language. </summary>
        [JsonPropertyName("jw")] Javanese,

        /// <summary> Sundanese language. </summary>
        [JsonPropertyName("su")] Sundanese,

        /// <summary> Language auto detection. </summary>
        [JsonPropertyName("auto_detect")] AutoDetect
    }
}