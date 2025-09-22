using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Specifies sorting options for voice-related data.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<SortVoice>))]
    public enum SortVoice
    {
        /// <summary>
        /// Sort by the creation date.
        /// </summary>
        [JsonStringEnumMemberName("created_at")]
        CreatedAt,

        /// <summary>
        /// Sort by the connection name.
        /// </summary>
        [JsonStringEnumMemberName("connection_name")]
        ConnectionName,

        /// <summary>
        /// Sort by the active status.
        /// </summary>
        [JsonStringEnumMemberName("active")]
        Active
    }
}