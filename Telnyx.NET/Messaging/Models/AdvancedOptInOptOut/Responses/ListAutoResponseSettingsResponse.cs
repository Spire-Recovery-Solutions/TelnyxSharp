using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.AdvancedOptInOptOut.Responses
{
    /// <summary>
    /// Represents the response for listing auto-response settings in the Telnyx API.
    /// </summary>
    public class ListAutoResponseSettingsResponse : TelnyxResponse<List<AutoResponseSetting>>
    {
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