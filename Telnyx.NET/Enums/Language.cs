using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing various languages and their respective locale codes.
    /// Each value is associated with a specific language code for use in various services.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Language
    {
        /// <summary>Arabic language (ARB)</summary>
        [JsonPropertyName("arb")]
        ARB,

        /// <summary>Mandarin Chinese (Simplified) language (cmn-CN)</summary>
        [JsonPropertyName("cmn-CN")]
        CmnCN,

        /// <summary>Welsh language (cy-GB)</summary>
        [JsonPropertyName("cy-GB")]
        CyGB,

        /// <summary>Danish language (da-DK)</summary>
        [JsonPropertyName("da-DK")]
        DaDK,

        /// <summary>German language (de-DE)</summary>
        [JsonPropertyName("de-DE")]
        DeDE,

        /// <summary>Australian English language (en-AU)</summary>
        [JsonPropertyName("en-AU")]
        EnAU,

        /// <summary>British English language (en-GB)</summary>
        [JsonPropertyName("en-GB")]
        EnGB,

        /// <summary>Welsh English language (en-GB-WLS)</summary>
        [JsonPropertyName("en-GB-WLS")]
        EnGBWLS,

        /// <summary>Indian English language (en-IN)</summary>
        [JsonPropertyName("en-IN")]
        EnIN,

        /// <summary>American English language (en-US)</summary>
        [JsonPropertyName("en-US")]
        EnUS,

        /// <summary>Spanish (Spain) language (es-ES)</summary>
        [JsonPropertyName("es-ES")]
        EsES,

        /// <summary>Spanish (Mexico) language (es-MX)</summary>
        [JsonPropertyName("es-MX")]
        EsMX,

        /// <summary>Spanish (US) language (es-US)</summary>
        [JsonPropertyName("es-US")]
        EsUS,

        /// <summary>French (Canada) language (fr-CA)</summary>
        [JsonPropertyName("fr-CA")]
        FrCA,

        /// <summary>French (France) language (fr-FR)</summary>
        [JsonPropertyName("fr-FR")]
        FrFR,

        /// <summary>Hindi language (hi-IN)</summary>
        [JsonPropertyName("hi-IN")]
        HiIN,

        /// <summary>Icelandic language (is-IS)</summary>
        [JsonPropertyName("is-IS")]
        IsIS,

        /// <summary>Italian language (it-IT)</summary>
        [JsonPropertyName("it-IT")]
        ItIT,

        /// <summary>Japanese language (ja-JP)</summary>
        [JsonPropertyName("ja-JP")]
        JaJP,

        /// <summary>Korean language (ko-KR)</summary>
        [JsonPropertyName("ko-KR")]
        KoKR,

        /// <summary>Norwegian Bokmål language (nb-NO)</summary>
        [JsonPropertyName("nb-NO")]
        NbNO,

        /// <summary>Dutch language (nl-NL)</summary>
        [JsonPropertyName("nl-NL")]
        NlNL,

        /// <summary>Polish language (pl-PL)</summary>
        [JsonPropertyName("pl-PL")]
        PlPL,

        /// <summary>Portuguese (Brazil) language (pt-BR)</summary>
        [JsonPropertyName("pt-BR")]
        PtBR,

        /// <summary>Portuguese (Portugal) language (pt-PT)</summary>
        [JsonPropertyName("pt-PT")]
        PtPT,

        /// <summary>Romanian language (ro-RO)</summary>
        [JsonPropertyName("ro-RO")]
        RoRO,

        /// <summary>Russian language (ru-RU)</summary>
        [JsonPropertyName("ru-RU")]
        RuRU,

        /// <summary>Swedish language (sv-SE)</summary>
        [JsonPropertyName("sv-SE")]
        SvSE,

        /// <summary>Turkish language (tr-TR)</summary>
        [JsonPropertyName("tr-TR")]
        TrTR
    }
}