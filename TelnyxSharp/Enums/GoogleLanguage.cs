using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Supported languages for Google's speech recognition and transcription services.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GoogleLanguage
    {
        /// <summary>Afrikaans</summary>
        [JsonStringEnumMemberName("af")]
        Afrikaans,

        /// <summary>Albanian</summary>
        [JsonStringEnumMemberName("sq")]
        Albanian,

        /// <summary>Amharic</summary>
        [JsonStringEnumMemberName("am")]
        Amharic,

        /// <summary>Arabic</summary>
        [JsonStringEnumMemberName("ar")]
        Arabic,

        /// <summary>Armenian</summary>
        [JsonStringEnumMemberName("hy")]
        Armenian,

        /// <summary>Azerbaijani</summary>
        [JsonStringEnumMemberName("az")]
        Azerbaijani,

        /// <summary>Basque</summary>
        [JsonStringEnumMemberName("eu")]
        Basque,

        /// <summary>Bengali</summary>
        [JsonStringEnumMemberName("bn")]
        Bengali,

        /// <summary>Bosnian</summary>
        [JsonStringEnumMemberName("bs")]
        Bosnian,

        /// <summary>Bulgarian</summary>
        [JsonStringEnumMemberName("bg")]
        Bulgarian,

        /// <summary>Burmese</summary>
        [JsonStringEnumMemberName("my")]
        Burmese,

        /// <summary>Catalan</summary>
        [JsonStringEnumMemberName("ca")]
        Catalan,

        /// <summary>Cantonese</summary>
        [JsonStringEnumMemberName("yue")]
        Cantonese,

        /// <summary>Chinese (Mandarin)</summary>
        [JsonStringEnumMemberName("zh")]
        Chinese,

        /// <summary>Croatian</summary>
        [JsonStringEnumMemberName("hr")]
        Croatian,

        /// <summary>Czech</summary>
        [JsonStringEnumMemberName("cs")]
        Czech,

        /// <summary>Danish</summary>
        [JsonStringEnumMemberName("da")]
        Danish,

        /// <summary>Dutch</summary>
        [JsonStringEnumMemberName("nl")]
        Dutch,

        /// <summary>English</summary>
        [JsonStringEnumMemberName("en")]
        English,

        /// <summary>Estonian</summary>
        [JsonStringEnumMemberName("et")]
        Estonian,

        /// <summary>Filipino (Tagalog)</summary>
        [JsonStringEnumMemberName("fil")]
        Filipino,

        /// <summary>Finnish</summary>
        [JsonStringEnumMemberName("fi")]
        Finnish,

        /// <summary>French</summary>
        [JsonStringEnumMemberName("fr")]
        French,

        /// <summary>Galician</summary>
        [JsonStringEnumMemberName("gl")]
        Galician,

        /// <summary>Georgian</summary>
        [JsonStringEnumMemberName("ka")]
        Georgian,

        /// <summary>German</summary>
        [JsonStringEnumMemberName("de")]
        German,

        /// <summary>Greek</summary>
        [JsonStringEnumMemberName("el")]
        Greek,

        /// <summary>Gujarati</summary>
        [JsonStringEnumMemberName("gu")]
        Gujarati,

        /// <summary>Hebrew</summary>
        [JsonStringEnumMemberName("iw")]
        Hebrew,

        /// <summary>Hindi</summary>
        [JsonStringEnumMemberName("hi")]
        Hindi,

        /// <summary>Hungarian</summary>
        [JsonStringEnumMemberName("hu")]
        Hungarian,

        /// <summary>Icelandic</summary>
        [JsonStringEnumMemberName("is")]
        Icelandic,

        /// <summary>Indonesian</summary>
        [JsonStringEnumMemberName("id")]
        Indonesian,

        /// <summary>Italian</summary>
        [JsonStringEnumMemberName("it")]
        Italian,

        /// <summary>Japanese</summary>
        [JsonStringEnumMemberName("ja")]
        Japanese,

        /// <summary>Javanese</summary>
        [JsonStringEnumMemberName("jv")]
        Javanese,

        /// <summary>Kannada</summary>
        [JsonStringEnumMemberName("kn")]
        Kannada,

        /// <summary>Kazakh</summary>
        [JsonStringEnumMemberName("kk")]
        Kazakh,

        /// <summary>Khmer</summary>
        [JsonStringEnumMemberName("km")]
        Khmer,

        /// <summary>Korean</summary>
        [JsonStringEnumMemberName("ko")]
        Korean,

        /// <summary>Lao</summary>
        [JsonStringEnumMemberName("lo")]
        Lao,

        /// <summary>Latvian</summary>
        [JsonStringEnumMemberName("lv")]
        Latvian,

        /// <summary>Lithuanian</summary>
        [JsonStringEnumMemberName("lt")]
        Lithuanian,

        /// <summary>Macedonian</summary>
        [JsonStringEnumMemberName("mk")]
        Macedonian,

        /// <summary>Malay</summary>
        [JsonStringEnumMemberName("ms")]
        Malay,

        /// <summary>Malayalam</summary>
        [JsonStringEnumMemberName("ml")]
        Malayalam,

        /// <summary>Marathi</summary>
        [JsonStringEnumMemberName("mr")]
        Marathi,

        /// <summary>Mongolian</summary>
        [JsonStringEnumMemberName("mn")]
        Mongolian,

        /// <summary>Nepali</summary>
        [JsonStringEnumMemberName("ne")]
        Nepali,

        /// <summary>Norwegian</summary>
        [JsonStringEnumMemberName("no")]
        Norwegian,

        /// <summary>Persian</summary>
        [JsonStringEnumMemberName("fa")]
        Persian,

        /// <summary>Polish</summary>
        [JsonStringEnumMemberName("pl")]
        Polish,

        /// <summary>Portuguese</summary>
        [JsonStringEnumMemberName("pt")]
        Portuguese,

        /// <summary>Punjabi</summary>
        [JsonStringEnumMemberName("pa")]
        Punjabi,

        /// <summary>Romanian</summary>
        [JsonStringEnumMemberName("ro")]
        Romanian,

        /// <summary>Russian</summary>
        [JsonStringEnumMemberName("ru")]
        Russian,

        /// <summary>Serbian</summary>
        [JsonStringEnumMemberName("sr")]
        Serbian,

        /// <summary>Sinhala</summary>
        [JsonStringEnumMemberName("si")]
        Sinhala,

        /// <summary>Slovak</summary>
        [JsonStringEnumMemberName("sk")]
        Slovak,

        /// <summary>Slovenian</summary>
        [JsonStringEnumMemberName("sl")]
        Slovenian,

        /// <summary>Spanish</summary>
        [JsonStringEnumMemberName("es")]
        Spanish,

        /// <summary>Sundanese</summary>
        [JsonStringEnumMemberName("su")]
        Sundanese,

        /// <summary>Swahili</summary>
        [JsonStringEnumMemberName("sw")]
        Swahili,

        /// <summary>Swedish</summary>
        [JsonStringEnumMemberName("sv")]
        Swedish,

        /// <summary>Tamil</summary>
        [JsonStringEnumMemberName("ta")]
        Tamil,

        /// <summary>Telugu</summary>
        [JsonStringEnumMemberName("te")]
        Telugu,

        /// <summary>Thai</summary>
        [JsonStringEnumMemberName("th")]
        Thai,

        /// <summary>Turkish</summary>
        [JsonStringEnumMemberName("tr")]
        Turkish,

        /// <summary>Ukrainian</summary>
        [JsonStringEnumMemberName("uk")]
        Ukrainian,

        /// <summary>Urdu</summary>
        [JsonStringEnumMemberName("ur")]
        Urdu,

        /// <summary>Uzbek</summary>
        [JsonStringEnumMemberName("uz")]
        Uzbek,

        /// <summary>Vietnamese</summary>
        [JsonStringEnumMemberName("vi")]
        Vietnamese,

        /// <summary>Zulu</summary>
        [JsonStringEnumMemberName("zu")]
        Zulu
    }
}