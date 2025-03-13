using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing various languages and their respective locale codes.
    /// Each value is associated with a specific language code for use in various services.
    /// </summary>
    [JsonConverter(typeof(Converters.LanguageConverter))]
    public enum Language
    {
        /// <summary>Arabic language (ARB)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("arb")]
        ARB,

        /// <summary>Mandarin Chinese (Simplified) language (cmn-CN)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("cmn-CN")]
        CmnCN,

        /// <summary>Welsh language (cy-GB)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("cy-GB")]
        CyGB,

        /// <summary>Danish language (da-DK)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("da-DK")]
        DaDK,

        /// <summary>German language (de-DE)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("de-DE")]
        DeDE,

        /// <summary>Australian English language (en-AU)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("en-AU")]
        EnAU,

        /// <summary>British English language (en-GB)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("en-GB")]
        EnGB,

        /// <summary>Welsh English language (en-GB-WLS)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("en-GB-WLS")]
        EnGBWLS,

        /// <summary>Indian English language (en-IN)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("en-IN")]
        EnIN,

        /// <summary>American English language (en-US)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("en-US")]
        EnUS,

        /// <summary>Spanish (Spain) language (es-ES)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("es-ES")]
        EsES,

        /// <summary>Spanish (Mexico) language (es-MX)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("es-MX")]
        EsMX,

        /// <summary>Spanish (US) language (es-US)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("es-US")]
        EsUS,

        /// <summary>French (Canada) language (fr-CA)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fr-CA")]
        FrCA,

        /// <summary>French (France) language (fr-FR)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fr-FR")]
        FrFR,

        /// <summary>Hindi language (hi-IN)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("hi-IN")]
        HiIN,

        /// <summary>Icelandic language (is-IS)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("is-IS")]
        IsIS,

        /// <summary>Italian language (it-IT)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("it-IT")]
        ItIT,

        /// <summary>Japanese language (ja-JP)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ja-JP")]
        JaJP,

        /// <summary>Korean language (ko-KR)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ko-KR")]
        KoKR,

        /// <summary>Norwegian Bokmål language (nb-NO)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("nb-NO")]
        NbNO,

        /// <summary>Dutch language (nl-NL)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("nl-NL")]
        NlNL,

        /// <summary>Polish language (pl-PL)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pl-PL")]
        PlPL,

        /// <summary>Portuguese (Brazil) language (pt-BR)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pt-BR")]
        PtBR,

        /// <summary>Portuguese (Portugal) language (pt-PT)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pt-PT")]
        PtPT,

        /// <summary>Romanian language (ro-RO)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ro-RO")]
        RoRO,

        /// <summary>Russian language (ru-RU)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ru-RU")]
        RuRU,

        /// <summary>Swedish language (sv-SE)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sv-SE")]
        SvSE,

        /// <summary>Turkish language (tr-TR)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("tr-TR")]
        TrTR
    }
}