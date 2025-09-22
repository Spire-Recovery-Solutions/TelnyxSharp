using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Supported languages for Telnyx transcription.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<TelnyxLanguage>))]
    public enum TelnyxLanguage
    {
        /// <summary> English language. </summary>
        [JsonStringEnumMemberName("en")]
        English,

        /// <summary> Chinese language. </summary>
        [JsonStringEnumMemberName("zh")]
        Chinese,

        /// <summary> German language. </summary>
        [JsonStringEnumMemberName("de")]
        German,

        /// <summary> Spanish language. </summary>
        [JsonStringEnumMemberName("es")]
        Spanish,

        /// <summary> Russian language. </summary>
        [JsonStringEnumMemberName("ru")]
        Russian,

        /// <summary> Korean language. </summary>
        [JsonStringEnumMemberName("ko")]
        Korean,

        /// <summary> French language. </summary>
        [JsonStringEnumMemberName("fr")]
        French,

        /// <summary> Japanese language. </summary>
        [JsonStringEnumMemberName("ja")]
        Japanese,

        /// <summary> Portuguese language. </summary>
        [JsonStringEnumMemberName("pt")]
        Portuguese,

        /// <summary> Turkish language. </summary>
        [JsonStringEnumMemberName("tr")]
        Turkish,

        /// <summary> Polish language. </summary>
        [JsonStringEnumMemberName("pl")]
        Polish,

        /// <summary> Catalan language. </summary>
        [JsonStringEnumMemberName("ca")]
        Catalan,

        /// <summary> Dutch language. </summary>
        [JsonStringEnumMemberName("nl")]
        Dutch,

        /// <summary> Arabic language. </summary>
        [JsonStringEnumMemberName("ar")]
        Arabic,

        /// <summary> Swedish language. </summary>
        [JsonStringEnumMemberName("sv")]
        Swedish,

        /// <summary> Italian language. </summary>
        [JsonStringEnumMemberName("it")]
        Italian,

        /// <summary> Indonesian language. </summary>
        [JsonStringEnumMemberName("id")]
        Indonesian,

        /// <summary> Hindi language. </summary>
        [JsonStringEnumMemberName("hi")]
        Hindi,

        /// <summary> Finnish language. </summary>
        [JsonStringEnumMemberName("fi")]
        Finnish,

        /// <summary> Vietnamese language. </summary>
        [JsonStringEnumMemberName("vi")]
        Vietnamese,

        /// <summary> Hebrew language. </summary>
        [JsonStringEnumMemberName("he")]
        Hebrew,

        /// <summary> Ukrainian language. </summary>
        [JsonStringEnumMemberName("uk")]
        Ukrainian,

        /// <summary> Greek language. </summary>
        [JsonStringEnumMemberName("el")]
        Greek,

        /// <summary> Malay language. </summary>
        [JsonStringEnumMemberName("ms")]
        Malay,

        /// <summary> Czech language. </summary>
        [JsonStringEnumMemberName("cs")]
        Czech,

        /// <summary> Romanian language. </summary>
        [JsonStringEnumMemberName("ro")]
        Romanian,

        /// <summary> Danish language. </summary>
        [JsonStringEnumMemberName("da")]
        Danish,

        /// <summary> Hungarian language. </summary>
        [JsonStringEnumMemberName("hu")]
        Hungarian,

        /// <summary> Tamil language. </summary>
        [JsonStringEnumMemberName("ta")]
        Tamil,

        /// <summary> Norwegian language. </summary>
        [JsonStringEnumMemberName("no")]
        Norwegian,

        /// <summary> Thai language. </summary>
        [JsonStringEnumMemberName("th")]
        Thai,

        /// <summary> Urdu language. </summary>
        [JsonStringEnumMemberName("ur")]
        Urdu,

        /// <summary> Croatian language. </summary>
        [JsonStringEnumMemberName("hr")]
        Croatian,

        /// <summary> Bulgarian language. </summary>
        [JsonStringEnumMemberName("bg")]
        Bulgarian,

        /// <summary> Lithuanian language. </summary>
        [JsonStringEnumMemberName("lt")]
        Lithuanian,

        /// <summary> Latin language. </summary>
        [JsonStringEnumMemberName("la")]
        Latin,

        /// <summary> Maori language. </summary>
        [JsonStringEnumMemberName("mi")]
        Maori,

        /// <summary> Malayalam language. </summary>
        [JsonStringEnumMemberName("ml")]
        Malayalam,

        /// <summary> Welsh language. </summary>
        [JsonStringEnumMemberName("cy")]
        Welsh,

        /// <summary> Slovak language. </summary>
        [JsonStringEnumMemberName("sk")]
        Slovak,

        /// <summary> Telugu language. </summary>
        [JsonStringEnumMemberName("te")]
        Telugu,

        /// <summary> Persian language. </summary>
        [JsonStringEnumMemberName("fa")]
        Persian,

        /// <summary> Latvian language. </summary>
        [JsonStringEnumMemberName("lv")]
        Latvian,

        /// <summary> Bengali language. </summary>
        [JsonStringEnumMemberName("bn")]
        Bengali,

        /// <summary> Serbian language. </summary>
        [JsonStringEnumMemberName("sr")]
        Serbian,

        /// <summary> Azerbaijani language. </summary>
        [JsonStringEnumMemberName("az")]
        Azerbaijani,

        /// <summary> Slovenian language. </summary>
        [JsonStringEnumMemberName("sl")]
        Slovenian,

        /// <summary> Kannada language. </summary>
        [JsonStringEnumMemberName("kn")]
        Kannada,

        /// <summary> Estonian language. </summary>
        [JsonStringEnumMemberName("et")]
        Estonian,

        /// <summary> Macedonian language. </summary>
        [JsonStringEnumMemberName("mk")]
        Macedonian,

        /// <summary> Breton language. </summary>
        [JsonStringEnumMemberName("br")]
        Breton,

        /// <summary> Basque language. </summary>
        [JsonStringEnumMemberName("eu")]
        Basque,

        /// <summary> Icelandic language. </summary>
        [JsonStringEnumMemberName("is")]
        Icelandic,

        /// <summary> Armenian language. </summary>
        [JsonStringEnumMemberName("hy")]
        Armenian,

        /// <summary> Nepali language. </summary>
        [JsonStringEnumMemberName("ne")]
        Nepali,

        /// <summary> Mongolian language. </summary>
        [JsonStringEnumMemberName("mn")]
        Mongolian,

        /// <summary> Bosnian language. </summary>
        [JsonStringEnumMemberName("bs")]
        Bosnian,

        /// <summary> Kazakh language. </summary>
        [JsonStringEnumMemberName("kk")]
        Kazakh,

        /// <summary> Albanian language. </summary>
        [JsonStringEnumMemberName("sq")]
        Albanian,

        /// <summary> Swahili language. </summary>
        [JsonStringEnumMemberName("sw")]
        Swahili,

        /// <summary> Galician language. </summary>
        [JsonStringEnumMemberName("gl")]
        Galician,

        /// <summary> Marathi language. </summary>
        [JsonStringEnumMemberName("mr")]
        Marathi,

        /// <summary> Punjabi language. </summary>
        [JsonStringEnumMemberName("pa")]
        Punjabi,

        /// <summary> Sinhala language. </summary>
        [JsonStringEnumMemberName("si")]
        Sinhala,

        /// <summary> Khmer language. </summary>
        [JsonStringEnumMemberName("km")]
        Khmer
    }
}