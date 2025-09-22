using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Represents countries with specific ringtone patterns in telephony systems.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<RingtoneCountry>))]
    public enum RingtoneCountry
    {
        /// <summary>Austria</summary>
        [JsonStringEnumMemberName("at")]
        Austria,

        /// <summary>Australia</summary>
        [JsonStringEnumMemberName("au")]
        Australia,

        /// <summary>Belgium</summary>
        [JsonStringEnumMemberName("be")]
        Belgium,

        /// <summary>Bulgaria</summary>
        [JsonStringEnumMemberName("bg")]
        Bulgaria,

        /// <summary>Brazil</summary>
        [JsonStringEnumMemberName("br")]
        Brazil,

        /// <summary>Switzerland</summary>
        [JsonStringEnumMemberName("ch")]
        Switzerland,

        /// <summary>Chile</summary>
        [JsonStringEnumMemberName("cl")]
        Chile,

        /// <summary>China</summary>
        [JsonStringEnumMemberName("cn")]
        China,

        /// <summary>Czech Republic</summary>
        [JsonStringEnumMemberName("cz")]
        CzechRepublic,

        /// <summary>Germany</summary>
        [JsonStringEnumMemberName("de")]
        Germany,

        /// <summary>Denmark</summary>
        [JsonStringEnumMemberName("dk")]
        Denmark,

        /// <summary>Estonia</summary>
        [JsonStringEnumMemberName("ee")]
        Estonia,

        /// <summary>Spain</summary>
        [JsonStringEnumMemberName("es")]
        Spain,

        /// <summary>Finland</summary>
        [JsonStringEnumMemberName("fi")]
        Finland,

        /// <summary>France</summary>
        [JsonStringEnumMemberName("fr")]
        France,

        /// <summary>Greece</summary>
        [JsonStringEnumMemberName("gr")]
        Greece,

        /// <summary>Hungary</summary>
        [JsonStringEnumMemberName("hu")]
        Hungary,

        /// <summary>Israel</summary>
        [JsonStringEnumMemberName("il")]
        Israel,

        /// <summary>India</summary>
        [JsonStringEnumMemberName("in")]
        India,

        /// <summary>Italy</summary>
        [JsonStringEnumMemberName("it")]
        Italy,

        /// <summary>Japan</summary>
        [JsonStringEnumMemberName("jp")]
        Japan,

        /// <summary>Lithuania</summary>
        [JsonStringEnumMemberName("lt")]
        Lithuania,

        /// <summary>Mexico</summary>
        [JsonStringEnumMemberName("mx")]
        Mexico,

        /// <summary>Malaysia</summary>
        [JsonStringEnumMemberName("my")]
        Malaysia,

        /// <summary>Netherlands</summary>
        [JsonStringEnumMemberName("nl")]
        Netherlands,

        /// <summary>Norway</summary>
        [JsonStringEnumMemberName("no")]
        Norway,

        /// <summary>New Zealand</summary>
        [JsonStringEnumMemberName("nz")]
        NewZealand,

        /// <summary>Philippines</summary>
        [JsonStringEnumMemberName("ph")]
        Philippines,

        /// <summary>Poland</summary>
        [JsonStringEnumMemberName("pl")]
        Poland,

        /// <summary>Portugal</summary>
        [JsonStringEnumMemberName("pt")]
        Portugal,

        /// <summary>Russia</summary>
        [JsonStringEnumMemberName("ru")]
        Russia,

        /// <summary>Sweden</summary>
        [JsonStringEnumMemberName("se")]
        Sweden,

        /// <summary>Singapore</summary>
        [JsonStringEnumMemberName("sg")]
        Singapore,

        /// <summary>Thailand</summary>
        [JsonStringEnumMemberName("th")]
        Thailand,

        /// <summary>Taiwan</summary>
        [JsonStringEnumMemberName("tw")]
        Taiwan,

        /// <summary>United Kingdom</summary>
        [JsonStringEnumMemberName("uk")]
        UnitedKingdom,

        /// <summary>United States (Legacy Pattern)</summary>
        [JsonStringEnumMemberName("us-old")]
        UnitedStatesLegacy,

        /// <summary>United States</summary>
        [JsonStringEnumMemberName("us")]
        UnitedStates,

        /// <summary>Venezuela</summary>
        [JsonStringEnumMemberName("ve")]
        Venezuela,

        /// <summary>South Africa</summary>
        [JsonStringEnumMemberName("za")]
        SouthAfrica
    }
}