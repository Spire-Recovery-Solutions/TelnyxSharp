using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response containing a list of phone numbers with messaging settings.
    /// </summary>
    public class ListPhoneMessageSettingsResponse : TelnyxResponse
    {
        /// <summary>
        /// A collection of phone numbers with their associated messaging settings.
        /// </summary>
        [JsonPropertyName("data")]
        public List<PhoneNumberMessagingSettings>? Data { get; set; }

        /// <summary>
        /// Metadata information for the list of phone numbers, including pagination details.
        /// </summary>
        [JsonPropertyName("meta")]
        public PaginationMeta Meta { get; set; }

            /// <summary>
        /// Represents any errors encountered during the message sending process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the messaging settings for a specific phone number.
    /// </summary>
    public class PhoneNumberMessagingSettings
    {
        /// <summary>
        /// The type of record, usually a descriptor of the resource type.
        /// </summary>
        [JsonPropertyName("record_type")]
        public MessageRecordType RecordType { get; set; } = MessageRecordType.Unknown;

        /// <summary>
        /// The unique identifier for the phone number resource.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The phone number in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// The ID of the messaging profile associated with the phone number.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// The date and time when the phone number was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the phone number was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The country code associated with the phone number.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; } = string.Empty;

        /// <summary>
        /// The type of phone number, such as mobile, landline, or VoIP.
        /// </summary>
        [JsonPropertyName("type")]
        public MessageType Type { get; set; } = MessageType.Unknown;

        /// <summary>
        /// The health status of the phone number for messaging purposes.
        /// </summary>
        [JsonPropertyName("health")]
        public MessagingPhoneNumberHealth? Health { get; set; }

        /// <summary>
        /// A list of eligible messaging products for the phone number.
        /// </summary>
        [JsonPropertyName("eligible_messaging_products")]
        public List<string> EligibleMessagingProducts { get; set; } = new();

        /// <summary>
        /// The type of traffic supported by the phone number, such as A2P or P2P.
        /// </summary>
        [JsonPropertyName("traffic_type")]
        public string TrafficType { get; set; } = string.Empty;

        /// <summary>
        /// The messaging product associated with the phone number.
        /// </summary>
        [JsonPropertyName("messaging_product")]
        public string MessagingProduct { get; set; } = string.Empty;

        /// <summary>
        /// The features supported by the phone number for messaging.
        /// </summary>
        [JsonPropertyName("features")]
        public MessagingPhoneNumberFeatures? Features { get; set; }
    }

    
}