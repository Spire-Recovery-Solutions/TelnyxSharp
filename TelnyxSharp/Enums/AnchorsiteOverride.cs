using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing different anchor site overrides for the Telnyx service.
    /// This is used to specify the location override for the anchor site.
    /// </summary>
    [JsonConverter(typeof(AnchorsiteOverrideConverter))]
    public enum AnchorsiteOverride
    {
         /// <summary>
        /// Indicates a latency-based anchor site override.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Latency")]
        Latency,

        /// <summary>
        /// Specifies Chicago, IL as the anchor site override.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Chicago, IL")]
        Chicago,

        /// <summary>
        /// Specifies Ashburn, VA as the anchor site override.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("Ashburn, VA")]
        Ashburn,

        /// <summary>
        /// Specifies San Jose, CA as the anchor site override.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("San Jose, CA")]
        SanJose
    }
}