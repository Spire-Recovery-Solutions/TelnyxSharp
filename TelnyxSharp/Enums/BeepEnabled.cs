using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing the different settings for when a beep should be enabled in a conference call or communication system.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<BeepEnabled>))]
    public enum BeepEnabled
    {
        /// <summary>
        /// Beep will always be enabled during the call.
        /// </summary>
        [JsonStringEnumMemberName("always")]
        Always,

        /// <summary>
        /// Beep will never be enabled during the call.
        /// </summary>
        [JsonStringEnumMemberName("never")]
        Never,

        /// <summary>
        /// Beep will be enabled when participants enter the call.
        /// </summary>
        [JsonStringEnumMemberName("on_enter")]
        OnEnter,

        /// <summary>
        /// Beep will be enabled when participants exit the call.
        /// </summary>
        [JsonStringEnumMemberName("on_exit")]
        OnExit
    }
}