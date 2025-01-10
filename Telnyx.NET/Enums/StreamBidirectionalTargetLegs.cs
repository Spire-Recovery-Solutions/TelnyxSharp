using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the target legs for bidirectional stream communication.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StreamBidirectionalTargetLegs
    {
        /// <summary>
        /// Both legs of the stream, indicating communication in both directions.
        /// </summary>
        [JsonPropertyName("both")]
        Both,

        /// <summary>
        /// The same leg of the stream, indicating communication on the same side.
        /// </summary>
        [JsonPropertyName("self")]
        Self,

        /// <summary>
        /// The opposite leg of the stream, indicating communication on the opposite side.
        /// </summary>
        [JsonPropertyName("opposite")]
        Opposite
    }
}