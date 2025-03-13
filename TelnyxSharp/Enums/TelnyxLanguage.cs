using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
   /// <summary>
    /// Supported languages for Telnyx transcription.
    /// </summary>
    [JsonConverter(typeof(Converters.TelnyxLanguageConverter))]
    public enum TelnyxLanguage
    {
        /// <summary> English language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("en")]
        English,

        /// <summary> Chinese language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("zh")]
        Chinese,

        /// <summary> German language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("de")]
        German,

        /// <summary> Spanish language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("es")]
        Spanish,

        /// <summary> Russian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ru")]
        Russian,

        /// <summary> Korean language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ko")]
        Korean,

        /// <summary> French language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fr")]
        French,

        /// <summary> Japanese language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ja")]
        Japanese,

        /// <summary> Portuguese language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pt")]
        Portuguese,

        /// <summary> Turkish language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("tr")]
        Turkish,

        /// <summary> Polish language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pl")]
        Polish,

        /// <summary> Catalan language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ca")]
        Catalan,

        /// <summary> Dutch language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("nl")]
        Dutch,

        /// <summary> Arabic language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ar")]
        Arabic,

        /// <summary> Swedish language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sv")]
        Swedish,

        /// <summary> Italian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("it")]
        Italian,

        /// <summary> Indonesian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("id")]
        Indonesian,

        /// <summary> Hindi language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("hi")]
        Hindi,

        /// <summary> Finnish language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fi")]
        Finnish,

        /// <summary> Vietnamese language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("vi")]
        Vietnamese,

        /// <summary> Hebrew language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("he")]
        Hebrew,

        /// <summary> Ukrainian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("uk")]
        Ukrainian,

        /// <summary> Greek language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("el")]
        Greek,

        /// <summary> Malay language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ms")]
        Malay,

        /// <summary> Czech language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("cs")]
        Czech,

        /// <summary> Romanian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ro")]
        Romanian,

        /// <summary> Danish language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("da")]
        Danish,

        /// <summary> Hungarian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("hu")]
        Hungarian,

        /// <summary> Tamil language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ta")]
        Tamil,

        /// <summary> Norwegian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("no")]
        Norwegian,

        /// <summary> Thai language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("th")]
        Thai,

        /// <summary> Urdu language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ur")]
        Urdu,

        /// <summary> Croatian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("hr")]
        Croatian,

        /// <summary> Bulgarian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("bg")]
        Bulgarian,

        /// <summary> Lithuanian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("lt")]
        Lithuanian,

        /// <summary> Latin language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("la")]
        Latin,

        /// <summary> Maori language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("mi")]
        Maori,

        /// <summary> Malayalam language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ml")]
        Malayalam,

        /// <summary> Welsh language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("cy")]
        Welsh,

        /// <summary> Slovak language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sk")]
        Slovak,

        /// <summary> Telugu language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("te")]
        Telugu,

        /// <summary> Persian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fa")]
        Persian,

        /// <summary> Latvian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("lv")]
        Latvian,

        /// <summary> Bengali language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("bn")]
        Bengali,

        /// <summary> Serbian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sr")]
        Serbian,

        /// <summary> Azerbaijani language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("az")]
        Azerbaijani,

        /// <summary> Slovenian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sl")]
        Slovenian,

        /// <summary> Kannada language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("kn")]
        Kannada,

        /// <summary> Estonian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("et")]
        Estonian,

        /// <summary> Macedonian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("mk")]
        Macedonian,

        /// <summary> Breton language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("br")]
        Breton,

        /// <summary> Basque language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("eu")]
        Basque,

        /// <summary> Icelandic language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("is")]
        Icelandic,

        /// <summary> Armenian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("hy")]
        Armenian,

        /// <summary> Nepali language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ne")]
        Nepali,

        /// <summary> Mongolian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("mn")]
        Mongolian,

        /// <summary> Bosnian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("bs")]
        Bosnian,

        /// <summary> Kazakh language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("kk")]
        Kazakh,

        /// <summary> Albanian language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sq")]
        Albanian,

        /// <summary> Swahili language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sw")]
        Swahili,

        /// <summary> Galician language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("gl")]
        Galician,

        /// <summary> Marathi language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("mr")]
        Marathi,

        /// <summary> Punjabi language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pa")]
        Punjabi,

        /// <summary> Sinhala language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("si")]
        Sinhala,

        /// <summary> Khmer language. </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("km")]
        Khmer
    }
}