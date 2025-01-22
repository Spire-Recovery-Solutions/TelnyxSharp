using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents country codes with their respective full country names.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CountryCode
    {
        /// <summary>
        /// Austria (AT)
        /// </summary>
        [JsonPropertyName("AT")]
        Austria,

        /// <summary>
        /// Australia (AU)
        /// </summary>
        [JsonPropertyName("AU")]
        Australia,

        /// <summary>
        /// Belgium (BE)
        /// </summary>
        [JsonPropertyName("BE")]
        Belgium,

        /// <summary>
        /// Bulgaria (BG)
        /// </summary>
        [JsonPropertyName("BG")]
        Bulgaria,

        /// <summary>
        /// Canada (CA)
        /// </summary>
        [JsonPropertyName("CA")]
        Canada,

        /// <summary>
        /// Switzerland (CH)
        /// </summary>
        [JsonPropertyName("CH")]
        Switzerland,

        /// <summary>
        /// China (CN)
        /// </summary>
        [JsonPropertyName("CN")]
        China,

        /// <summary>
        /// Cyprus (CY)
        /// </summary>
        [JsonPropertyName("CY")]
        Cyprus,

        /// <summary>
        /// Czech Republic (CZ)
        /// </summary>
        [JsonPropertyName("CZ")]
        CzechRepublic,

        /// <summary>
        /// Germany (DE)
        /// </summary>
        [JsonPropertyName("DE")]
        Germany,

        /// <summary>
        /// Denmark (DK)
        /// </summary>
        [JsonPropertyName("DK")]
        Denmark,

        /// <summary>
        /// Estonia (EE)
        /// </summary>
        [JsonPropertyName("EE")]
        Estonia,

        /// <summary>
        /// Spain (ES)
        /// </summary>
        [JsonPropertyName("ES")]
        Spain,

        /// <summary>
        /// Finland (FI)
        /// </summary>
        [JsonPropertyName("FI")]
        Finland,

        /// <summary>
        /// France (FR)
        /// </summary>
        [JsonPropertyName("FR")]
        France,

        /// <summary>
        /// United Kingdom (GB)
        /// </summary>
        [JsonPropertyName("GB")]
        UnitedKingdom,

        /// <summary>
        /// Greece (GR)
        /// </summary>
        [JsonPropertyName("GR")]
        Greece,

        /// <summary>
        /// Hungary (HU)
        /// </summary>
        [JsonPropertyName("HU")]
        Hungary,

        /// <summary>
        /// Croatia (HR)
        /// </summary>
        [JsonPropertyName("HR")]
        Croatia,

        /// <summary>
        /// Ireland (IE)
        /// </summary>
        [JsonPropertyName("IE")]
        Ireland,

        /// <summary>
        /// Italy (IT)
        /// </summary>
        [JsonPropertyName("IT")]
        Italy,

        /// <summary>
        /// Lithuania (LT)
        /// </summary>
        [JsonPropertyName("LT")]
        Lithuania,

        /// <summary>
        /// Luxembourg (LU)
        /// </summary>
        [JsonPropertyName("LU")]
        Luxembourg,

        /// <summary>
        /// Latvia (LV)
        /// </summary>
        [JsonPropertyName("LV")]
        Latvia,

        /// <summary>
        /// Netherlands (NL)
        /// </summary>
        [JsonPropertyName("NL")]
        Netherlands,

        /// <summary>
        /// New Zealand (NZ)
        /// </summary>
        [JsonPropertyName("NZ")]
        NewZealand,

        /// <summary>
        /// Mexico (MX)
        /// </summary>
        [JsonPropertyName("MX")]
        Mexico,

        /// <summary>
        /// Norway (NO)
        /// </summary>
        [JsonPropertyName("NO")]
        Norway,

        /// <summary>
        /// Poland (PL)
        /// </summary>
        [JsonPropertyName("PL")]
        Poland,

        /// <summary>
        /// Portugal (PT)
        /// </summary>
        [JsonPropertyName("PT")]
        Portugal,

        /// <summary>
        /// Romania (RO)
        /// </summary>
        [JsonPropertyName("RO")]
        Romania,

        /// <summary>
        /// Sweden (SE)
        /// </summary>
        [JsonPropertyName("SE")]
        Sweden,

        /// <summary>
        /// Singapore (SG)
        /// </summary>
        [JsonPropertyName("SG")]
        Singapore,

        /// <summary>
        /// Slovenia (SI)
        /// </summary>
        [JsonPropertyName("SI")]
        Slovenia,

        /// <summary>
        /// Slovakia (SK)
        /// </summary>
        [JsonPropertyName("SK")]
        Slovakia,

        /// <summary>
        /// United States (US)
        /// </summary>
        [JsonPropertyName("US")]
        UnitedStates
    }
}