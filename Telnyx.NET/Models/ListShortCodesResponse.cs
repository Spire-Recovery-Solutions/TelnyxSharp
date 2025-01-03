using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for a request to list short codes.
    /// </summary>
    public class ListShortCodesResponse : TelnyxResponse<List<ShortCode>>
    {
    }

    /// <summary>
    /// Represents a single short code.
    /// </summary>
    public class ShortCode
    {
        /// <summary>
        /// The type of the resource record.
        /// </summary>
        [JsonPropertyName("record_type")]
        public MessageRecordType RecordType { get; set; } = MessageRecordType.Unknown;

        /// <summary>
        /// The unique identifier of the short code.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The short code value (e.g., a 5- or 6-digit number).
        /// </summary>
        [JsonPropertyName("short_code")]
        public string ShortCodeValue { get; set; } = string.Empty;

        /// <summary>
        /// The country code associated with the short code.
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
