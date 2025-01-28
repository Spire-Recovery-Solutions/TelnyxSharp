using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Specifies the sorting criteria for requirement types in the Telnyx API.
    /// This enumeration defines how requirement type data should be ordered,
    /// allowing for ascending or descending sorting based on various attributes.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RequirementTypeSort
    {
        /// <summary>
        /// Sorts requirement types by creation date in ascending order.
        /// </summary>
        [JsonPropertyName("created_at")]
        CreatedAtAsc,

        /// <summary>
        /// Sorts requirement types by creation date in descending order.
        /// </summary>
        [JsonPropertyName("-created_at")]
        CreatedAtDesc,

        /// <summary>
        /// Sorts requirement types by name in ascending order.
        /// </summary>
        [JsonPropertyName("name")]
        NameAsc,

        /// <summary>
        /// Sorts requirement types by name in descending order.
        /// </summary>
        [JsonPropertyName("-name")]
        NameDesc,

        /// <summary>
        /// Sorts requirement types by the last updated date in ascending order.
        /// </summary>
        [JsonPropertyName("updated_at")]
        UpdatedAtAsc,

        /// <summary>
        /// Sorts requirement types by the last updated date in descending order.
        /// </summary>
        [JsonPropertyName("-updated_at")]
        UpdatedAtDesc
    }
}