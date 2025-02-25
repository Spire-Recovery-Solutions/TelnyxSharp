using System.Text.Json.Serialization;
using Telnyx.NET.Converters;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the different settings for when a beep should be enabled in a conference call or communication system.
    /// </summary>
    [JsonConverter(typeof(BeepEnabledConverter))]
    public enum BeepEnabled
    {
        /// <summary>
        /// Beep will always be enabled during the call.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("always")]
        Always,

        /// <summary>
        /// Beep will never be enabled during the call.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("never")]
        Never,

        /// <summary>
        /// Beep will be enabled when participants enter the call.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("on_enter")]
        OnEnter,

        /// <summary>
        /// Beep will be enabled when participants exit the call.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("on_exit")]
        OnExit
    }
}