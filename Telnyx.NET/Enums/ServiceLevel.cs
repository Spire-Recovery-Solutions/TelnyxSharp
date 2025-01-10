using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the service levels available for Telnyx services.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ServiceLevel
    {
        /// <summary>
        /// Basic service level with standard features.
        /// </summary>
        [JsonPropertyName("basic")]
        Basic,

        /// <summary>
        /// Premium service level with advanced features and support.
        /// </summary>
        [JsonPropertyName("premium")]
        Premium
    }
}