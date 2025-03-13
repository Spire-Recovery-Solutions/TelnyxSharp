using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.ShortCodes.Responses
{
    /// <summary>
    /// Represents the response received after updating a short code.
    /// </summary>
    public class UpdateShortCodeResponse : TelnyxResponse
    {
        /// <summary>
        /// The resource type identifier.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier for the short code.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The short digit sequence used to address messages.
        /// </summary>
        [JsonPropertyName("short_code")]
        public string ShortCodeValue { get; set; } = string.Empty;

        /// <summary>
        /// The ISO 3166-1 alpha-2 country code.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier for the messaging profile.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// The date and time when the short code was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the short code was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

}
