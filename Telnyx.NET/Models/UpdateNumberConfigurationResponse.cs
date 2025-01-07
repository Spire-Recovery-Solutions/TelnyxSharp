using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Response model for updating number configuration.
    /// This class contains the updated configuration details of a phone number.
    /// </summary>
    public partial class UpdateNumberConfigurationResponse : TelnyxResponse<UpdateNumberConfigurationResponseData>
    {
    }

    /// <summary>
    /// Data model containing the updated configuration details of a phone number.
    /// </summary>
    public class UpdateNumberConfigurationResponseData
    {
        /// <summary>
        /// Gets or sets the unique identifier for the updated configuration.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the record type of the phone number (e.g., type of configuration).
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the phone number being updated.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the status of the phone number (e.g., active, suspended).
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the list of tags associated with the phone number.
        /// </summary>
        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; }

        /// <summary>
        /// Gets or sets the connection ID associated with the phone number.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the name of the connection associated with the phone number.
        /// </summary>
        [JsonPropertyName("connection_name")]
        public string? ConnectionName { get; set; }

        /// <summary>
        /// Gets or sets the customer reference associated with the phone number.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the external pin associated with the phone number.
        /// </summary>
        [JsonPropertyName("external_pin")]
        public string? ExternalPin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether T38 fax gateway is enabled for the phone number.
        /// </summary>
        [JsonPropertyName("t38_fax_gateway_enabled")]
        public bool? T38FaxGatewayEnabled { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the phone number was purchased.
        /// </summary>
        [JsonPropertyName("purchased_at")]
        public DateTimeOffset? PurchasedAt { get; set; }

        /// <summary>
        /// Gets or sets the billing group ID associated with the phone number.
        /// </summary>
        [JsonPropertyName("billing_group_id")]
        public string? BillingGroupId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether emergency services are enabled for the phone number.
        /// </summary>
        [JsonPropertyName("emergency_enabled")]
        public bool? EmergencyEnabled { get; set; }

        /// <summary>
        /// Gets or sets the emergency address ID associated with the phone number.
        /// </summary>
        [JsonPropertyName("emergency_address_id")]
        public string? EmergencyAddressId { get; set; }

        /// <summary>
        /// Gets or sets the emergency status for the phone number.
        /// </summary>
        [JsonPropertyName("emergency_status")]
        public string? EmergencyStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether call forwarding is enabled for the phone number.
        /// </summary>
        [JsonPropertyName("call_forwarding_enabled")]
        public bool? CallForwardingEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether CNAM (Caller ID) listing is enabled for the phone number.
        /// </summary>
        [JsonPropertyName("cnam_listing_enabled")]
        public bool? CnamListingEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether call recording is enabled for the phone number.
        /// </summary>
        [JsonPropertyName("call_recording_enabled")]
        public bool? CallRecordingEnabled { get; set; }

        /// <summary>
        /// Gets or sets the type of phone number (e.g., mobile, landline).
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the messaging profile ID associated with the phone number.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the name of the messaging profile associated with the phone number.
        /// </summary>
        [JsonPropertyName("messaging_profile_name")]
        public string? MessagingProfileName { get; set; }

        /// <summary>
        /// Gets or sets the number block ID associated with the phone number.
        /// </summary>
        [JsonPropertyName("number_block_id")]
        public string? NumberBlockId { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the phone number was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the phone number was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}