using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing various languages and their respective locale codes.
    /// Each value is associated with a specific language code for use in various services.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Language
    {
        /// <summary>Arabic language (ARB)</summary>
        [JsonStringEnumMemberName("arb")]
        ARB,

        /// <summary>Mandarin Chinese (Simplified) language (cmn-CN)</summary>
        [JsonStringEnumMemberName("cmn-CN")]
        CmnCN,

        /// <summary>Welsh language (cy-GB)</summary>
        [JsonStringEnumMemberName("cy-GB")]
        CyGB,

        /// <summary>Danish language (da-DK)</summary>
        [JsonStringEnumMemberName("da-DK")]
        DaDK,

        /// <summary>German language (de-DE)</summary>
        [JsonStringEnumMemberName("de-DE")]
        DeDE,

        /// <summary>Australian English language (en-AU)</summary>
        [JsonStringEnumMemberName("en-AU")]
        EnAU,

        /// <summary>British English language (en-GB)</summary>
        [JsonStringEnumMemberName("en-GB")]
        EnGB,

        /// <summary>Welsh English language (en-GB-WLS)</summary>
        [JsonStringEnumMemberName("en-GB-WLS")]
        EnGBWLS,

        /// <summary>Indian English language (en-IN)</summary>
        [JsonStringEnumMemberName("en-IN")]
        EnIN,

        /// <summary>American English language (en-US)</summary>
        [JsonStringEnumMemberName("en-US")]
        EnUS,

        /// <summary>Spanish (Spain) language (es-ES)</summary>
        [JsonStringEnumMemberName("es-ES")]
        EsES,

        /// <summary>Spanish (Mexico) language (es-MX)</summary>
        [JsonStringEnumMemberName("es-MX")]
        EsMX,

        /// <summary>Spanish (US) language (es-US)</summary>
        [JsonStringEnumMemberName("es-US")]
        EsUS,

        /// <summary>French (Canada) language (fr-CA)</summary>
        [JsonStringEnumMemberName("fr-CA")]
        FrCA,

        /// <summary>French (France) language (fr-FR)</summary>
        [JsonStringEnumMemberName("fr-FR")]
        FrFR,

        /// <summary>Hindi language (hi-IN)</summary>
        [JsonStringEnumMemberName("hi-IN")]
        HiIN,

        /// <summary>Icelandic language (is-IS)</summary>
        [JsonStringEnumMemberName("is-IS")]
        IsIS,

        /// <summary>Italian language (it-IT)</summary>
        [JsonStringEnumMemberName("it-IT")]
        ItIT,

        /// <summary>Japanese language (ja-JP)</summary>
        [JsonStringEnumMemberName("ja-JP")]
        JaJP,

        /// <summary>Korean language (ko-KR)</summary>
        [JsonStringEnumMemberName("ko-KR")]
        KoKR,

        /// <summary>Norwegian Bokmål language (nb-NO)</summary>
        [JsonStringEnumMemberName("nb-NO")]
        NbNO,

        /// <summary>Dutch language (nl-NL)</summary>
        [JsonStringEnumMemberName("nl-NL")]
        NlNL,

        /// <summary>Polish language (pl-PL)</summary>
        [JsonStringEnumMemberName("pl-PL")]
        PlPL,

        /// <summary>Portuguese (Brazil) language (pt-BR)</summary>
        [JsonStringEnumMemberName("pt-BR")]
        PtBR,

        /// <summary>Portuguese (Portugal) language (pt-PT)</summary>
        [JsonStringEnumMemberName("pt-PT")]
        PtPT,

        /// <summary>Romanian language (ro-RO)</summary>
        [JsonStringEnumMemberName("ro-RO")]
        RoRO,

        /// <summary>Russian language (ru-RU)</summary>
        [JsonStringEnumMemberName("ru-RU")]
        RuRU,

        /// <summary>Swedish language (sv-SE)</summary>
        [JsonStringEnumMemberName("sv-SE")]
        SvSE,

        /// <summary>Turkish language (tr-TR)</summary>
        [JsonStringEnumMemberName("tr-TR")]
        TrTR
    }
}