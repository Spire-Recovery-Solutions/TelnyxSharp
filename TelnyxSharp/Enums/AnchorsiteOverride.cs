using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Enum representing different anchor site overrides for the Telnyx service.
    /// This is used to specify the location override for the anchor site.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<AnchorsiteOverride>))]
    public enum AnchorsiteOverride
    {
        /// <summary>
        /// Indicates a latency-based anchor site override.
        /// </summary>
        [JsonStringEnumMemberName("Latency")]
        Latency,

        /// <summary>
        /// Specifies Chicago, IL as the anchor site override.
        /// </summary>
        [JsonStringEnumMemberName("Chicago, IL")]
        Chicago,

        /// <summary>
        /// Specifies Ashburn, VA as the anchor site override.
        /// </summary>
        [JsonStringEnumMemberName("Ashburn, VA")]
        Ashburn,

        /// <summary>
        /// Specifies San Jose, CA as the anchor site override.
        /// </summary>
        [JsonStringEnumMemberName("San Jose, CA")]
        SanJose
    }
}