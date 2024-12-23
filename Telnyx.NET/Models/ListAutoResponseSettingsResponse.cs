using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for listing auto-response settings in the Telnyx API.
    /// </summary>
    public class ListAutoResponseSettingsResponse : ITelnyxResponse
    { 
        /// <summary>
        /// A list of auto-response settings for a messaging profile.
        /// </summary>
        [JsonPropertyName("data")]
        public List<AutoResponseSetting>? Data { get; set; }

        /// <summary>
        /// Metadata related to the auto-response settings, including pagination info.
        /// </summary>
        [JsonPropertyName("meta")]
        public AutoResponseSettingsMeta? Meta { get; set; }

        /// <summary>
        /// Represents any errors encountered during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents an individual auto-response setting.
    /// </summary>
    public class AutoResponseSetting : BaseAutoResponseSetting
    {
        /// <summary>
        /// The unique identifier for the auto-response setting.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The date and time when the auto-response setting was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the auto-response setting was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents pagination and metadata for the list of auto-response settings.
    /// </summary>
    public class AutoResponseSettingsMeta
    {
        /// <summary>
        /// The current page number in the paginated result.
        /// </summary>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// The number of results per page in the paginated result.
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// The total number of pages available in the paginated result.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// The total number of results available in the paginated result.
        /// </summary>
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }
}