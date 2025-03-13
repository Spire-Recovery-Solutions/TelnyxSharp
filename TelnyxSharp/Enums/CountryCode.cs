using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents country codes with their respective full country names.
    /// </summary>
    [JsonConverter(typeof(CountryCodeConverter))]
    public enum CountryCode
    {
        /// <summary>
        /// Austria (AT)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("AT")]
        Austria,

        /// <summary>
        /// Australia (AU)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("AU")]
        Australia,

        /// <summary>
        /// Belgium (BE)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("BE")]
        Belgium,

        /// <summary>
        /// Bulgaria (BG)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("BG")]
        Bulgaria,

        /// <summary>
        /// Canada (CA)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("CA")]
        Canada,

        /// <summary>
        /// Switzerland (CH)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("CH")]
        Switzerland,

        /// <summary>
        /// China (CN)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("CN")]
        China,

        /// <summary>
        /// Cyprus (CY)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("CY")]
        Cyprus,

        /// <summary>
        /// Czech Republic (CZ)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("CZ")]
        CzechRepublic,

        /// <summary>
        /// Germany (DE)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("DE")]
        Germany,

        /// <summary>
        /// Denmark (DK)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("DK")]
        Denmark,

        /// <summary>
        /// Estonia (EE)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("EE")]
        Estonia,

        /// <summary>
        /// Spain (ES)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ES")]
        Spain,

        /// <summary>
        /// Finland (FI)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("FI")]
        Finland,

        /// <summary>
        /// France (FR)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("FR")]
        France,

        /// <summary>
        /// United Kingdom (GB)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("GB")]
        UnitedKingdom,

        /// <summary>
        /// Greece (GR)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("GR")]
        Greece,

        /// <summary>
        /// Hungary (HU)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("HU")]
        Hungary,

        /// <summary>
        /// Croatia (HR)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("HR")]
        Croatia,

        /// <summary>
        /// Ireland (IE)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("IE")]
        Ireland,

        /// <summary>
        /// Italy (IT)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("IT")]
        Italy,

        /// <summary>
        /// Lithuania (LT)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("LT")]
        Lithuania,

        /// <summary>
        /// Luxembourg (LU)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("LU")]
        Luxembourg,

        /// <summary>
        /// Latvia (LV)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("LV")]
        Latvia,

        /// <summary>
        /// Netherlands (NL)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("NL")]
        Netherlands,

        /// <summary>
        /// New Zealand (NZ)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("NZ")]
        NewZealand,

        /// <summary>
        /// Mexico (MX)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("MX")]
        Mexico,

        /// <summary>
        /// Norway (NO)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("NO")]
        Norway,

        /// <summary>
        /// Poland (PL)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("PL")]
        Poland,

        /// <summary>
        /// Portugal (PT)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("PT")]
        Portugal,

        /// <summary>
        /// Romania (RO)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("RO")]
        Romania,

        /// <summary>
        /// Sweden (SE)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("SE")]
        Sweden,

        /// <summary>
        /// Singapore (SG)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("SG")]
        Singapore,

        /// <summary>
        /// Slovenia (SI)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("SI")]
        Slovenia,

        /// <summary>
        /// Slovakia (SK)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("SK")]
        Slovakia,

        /// <summary>
        /// United States (US)
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("US")]
        UnitedStates
    }
}