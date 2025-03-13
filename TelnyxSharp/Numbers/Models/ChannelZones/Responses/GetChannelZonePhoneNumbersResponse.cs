using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.ChannelZones.Responses
{
    /// <summary>
    /// Represents the response for retrieving phone numbers associated with a specific channel zone.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> with a list of <see cref="ChannelZonePhoneNumber"/> as the result type.
    /// </summary>
    public class GetChannelZonePhoneNumbersResponse : TelnyxResponse<List<ChannelZonePhoneNumber>>
    {
    }

    /// <summary>
    /// Represents a phone number associated with a channel zone.
    /// </summary>
    public class ChannelZonePhoneNumber
    {
        /// <summary>
        /// Gets or sets the record type, indicating the type of resource (e.g., "channel_zone_phone_number").
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ID of the channel zone this phone number is associated with.
        /// </summary>
        [JsonPropertyName("channel_zone_id")]
        public string? ChannelZoneId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier of this phone number record.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the phone number in E.164 format (e.g., +1234567890).
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the creation timestamp of the record.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
}