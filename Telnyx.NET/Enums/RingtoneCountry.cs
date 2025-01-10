using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents countries with specific ringtone patterns in telephony systems.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RingtoneCountry
    {
        /// <summary>Austria</summary>
        [JsonPropertyName("at")]
        Austria,

        /// <summary>Australia</summary>
        [JsonPropertyName("au")]
        Australia,

        /// <summary>Belgium</summary>
        [JsonPropertyName("be")]
        Belgium,

        /// <summary>Bulgaria</summary>
        [JsonPropertyName("bg")]
        Bulgaria,

        /// <summary>Brazil</summary>
        [JsonPropertyName("br")]
        Brazil,

        /// <summary>Switzerland</summary>
        [JsonPropertyName("ch")]
        Switzerland,

        /// <summary>Chile</summary>
        [JsonPropertyName("cl")]
        Chile,

        /// <summary>China</summary>
        [JsonPropertyName("cn")]
        China,

        /// <summary>Czech Republic</summary>
        [JsonPropertyName("cz")]
        CzechRepublic,

        /// <summary>Germany</summary>
        [JsonPropertyName("de")]
        Germany,

        /// <summary>Denmark</summary>
        [JsonPropertyName("dk")]
        Denmark,

        /// <summary>Estonia</summary>
        [JsonPropertyName("ee")]
        Estonia,

        /// <summary>Spain</summary>
        [JsonPropertyName("es")]
        Spain,

        /// <summary>Finland</summary>
        [JsonPropertyName("fi")]
        Finland,

        /// <summary>France</summary>
        [JsonPropertyName("fr")]
        France,

        /// <summary>Greece</summary>
        [JsonPropertyName("gr")]
        Greece,

        /// <summary>Hungary</summary>
        [JsonPropertyName("hu")]
        Hungary,

        /// <summary>Israel</summary>
        [JsonPropertyName("il")]
        Israel,

        /// <summary>India</summary>
        [JsonPropertyName("in")]
        India,

        /// <summary>Italy</summary>
        [JsonPropertyName("it")]
        Italy,

        /// <summary>Japan</summary>
        [JsonPropertyName("jp")]
        Japan,

        /// <summary>Lithuania</summary>
        [JsonPropertyName("lt")]
        Lithuania,

        /// <summary>Mexico</summary>
        [JsonPropertyName("mx")]
        Mexico,

        /// <summary>Malaysia</summary>
        [JsonPropertyName("my")]
        Malaysia,

        /// <summary>Netherlands</summary>
        [JsonPropertyName("nl")]
        Netherlands,

        /// <summary>Norway</summary>
        [JsonPropertyName("no")]
        Norway,

        /// <summary>New Zealand</summary>
        [JsonPropertyName("nz")]
        NewZealand,

        /// <summary>Philippines</summary>
        [JsonPropertyName("ph")]
        Philippines,

        /// <summary>Poland</summary>
        [JsonPropertyName("pl")]
        Poland,

        /// <summary>Portugal</summary>
        [JsonPropertyName("pt")]
        Portugal,

        /// <summary>Russia</summary>
        [JsonPropertyName("ru")]
        Russia,

        /// <summary>Sweden</summary>
        [JsonPropertyName("se")]
        Sweden,

        /// <summary>Singapore</summary>
        [JsonPropertyName("sg")]
        Singapore,

        /// <summary>Thailand</summary>
        [JsonPropertyName("th")]
        Thailand,

        /// <summary>Taiwan</summary>
        [JsonPropertyName("tw")]
        Taiwan,

        /// <summary>United Kingdom</summary>
        [JsonPropertyName("uk")]
        UnitedKingdom,

        /// <summary>United States (Legacy Pattern)</summary>
        [JsonPropertyName("us-old")]
        UnitedStatesLegacy,

        /// <summary>United States</summary>
        [JsonPropertyName("us")]
        UnitedStates,

        /// <summary>Venezuela</summary>
        [JsonPropertyName("ve")]
        Venezuela,

        /// <summary>South Africa</summary>
        [JsonPropertyName("za")]
        SouthAfrica
    }
}