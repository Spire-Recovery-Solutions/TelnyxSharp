using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response containing a list of phone numbers associated with a messaging profile.
    /// </summary>
    public class MessagingProfilePhoneNumberResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the list of phone numbers associated with the messaging profile.
        /// </summary>
        [JsonPropertyName("data")]
        public List<MessagingProfilePhoneNumberData>? Data { get; set; }

        /// <summary>
        /// Gets or sets metadata about the response, such as pagination information.
        /// </summary>
        [JsonPropertyName("meta")]
        public MessagingProfilePhoneNumberMeta? Meta { get; set; }
        
        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// This property is nullable to indicate that it may not always be present.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents a phone number associated with a messaging profile.
    /// </summary>
    public class MessagingProfilePhoneNumberData
    {
        /// <summary>
        /// Gets or sets the record type for the phone number.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the phone number.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the phone number in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the messaging profile ID associated with the phone number.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the phone number was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the phone number was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the country code for the phone number.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of phone number (e.g., mobile, landline).
        /// </summary>
        [JsonPropertyName("type")]
        public MessageType Type { get; set; } = MessageType.Unknown;

        /// <summary>
        /// Gets or sets the health statistics for the phone number.
        /// </summary>
        [JsonPropertyName("health")]
        public MessagingPhoneNumberHealth? Health { get; set; }

        /// <summary>
        /// Gets or sets the list of eligible messaging products for the phone number.
        /// </summary>
        [JsonPropertyName("eligible_messaging_products")]
        public List<string> EligibleMessagingProducts { get; set; } = new();

        /// <summary>
        /// Gets or sets the traffic type for the phone number (e.g., transactional, promotional).
        /// </summary>
        [JsonPropertyName("traffic_type")]
        public string TrafficType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the messaging product associated with the phone number.
        /// </summary>
        [JsonPropertyName("messaging_product")]
        public string MessagingProduct { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the features available for the phone number, such as SMS or MMS.
        /// </summary>
        [JsonPropertyName("features")]
        public MessagingPhoneNumberFeatures? Features { get; set; }
    }

    /// <summary>
    /// Represents health metrics for a phone number, such as message count and success ratio.
    /// </summary>
    public class MessagingPhoneNumberHealth
    {
        /// <summary>
        /// Gets or sets the total number of messages sent from the phone number.
        /// </summary>
        [JsonPropertyName("message_count")]
        public int MessageCount { get; set; }

        /// <summary>
        /// Gets or sets the ratio of inbound to outbound messages.
        /// </summary>
        [JsonPropertyName("inbound_outbound_ratio")]
        public float InboundOutboundRatio { get; set; }

        /// <summary>
        /// Gets or sets the success ratio of messages sent from the phone number.
        /// </summary>
        [JsonPropertyName("success_ratio")]
        public float SuccessRatio { get; set; }

        /// <summary>
        /// Gets or sets the spam ratio of messages sent from the phone number.
        /// </summary>
        [JsonPropertyName("spam_ratio")]
        public float SpamRatio { get; set; }
    }

    /// <summary>
    /// Represents the features available for a phone number, such as SMS or MMS capabilities.
    /// </summary>
    public class MessagingPhoneNumberFeatures
    {
        /// <summary>
        /// Gets or sets the SMS capabilities of the phone number.
        /// </summary>
        [JsonPropertyName("sms")]
        public MessagingFeature? Sms { get; set; }

        /// <summary>
        /// Gets or sets the MMS capabilities of the phone number.
        /// </summary>
        [JsonPropertyName("mms")]
        public MessagingFeature? Mms { get; set; }
    }

    /// <summary>
    /// Represents specific messaging features, such as two-way domestic and international support.
    /// </summary>
    public class MessagingFeature
    {
        /// <summary>
        /// Gets or sets a value indicating whether domestic two-way messaging is supported.
        /// </summary>
        [JsonPropertyName("domestic_two_way")]
        public bool DomesticTwoWay { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether international inbound messaging is supported.
        /// </summary>
        [JsonPropertyName("international_inbound")]
        public bool InternationalInbound { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether international outbound messaging is supported.
        /// </summary>
        [JsonPropertyName("international_outbound")]
        public bool InternationalOutbound { get; set; }
    }

    /// <summary>
    /// Represents metadata about the messaging profile phone number response, such as pagination details.
    /// </summary>
    public class MessagingProfilePhoneNumberMeta
    {
        /// <summary>
        /// Gets or sets the total number of pages available in the response.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or sets the total number of results available.
        /// </summary>
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        /// <summary>
        /// Gets or sets the current page number in the response.
        /// </summary>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the size of the page (number of items per page).
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
    }
}