using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents countries with specific ringtone patterns in telephony systems.
    /// </summary>
    [JsonConverter(typeof(Converters.RingtoneCountryConverter))]
    public enum RingtoneCountry
    {
        /// <summary>Austria</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("at")]
        Austria,

        /// <summary>Australia</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("au")]
        Australia,

        /// <summary>Belgium</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("be")]
        Belgium,

        /// <summary>Bulgaria</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("bg")]
        Bulgaria,

        /// <summary>Brazil</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("br")]
        Brazil,

        /// <summary>Switzerland</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ch")]
        Switzerland,

        /// <summary>Chile</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("cl")]
        Chile,

        /// <summary>China</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("cn")]
        China,

        /// <summary>Czech Republic</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("cz")]
        CzechRepublic,

        /// <summary>Germany</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("de")]
        Germany,

        /// <summary>Denmark</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("dk")]
        Denmark,

        /// <summary>Estonia</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ee")]
        Estonia,

        /// <summary>Spain</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("es")]
        Spain,

        /// <summary>Finland</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fi")]
        Finland,

        /// <summary>France</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("fr")]
        France,

        /// <summary>Greece</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("gr")]
        Greece,

        /// <summary>Hungary</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("hu")]
        Hungary,

        /// <summary>Israel</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("il")]
        Israel,

        /// <summary>India</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("in")]
        India,

        /// <summary>Italy</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("it")]
        Italy,

        /// <summary>Japan</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("jp")]
        Japan,

        /// <summary>Lithuania</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("lt")]
        Lithuania,

        /// <summary>Mexico</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("mx")]
        Mexico,

        /// <summary>Malaysia</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("my")]
        Malaysia,

        /// <summary>Netherlands</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("nl")]
        Netherlands,

        /// <summary>Norway</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("no")]
        Norway,

        /// <summary>New Zealand</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("nz")]
        NewZealand,

        /// <summary>Philippines</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ph")]
        Philippines,

        /// <summary>Poland</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pl")]
        Poland,

        /// <summary>Portugal</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("pt")]
        Portugal,

        /// <summary>Russia</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ru")]
        Russia,

        /// <summary>Sweden</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("se")]
        Sweden,

        /// <summary>Singapore</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("sg")]
        Singapore,

        /// <summary>Thailand</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("th")]
        Thailand,

        /// <summary>Taiwan</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("tw")]
        Taiwan,

        /// <summary>United Kingdom</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("uk")]
        UnitedKingdom,

        /// <summary>United States (Legacy Pattern)</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("us-old")]
        UnitedStatesLegacy,

        /// <summary>United States</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("us")]
        UnitedStates,

        /// <summary>Venezuela</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("ve")]
        Venezuela,

        /// <summary>South Africa</summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("za")]
        SouthAfrica
    }
}