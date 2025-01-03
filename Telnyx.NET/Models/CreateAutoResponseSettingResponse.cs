using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response after creating an auto-response setting in the Telnyx API.
    /// </summary>
    public class CreateAutoResponseSettingResponse : TelnyxResponse
    {
        /// <summary>
        /// Contains the details of the created auto-response setting.
        /// </summary>
        [JsonPropertyName("data")]
        public CreateAutoResponseSetting? Data { get; set; }

        /// <summary>
        /// Represents any errors encountered during the creation of the auto-response setting.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the details of an auto-response setting after it has been created.
    /// </summary>
    public class CreateAutoResponseSetting : BaseAutoResponseSetting
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