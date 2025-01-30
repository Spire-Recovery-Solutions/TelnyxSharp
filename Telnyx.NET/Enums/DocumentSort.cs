using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the sort order for results.
    /// Specifies fields by which results can be sorted in ascending or descending order.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DocumentSort
    {
        /// <summary>
        /// Sort by filename in ascending order.
        /// </summary>
        [JsonPropertyName("filename")]
        FilenameAsc,

        /// <summary>
        /// Sort by filename in descending order.
        /// </summary>
        [JsonPropertyName("-filename")]
        FilenameDesc,

        /// <summary>
        /// Sort by creation date in ascending order.
        /// </summary>
        [JsonPropertyName("created_at")]
        CreatedAtAsc,

        /// <summary>
        /// Sort by creation date in descending order.
        /// </summary>
        [JsonPropertyName("-created_at")]
        CreatedAtDesc,

        /// <summary>
        /// Sort by update date in ascending order.
        /// </summary>
        [JsonPropertyName("updated_at")]
        UpdatedAtAsc,

        /// <summary>
        /// Sort by update date in descending order.
        /// </summary>
        [JsonPropertyName("-updated_at")]
        UpdatedAtDesc
    }
}
