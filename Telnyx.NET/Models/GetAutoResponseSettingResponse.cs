using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Telnyx API when retrieving an auto-response setting.
    /// </summary>
    public class GetAutoResponseSettingResponse : ITelnyxResponse
    {
        /// <summary>
        /// The data for the retrieved auto-response setting.
        /// </summary>
        [JsonPropertyName("data")]
        public GetAutoResponseSetting? Data { get; set; }

        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
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