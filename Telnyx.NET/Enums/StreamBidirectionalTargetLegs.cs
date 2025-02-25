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
       Both,

        /// <summary>
        /// The same leg of the stream, indicating communication on the same side.
        /// </summary>
        Self,

        /// <summary>
        /// The opposite leg of the stream, indicating communication on the opposite side.
        /// </summary>
        Opposite
    }
}