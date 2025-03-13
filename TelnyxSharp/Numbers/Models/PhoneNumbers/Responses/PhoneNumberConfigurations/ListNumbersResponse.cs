using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations
{
    /// <summary>
    /// Response model for listing phone numbers.
    /// Contains a list of phone numbers and associated metadata.
    /// </summary>
    public class ListNumbersResponse : TelnyxResponse<List<NumberConfigurationData>>
    {
    }

    /// <summary>
    /// Represents a single phone number in the list of phone numbers.
    /// Includes details such as the phone number status, tags, emergency settings, and other metadata.
    /// </summary>
    public partial class NumberConfigurationData
    {
        /// <summary>
        /// Gets or sets the unique identifier for the phone number.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the type of record associated with the phone number.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the +E.164-formatted phone number.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the current status of the phone number.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the list of user-assigned tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        /// <summary>
        /// Gets or sets the external PIN for porting security.
        /// </summary>
        [JsonPropertyName("external_pin")]
        public string? ExternalPin { get; set; }

        /// <summary>
        /// Gets or sets the name of the connection associated with the phone number.
        /// </summary>
        [JsonPropertyName("connection_name")]
        public string? ConnectionName { get; set; }

        /// <summary>
        /// Gets or sets the connection ID associated with the phone number.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the customer reference for lookups.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the messaging profile ID.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the messaging profile name.
        /// </summary>
        [JsonPropertyName("messaging_profile_name")]
        public string? MessagingProfileName { get; set; }

        /// <summary>
        /// Gets or sets the billing group ID.
        /// </summary>
        [JsonPropertyName("billing_group_id")]
        public string? BillingGroupId { get; set; }

        /// <summary>
        /// Gets or sets whether emergency services are enabled.
        /// </summary>
        [JsonPropertyName("emergency_enabled")]
        public bool? EmergencyEnabled { get; set; }

        /// <summary>
        /// Gets or sets the emergency address ID.
        /// </summary>
        [JsonPropertyName("emergency_address_id")]
        public long? EmergencyAddressId { get; set; }

        /// <summary>
        /// Gets or sets the status of emergency service provisioning.
        /// </summary>
        [JsonPropertyName("emergency_status")]
        public string? EmergencyStatus { get; set; }

        /// <summary>
        /// Gets or sets whether call forwarding is enabled.
        /// </summary>
        [JsonPropertyName("call_forwarding_enabled")]
        public bool? CallForwardingEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets whether CNAM listing is enabled.
        /// </summary>
        [JsonPropertyName("cnam_listing_enabled")]
        public bool? CnamListingEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether caller ID is enabled.
        /// </summary>
        [JsonPropertyName("caller_id_name_enabled")]
        public bool? CallerIdNameEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether call recording is enabled.
        /// </summary>
        [JsonPropertyName("call_recording_enabled")]
        public bool? CallRecordingEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether T38 Fax Gateway is enabled.
        /// </summary>
        [JsonPropertyName("t38_fax_gateway_enabled")]
        public bool? T38FaxGatewayEnabled { get; set; }

        /// <summary>
        /// Gets or sets the purchase date of the phone number.
        /// </summary>
        [JsonPropertyName("purchased_at")]
        public DateTimeOffset? PurchasedAt { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the phone number.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the type of phone number.
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the inbound call screening setting.
        /// </summary>
        [JsonPropertyName("inbound_call_screening")]
        public string? InboundCallScreening { get; set; }
    }
}