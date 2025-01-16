using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Supported languages for Google's speech recognition and transcription services.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GoogleLanguage
    {
        /// <summary>Afrikaans</summary>
        [JsonPropertyName("af")] Afrikaans,
        
        /// <summary>Albanian</summary>
        [JsonPropertyName("sq")] Albanian,
        
        /// <summary>Amharic</summary>
        [JsonPropertyName("am")] Amharic,
        
        /// <summary>Arabic</summary>
        [JsonPropertyName("ar")] Arabic,
        
        /// <summary>Armenian</summary>
        [JsonPropertyName("hy")] Armenian,
        
        /// <summary>Azerbaijani</summary>
        [JsonPropertyName("az")] Azerbaijani,
        
        /// <summary>Basque</summary>
        [JsonPropertyName("eu")] Basque,
        
        /// <summary>Bengali</summary>
        [JsonPropertyName("bn")] Bengali,
        
        /// <summary>Bosnian</summary>
        [JsonPropertyName("bs")] Bosnian,
        
        /// <summary>Bulgarian</summary>
        [JsonPropertyName("bg")] Bulgarian,
        
        /// <summary>Burmese</summary>
        [JsonPropertyName("my")] Burmese,
        
        /// <summary>Catalan</summary>
        [JsonPropertyName("ca")] Catalan,
        
        /// <summary>Cantonese</summary>
        [JsonPropertyName("yue")] Cantonese,
        
        /// <summary>Chinese (Mandarin)</summary>
        [JsonPropertyName("zh")] Chinese,
        
        /// <summary>Croatian</summary>
        [JsonPropertyName("hr")] Croatian,
        
        /// <summary>Czech</summary>
        [JsonPropertyName("cs")] Czech,
        
        /// <summary>Danish</summary>
        [JsonPropertyName("da")] Danish,
        
        /// <summary>Dutch</summary>
        [JsonPropertyName("nl")] Dutch,
        
        /// <summary>English</summary>
        [JsonPropertyName("en")] English,
        
        /// <summary>Estonian</summary>
        [JsonPropertyName("et")] Estonian,
        
        /// <summary>Filipino (Tagalog)</summary>
        [JsonPropertyName("fil")] Filipino,
        
        /// <summary>Finnish</summary>
        [JsonPropertyName("fi")] Finnish,
        
        /// <summary>French</summary>
        [JsonPropertyName("fr")] French,
        
        /// <summary>Galician</summary>
        [JsonPropertyName("gl")] Galician,
        
        /// <summary>Georgian</summary>
        [JsonPropertyName("ka")] Georgian,
        
        /// <summary>German</summary>
        [JsonPropertyName("de")] German,
        
        /// <summary>Greek</summary>
        [JsonPropertyName("el")] Greek,
        
        /// <summary>Gujarati</summary>
        [JsonPropertyName("gu")] Gujarati,
        
        /// <summary>Hebrew</summary>
        [JsonPropertyName("iw")] Hebrew,
        
        /// <summary>Hindi</summary>
        [JsonPropertyName("hi")] Hindi,
        
        /// <summary>Hungarian</summary>
        [JsonPropertyName("hu")] Hungarian,
        
        /// <summary>Icelandic</summary>
        [JsonPropertyName("is")] Icelandic,
        
        /// <summary>Indonesian</summary>
        [JsonPropertyName("id")] Indonesian,
        
        /// <summary>Italian</summary>
        [JsonPropertyName("it")] Italian,
        
        /// <summary>Japanese</summary>
        [JsonPropertyName("ja")] Japanese,
        
        /// <summary>Javanese</summary>
        [JsonPropertyName("jv")] Javanese,
        
        /// <summary>Kannada</summary>
        [JsonPropertyName("kn")] Kannada,
        
        /// <summary>Kazakh</summary>
        [JsonPropertyName("kk")] Kazakh,
        
        /// <summary>Khmer</summary>
        [JsonPropertyName("km")] Khmer,
        
        /// <summary>Korean</summary>
        [JsonPropertyName("ko")] Korean,
        
        /// <summary>Lao</summary>
        [JsonPropertyName("lo")] Lao,
        
        /// <summary>Latvian</summary>
        [JsonPropertyName("lv")] Latvian,
        
        /// <summary>Lithuanian</summary>
        [JsonPropertyName("lt")] Lithuanian,
        
        /// <summary>Macedonian</summary>
        [JsonPropertyName("mk")] Macedonian,
        
        /// <summary>Malay</summary>
        [JsonPropertyName("ms")] Malay,
        
        /// <summary>Malayalam</summary>
        [JsonPropertyName("ml")] Malayalam,
        
        /// <summary>Marathi</summary>
        [JsonPropertyName("mr")] Marathi,
        
        /// <summary>Mongolian</summary>
        [JsonPropertyName("mn")] Mongolian,
        
        /// <summary>Nepali</summary>
        [JsonPropertyName("ne")] Nepali,
        
        /// <summary>Norwegian</summary>
        [JsonPropertyName("no")] Norwegian,
        
        /// <summary>Persian</summary>
        [JsonPropertyName("fa")] Persian,
        
        /// <summary>Polish</summary>
        [JsonPropertyName("pl")] Polish,
        
        /// <summary>Portuguese</summary>
        [JsonPropertyName("pt")] Portuguese,
        
        /// <summary>Punjabi</summary>
        [JsonPropertyName("pa")] Punjabi,
        
        /// <summary>Romanian</summary>
        [JsonPropertyName("ro")] Romanian,
        
        /// <summary>Russian</summary>
        [JsonPropertyName("ru")] Russian,
        
        /// <summary>Serbian</summary>
        [JsonPropertyName("sr")] Serbian,
        
        /// <summary>Sinhala</summary>
        [JsonPropertyName("si")] Sinhala,
        
        /// <summary>Slovak</summary>
        [JsonPropertyName("sk")] Slovak,
        
        /// <summary>Slovenian</summary>
        [JsonPropertyName("sl")] Slovenian,
        
        /// <summary>Spanish</summary>
        [JsonPropertyName("es")] Spanish,
        
        /// <summary>Sundanese</summary>
        [JsonPropertyName("su")] Sundanese,
        
        /// <summary>Swahili</summary>
        [JsonPropertyName("sw")] Swahili,
        
        /// <summary>Swedish</summary>
        [JsonPropertyName("sv")] Swedish,
        
        /// <summary>Tamil</summary>
        [JsonPropertyName("ta")] Tamil,
        
        /// <summary>Telugu</summary>
        [JsonPropertyName("te")] Telugu,
        
        /// <summary>Thai</summary>
        [JsonPropertyName("th")] Thai,
        
        /// <summary>Turkish</summary>
        [JsonPropertyName("tr")] Turkish,
        
        /// <summary>Ukrainian</summary>
        [JsonPropertyName("uk")] Ukrainian,
        
        /// <summary>Urdu</summary>
        [JsonPropertyName("ur")] Urdu,
        
        /// <summary>Uzbek</summary>
        [JsonPropertyName("uz")] Uzbek,
        
        /// <summary>Vietnamese</summary>
        [JsonPropertyName("vi")] Vietnamese,
        
        /// <summary>Zulu</summary>
        [JsonPropertyName("zu")] Zulu
    }
}