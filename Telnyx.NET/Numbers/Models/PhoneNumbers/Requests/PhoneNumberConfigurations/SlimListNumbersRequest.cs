using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations
{
    public class SlimListNumbersRequest : ITelnyxRequest
    {
        /// <summary>
        /// The size of the page.
        /// </summary>
        [JsonPropertyName("page[size]")]
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Include the connection associated with the phone number.
        /// </summary>
        [JsonPropertyName("include_connection")]
        public bool? IncludeConnection { get; set; }

        /// <summary>
        /// Include the tags associated with the phone number.
        /// </summary>
        [JsonPropertyName("include_tags")]
        public bool? IncludeTags { get; set; }

        /// <summary>
        /// Phone number tags to match.
        /// </summary>
        [JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Phone number to search for.
        /// Requires at least three digits. Non-numerical characters will result in no values being returned.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// The status of the phone number.
        /// </summary>
        [JsonPropertyName("status")]
        public PhoneNumberStatusType? Status { get; set; }

        /// <summary>
        /// Connection ID associated with the phone number.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public long? ConnectionId { get; set; }

        /// <summary>
        /// Search connection name for a given substring. Requires the include_connection parameter.
        /// </summary>
        [JsonPropertyName("voice.connection_name[contains]")]
        public string? ConnectionNameContains { get; set; }

        /// <summary>
        /// Search connection name that starts with the given string. Requires the include_connection parameter.
        /// </summary>
        [JsonPropertyName("voice.connection_name[starts_with]")]
        public string? ConnectionNameStartsWith { get; set; }

        /// <summary>
        /// Search connection name that ends with the given string. Requires the include_connection parameter.
        /// </summary>
        [JsonPropertyName("voice.connection_name[ends_with]")]
        public string? ConnectionNameEndsWith { get; set; }

        /// <summary>
        /// Exact connection name. Requires the include_connection parameter.
        /// </summary>
        [JsonPropertyName("voice.connection_name")]
        public string? ConnectionName { get; set; }

        /// <summary>
        /// Payment method for voice usage.
        /// </summary>
        [JsonPropertyName("voice.usage_payment_method")]
        public VoiceUsagePaymentMethod? UsagePaymentMethod { get; set; }

        /// <summary>
        /// Billing group ID associated with the phone numbers.
        /// </summary>
        [JsonPropertyName("billing_group_id")]
        public string? BillingGroupId { get; set; }

        /// <summary>
        /// Emergency address ID associated with the phone numbers.
        /// </summary>
        [JsonPropertyName("emergency_address_id")]
        public long? EmergencyAddressId { get; set; }

        /// <summary>
        /// Customer reference associated with the phone numbers.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Phone number type (e.g., local, mobile, toll-free).
        /// </summary>
        [JsonPropertyName("number_type")]
        public PhoneNumberType? NumberType { get; set; }

        /// <summary>
        /// The sort order for the results.
        /// </summary>;v
        [JsonPropertyName("sort")]
        public SortNumberConfiguration? Sort { get; set; }
    }
}
