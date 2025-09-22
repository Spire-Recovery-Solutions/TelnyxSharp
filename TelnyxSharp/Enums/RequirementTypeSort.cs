using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Specifies the sorting criteria for requirement types in the Telnyx API.
    /// This enumeration defines how requirement type data should be ordered,
    /// allowing for ascending or descending sorting based on various attributes.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<RequirementTypeSort>))]
    public enum RequirementTypeSort
    {
        /// <summary>
        /// Sorts requirement types by creation date in ascending order.
        /// </summary>
        [JsonStringEnumMemberName("created_at")]
        CreatedAtAsc,

        /// <summary>
        /// Sorts requirement types by creation date in descending order.
        /// </summary>
        [JsonStringEnumMemberName("-created_at")]
        CreatedAtDesc,

        /// <summary>
        /// Sorts requirement types by name in ascending order.
        /// </summary>
        [JsonStringEnumMemberName("name")]
        NameAsc,

        /// <summary>
        /// Sorts requirement types by name in descending order.
        /// </summary>
        [JsonStringEnumMemberName("-name")]
        NameDesc,

        /// <summary>
        /// Sorts requirement types by the last updated date in ascending order.
        /// </summary>
        [JsonStringEnumMemberName("updated_at")]
        UpdatedAtAsc,

        /// <summary>
        /// Sorts requirement types by the last updated date in descending order.
        /// </summary>
        [JsonStringEnumMemberName("-updated_at")]
        UpdatedAtDesc
    }
}