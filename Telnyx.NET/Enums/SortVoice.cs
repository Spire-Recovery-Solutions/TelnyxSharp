using System.Text.Json.Serialization;
using Telnyx.NET.Converters;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Specifies sorting options for voice-related data.
    /// </summary>
    [JsonConverter(typeof(SortVoiceConverter))]
    public enum SortVoice
    {
        /// <summary>
        /// Sort by the creation date.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("created_at")]
        CreatedAt,

        /// <summary>
        /// Sort by the connection name.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("connection_name")]
        ConnectionName,

        /// <summary>
        /// Sort by the active status.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("active")]
        Active
    }
}