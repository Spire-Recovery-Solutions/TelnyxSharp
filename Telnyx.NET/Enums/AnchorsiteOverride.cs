using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing different anchor site overrides for the Telnyx service.
    /// This is used to specify the location override for the anchor site.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AnchorsiteOverride
    {
        /// <summary>
        /// Indicates a latency-based anchor site override.
        /// </summary>
        [JsonPropertyName("Latency")]
        Latency,

        /// <summary>
        /// Specifies Chicago, IL as the anchor site override.
        /// </summary>
        [JsonPropertyName("Chicago, IL")]
        Chicago,

        /// <summary>
        /// Specifies Ashburn, VA as the anchor site override.
        /// </summary>
        [JsonPropertyName("Ashburn, VA")]
        Ashburn,

        /// <summary>
        /// Specifies San Jose, CA as the anchor site override.
        /// </summary>
        [JsonPropertyName("San Jose, CA")]
        SanJose
    }
}