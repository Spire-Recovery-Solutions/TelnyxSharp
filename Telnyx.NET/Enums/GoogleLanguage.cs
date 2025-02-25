using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Supported languages for Google's speech recognition and transcription services.
    /// </summary>
    [JsonConverter(typeof(Converters.GoogleLanguageConverter))]
    public enum GoogleLanguage
    {
       /// <summary>Afrikaans</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("af")]
        Afrikaans,
        
        /// <summary>Albanian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sq")]
        Albanian,
        
        /// <summary>Amharic</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("am")]
        Amharic,
        
        /// <summary>Arabic</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ar")]
        Arabic,
        
        /// <summary>Armenian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("hy")]
        Armenian,
        
        /// <summary>Azerbaijani</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("az")]
        Azerbaijani,
        
        /// <summary>Basque</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("eu")]
        Basque,
        
        /// <summary>Bengali</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("bn")]
        Bengali,
        
        /// <summary>Bosnian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("bs")]
        Bosnian,
        
        /// <summary>Bulgarian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("bg")]
        Bulgarian,
        
        /// <summary>Burmese</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("my")]
        Burmese,
        
        /// <summary>Catalan</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ca")]
        Catalan,
        
        /// <summary>Cantonese</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("yue")]
        Cantonese,
        
        /// <summary>Chinese (Mandarin)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("zh")]
        Chinese,
        
        /// <summary>Croatian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("hr")]
        Croatian,
        
        /// <summary>Czech</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("cs")]
        Czech,
        
        /// <summary>Danish</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("da")]
        Danish,
        
        /// <summary>Dutch</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("nl")]
        Dutch,
        
        /// <summary>English</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("en")]
        English,
        
        /// <summary>Estonian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("et")]
        Estonian,
        
        /// <summary>Filipino (Tagalog)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fil")]
        Filipino,
        
        /// <summary>Finnish</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fi")]
        Finnish,
        
        /// <summary>French</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fr")]
        French,
        
        /// <summary>Galician</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("gl")]
        Galician,
        
        /// <summary>Georgian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ka")]
        Georgian,
        
        /// <summary>German</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("de")]
        German,
        
        /// <summary>Greek</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("el")]
        Greek,
        
        /// <summary>Gujarati</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("gu")]
        Gujarati,
        
        /// <summary>Hebrew</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("iw")]
        Hebrew,
        
        /// <summary>Hindi</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("hi")]
        Hindi,
        
        /// <summary>Hungarian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("hu")]
        Hungarian,
        
        /// <summary>Icelandic</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("is")]
        Icelandic,
        
        /// <summary>Indonesian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("id")]
        Indonesian,
        
        /// <summary>Italian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("it")]
        Italian,
        
        /// <summary>Japanese</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ja")]
        Japanese,
        
        /// <summary>Javanese</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("jv")]
        Javanese,
        
        /// <summary>Kannada</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("kn")]
        Kannada,
        
        /// <summary>Kazakh</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("kk")]
        Kazakh,
        
        /// <summary>Khmer</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("km")]
        Khmer,
        
        /// <summary>Korean</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ko")]
        Korean,
        
        /// <summary>Lao</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("lo")]
        Lao,
        
        /// <summary>Latvian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("lv")]
        Latvian,
        
        /// <summary>Lithuanian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("lt")]
        Lithuanian,
        
        /// <summary>Macedonian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("mk")]
        Macedonian,
        
        /// <summary>Malay</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ms")]
        Malay,
        
        /// <summary>Malayalam</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ml")]
        Malayalam,
        
        /// <summary>Marathi</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("mr")]
        Marathi,
        
        /// <summary>Mongolian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("mn")]
        Mongolian,
        
        /// <summary>Nepali</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ne")]
        Nepali,
        
        /// <summary>Norwegian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("no")]
        Norwegian,
        
        /// <summary>Persian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fa")]
        Persian,
        
        /// <summary>Polish</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pl")]
        Polish,
        
        /// <summary>Portuguese</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pt")]
        Portuguese,
        
        /// <summary>Punjabi</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pa")]
        Punjabi,
        
        /// <summary>Romanian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ro")]
        Romanian,
        
        /// <summary>Russian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ru")]
        Russian,
        
        /// <summary>Serbian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sr")]
        Serbian,
        
        /// <summary>Sinhala</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("si")]
        Sinhala,
        
        /// <summary>Slovak</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sk")]
        Slovak,
        
        /// <summary>Slovenian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sl")]
        Slovenian,
        
        /// <summary>Spanish</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("es")]
        Spanish,
        
        /// <summary>Sundanese</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("su")]
        Sundanese,
        
        /// <summary>Swahili</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sw")]
        Swahili,
        
        /// <summary>Swedish</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sv")]
        Swedish,
        
        /// <summary>Tamil</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ta")]
        Tamil,
        
        /// <summary>Telugu</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("te")]
        Telugu,
        
        /// <summary>Thai</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("th")]
        Thai,
        
        /// <summary>Turkish</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("tr")]
        Turkish,
        
        /// <summary>Ukrainian</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("uk")]
        Ukrainian,
        
        /// <summary>Urdu</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ur")]
        Urdu,
        
        /// <summary>Uzbek</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("uz")]
        Uzbek,
        
        /// <summary>Vietnamese</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("vi")]
        Vietnamese,
        
        /// <summary>Zulu</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("zu")]
        Zulu
    }
}