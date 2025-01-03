using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for listing auto-response settings in the Telnyx API.
    /// </summary>
    public class ListAutoResponseSettingsResponse : TelnyxResponse
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
        public PaginationMeta? Meta { get; set; }

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

  
}