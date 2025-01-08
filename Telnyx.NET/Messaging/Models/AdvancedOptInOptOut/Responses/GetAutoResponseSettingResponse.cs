using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.AdvancedOptInOptOut.Responses
{
    /// <summary>
    /// Represents the response from the Telnyx API when retrieving an auto-response setting.
    /// </summary>
    public class GetAutoResponseSettingResponse : TelnyxResponse<GetAutoResponseSetting>
    {
    }

    /// <summary>
    /// Represents a single auto-response setting retrieved from the Telnyx API.
    /// </summary>
    public class GetAutoResponseSetting : BaseAutoResponseSetting
    {
        /// <summary>
        /// The unique identifier for the auto-response setting.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The timestamp when the auto-response setting was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the auto-response setting was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}