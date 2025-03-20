using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
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
        [JsonStringEnumMemberName("AT")]
        Austria,

        /// <summary>
        /// Australia (AU)
        /// </summary>
        [JsonStringEnumMemberName("AU")]
        Australia,

        /// <summary>
        /// Belgium (BE)
        /// </summary>
        [JsonStringEnumMemberName("BE")]
        Belgium,

        /// <summary>
        /// Bulgaria (BG)
        /// </summary>
        [JsonStringEnumMemberName("BG")]
        Bulgaria,

        /// <summary>
        /// Canada (CA)
        /// </summary>
        [JsonStringEnumMemberName("CA")]
        Canada,

        /// <summary>
        /// Switzerland (CH)
        /// </summary>
        [JsonStringEnumMemberName("CH")]
        Switzerland,

        /// <summary>
        /// China (CN)
        /// </summary>
        [JsonStringEnumMemberName("CN")]
        China,

        /// <summary>
        /// Cyprus (CY)
        /// </summary>
        [JsonStringEnumMemberName("CY")]
        Cyprus,

        /// <summary>
        /// Czech Republic (CZ)
        /// </summary>
        [JsonStringEnumMemberName("CZ")]
        CzechRepublic,

        /// <summary>
        /// Germany (DE)
        /// </summary>
        [JsonStringEnumMemberName("DE")]
        Germany,

        /// <summary>
        /// Denmark (DK)
        /// </summary>
        [JsonStringEnumMemberName("DK")]
        Denmark,

        /// <summary>
        /// Estonia (EE)
        /// </summary>
        [JsonStringEnumMemberName("EE")]
        Estonia,

        /// <summary>
        /// Spain (ES)
        /// </summary>
        [JsonStringEnumMemberName("ES")]
        Spain,

        /// <summary>
        /// Finland (FI)
        /// </summary>
        [JsonStringEnumMemberName("FI")]
        Finland,

        /// <summary>
        /// France (FR)
        /// </summary>
        [JsonStringEnumMemberName("FR")]
        France,

        /// <summary>
        /// United Kingdom (GB)
        /// </summary>
        [JsonStringEnumMemberName("GB")]
        UnitedKingdom,

        /// <summary>
        /// Greece (GR)
        /// </summary>
        [JsonStringEnumMemberName("GR")]
        Greece,

        /// <summary>
        /// Hungary (HU)
        /// </summary>
        [JsonStringEnumMemberName("HU")]
        Hungary,

        /// <summary>
        /// Croatia (HR)
        /// </summary>
        [JsonStringEnumMemberName("HR")]
        Croatia,

        /// <summary>
        /// Ireland (IE)
        /// </summary>
        [JsonStringEnumMemberName("IE")]
        Ireland,

        /// <summary>
        /// Italy (IT)
        /// </summary>
        [JsonStringEnumMemberName("IT")]
        Italy,

        /// <summary>
        /// Lithuania (LT)
        /// </summary>
        [JsonStringEnumMemberName("LT")]
        Lithuania,

        /// <summary>
        /// Luxembourg (LU)
        /// </summary>
        [JsonStringEnumMemberName("LU")]
        Luxembourg,

        /// <summary>
        /// Latvia (LV)
        /// </summary>
        [JsonStringEnumMemberName("LV")]
        Latvia,

        /// <summary>
        /// Netherlands (NL)
        /// </summary>
        [JsonStringEnumMemberName("NL")]
        Netherlands,

        /// <summary>
        /// New Zealand (NZ)
        /// </summary>
        [JsonStringEnumMemberName("NZ")]
        NewZealand,

        /// <summary>
        /// Mexico (MX)
        /// </summary>
        [JsonStringEnumMemberName("MX")]
        Mexico,

        /// <summary>
        /// Norway (NO)
        /// </summary>
        [JsonStringEnumMemberName("NO")]
        Norway,

        /// <summary>
        /// Poland (PL)
        /// </summary>
        [JsonStringEnumMemberName("PL")]
        Poland,

        /// <summary>
        /// Portugal (PT)
        /// </summary>
        [JsonStringEnumMemberName("PT")]
        Portugal,

        /// <summary>
        /// Romania (RO)
        /// </summary>
        [JsonStringEnumMemberName("RO")]
        Romania,

        /// <summary>
        /// Sweden (SE)
        /// </summary>
        [JsonStringEnumMemberName("SE")]
        Sweden,

        /// <summary>
        /// Singapore (SG)
        /// </summary>
        [JsonStringEnumMemberName("SG")]
        Singapore,

        /// <summary>
        /// Slovenia (SI)
        /// </summary>
        [JsonStringEnumMemberName("SI")]
        Slovenia,

        /// <summary>
        /// Slovakia (SK)
        /// </summary>
        [JsonStringEnumMemberName("SK")]
        Slovakia,

        /// <summary>
        /// United States (US)
        /// </summary>
        [JsonStringEnumMemberName("US")]
        UnitedStates
    }
}