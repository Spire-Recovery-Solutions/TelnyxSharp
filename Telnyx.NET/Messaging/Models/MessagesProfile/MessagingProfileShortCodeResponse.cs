using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.MessagesProfile
{
    /// <summary>
    /// Represents the response containing a list of short codes associated with a messaging profile.
    /// </summary>
    public class MessagingProfileShortCodeResponse : TelnyxResponse<List<MessagingProfileShortCode>>
    {
    }

    /// <summary>
    /// Represents a short code associated with a messaging profile.
    /// </summary>
    public class MessagingProfileShortCode
    {
        /// <summary>
        /// Gets or sets the record type for the short code.
        /// </summary>
        [JsonPropertyName("record_type")]
        public MessageRecordType RecordType { get; set; } = MessageRecordType.Unknown;

        /// <summary>
        /// Gets or sets the unique identifier for the short code.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the short digit sequence used to address messages.
        /// </summary>
        [JsonPropertyName("short_code")]
        public string ShortCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ISO 3166-1 alpha-2 country code for the short code.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the messaging profile ID associated with the short code.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the short code was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the short code was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }



}
