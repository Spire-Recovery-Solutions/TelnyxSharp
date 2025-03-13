using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.BulkPhoneNumberOperations
{
    /// <summary>
    /// Represents a request to update a batch of phone numbers with various settings and configurations.
    /// </summary>
    public class UpdateNumbersBatchRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of phone numbers to be updated in the batch.
        /// This is a required property.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public required List<string> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the tags to be assigned to the phone numbers.
        /// These are user-defined labels for organizing phone numbers.
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        /// <summary>
        /// Gets or sets the external PIN for port-out security.
        /// Used to verify the correct PIN when porting numbers to another carrier.
        /// </summary>
        [JsonPropertyName("external_pin")]
        public string? ExternalPin { get; set; }

        /// <summary>
        /// Gets or sets a custom reference string for customer lookups.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the connection ID associated with the phone numbers.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the billing group ID associated with the phone numbers.
        /// Can be used to group numbers for billing purposes.
        /// </summary>
        [JsonPropertyName("billing_group_id")]
        public string? BillingGroupId { get; set; }

        /// <summary>
        /// Gets or sets whether HD Voice should be enabled for the phone numbers.
        /// </summary>
        [JsonPropertyName("hd_voice_enabled")]
        public bool? HdVoiceEnabled { get; set; }

        /// <summary>
        /// Gets or sets the voice configuration settings for the phone numbers.
        /// </summary>
        [JsonPropertyName("voice")]
        public BatchVoiceSettings? Voice { get; set; }
    }

    /// <summary>
    /// Represents the voice settings that can be configured for a batch of phone numbers.
    /// </summary>
    public class BatchVoiceSettings
    {
        /// <summary>
        /// Gets or sets whether a technical prefix is enabled for the phone numbers.
        /// </summary>
        [JsonPropertyName("tech_prefix_enabled")]
        public bool? TechPrefixEnabled { get; set; }

        /// <summary>
        /// Gets or sets the translated destination number for inbound calls.
        /// This replaces the originally dialed number before routing.
        /// </summary>
        [JsonPropertyName("translated_number")]
        public string? TranslatedNumber { get; set; }

        /// <summary>
        /// Gets or sets whether Caller ID Name (CNAM) is enabled for the phone numbers.
        /// </summary>
        [JsonPropertyName("caller_id_name_enabled")]
        public bool? CallerIdNameEnabled { get; set; }

        /// <summary>
        /// Gets or sets the call forwarding settings for the phone numbers.
        /// </summary>
        [JsonPropertyName("call_forwarding")]
        public CallForwardingSettings? CallForwarding { get; set; }
    }
}