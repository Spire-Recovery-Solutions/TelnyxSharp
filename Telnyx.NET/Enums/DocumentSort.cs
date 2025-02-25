using System.Text.Json.Serialization;
using Telnyx.NET.Converters;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the sort order for results.
    /// Specifies fields by which results can be sorted in ascending or descending order.
    /// </summary>
    [JsonConverter(typeof(DocumentSortConverter))]
    public enum DocumentSort
    {
         /// <summary>
        /// Sort by filename in ascending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("filename")]
        FilenameAsc,

        /// <summary>
        /// Sort by filename in descending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("-filename")]
        FilenameDesc,

        /// <summary>
        /// Sort by creation date in ascending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("created_at")]
        CreatedAtAsc,

        /// <summary>
        /// Sort by creation date in descending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("-created_at")]
        CreatedAtDesc,

        /// <summary>
        /// Sort by update date in ascending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("updated_at")]
        UpdatedAtAsc,

        /// <summary>
        /// Sort by update date in descending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("-updated_at")]
        UpdatedAtDesc
    }
}
