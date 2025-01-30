using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Specifies sorting options for voice-related data.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortVoice
    {
        /// <summary>
        /// Sort by the creation date.
        /// </summary>
        [JsonPropertyName("created_at")]
        CreatedAt,

        /// <summary>
        /// Sort by the connection name.
        /// </summary>
        [JsonPropertyName("connection_name")]
        ConnectionName,

        /// <summary>
        /// Sort by the active status.
        /// </summary>
        [JsonPropertyName("active")]
        Active
    }
}