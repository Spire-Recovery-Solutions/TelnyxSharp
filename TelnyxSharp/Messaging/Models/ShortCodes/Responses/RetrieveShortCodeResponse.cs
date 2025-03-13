using System.Text.Json.Serialization;
using TelnyxSharp.Enums;
using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.ShortCodes.Responses
{
    /// <summary>
    /// Represents the response for retrieving a specific short code.
    /// </summary>
    public class RetrieveShortCodeResponse : TelnyxResponse<ShortCodeDetail>
    {
    }

    /// <summary>
    /// Contains detailed information about a short code.
    /// </summary>
    public class ShortCodeDetail
    {
        /// <summary>
        /// The type of the resource, which is always "short_code".
        /// </summary>
        [JsonPropertyName("record_type")]
        public MessageRecordType RecordType { get; set; } = MessageRecordType.Unknown;

        /// <summary>
        /// The unique identifier of the short code.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The short digit sequence used to address messages (e.g., a 5- or 6-digit number).
        /// </summary>
        [JsonPropertyName("short_code")]
        public string ShortCode { get; set; } = string.Empty;

        /// <summary>
        /// The ISO 3166-1 alpha-2 country code associated with the short code.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier of the messaging profile associated with this short code.
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
