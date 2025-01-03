using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Telnyx API when a phone number is deleted.
    /// </summary>
    public class DeletePhoneNumberResponse : TelnyxResponse<PhoneNumberData>
    {
    }

    /// <summary>
    /// Represents the details of a phone number, including metadata about the phone number.
    /// </summary>
    public class PhoneNumberData
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
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the phone number in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the current status of the phone number.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of user-assigned tags for the phone number.
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the external PIN for porting the phone number, if any.
        /// </summary>
        [JsonPropertyName("external_pin")]
        public string? ExternalPin { get; set; }

        /// <summary>
        /// Gets or sets the user-assigned connection name associated with the phone number.
        /// </summary>
        [JsonPropertyName("connection_name")]
        public string ConnectionName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the identifier for the connection associated with the phone number.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string ConnectionId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the customer reference string associated with the phone number.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the messaging profile identifier for the phone number.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the name of the messaging profile associated with the phone number.
        /// </summary>
        [JsonPropertyName("messaging_profile_name")]
        public string? MessagingProfileName { get; set; }

        /// <summary>
        /// Gets or sets the billing group identifier associated with the phone number.
        /// </summary>
        [JsonPropertyName("billing_group_id")]
        public string BillingGroupId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether emergency services are enabled for the phone number.
        /// </summary>
        [JsonPropertyName("emergency_enabled")]
        public bool EmergencyEnabled { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the emergency address associated with the phone number.
        /// </summary>
        [JsonPropertyName("emergency_address_id")]
        public long EmergencyAddressId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether call forwarding is enabled for the phone number.
        /// </summary>
        [JsonPropertyName("call_forwarding_enabled")]
        public bool CallForwardingEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether CNAM listing is enabled for the phone number.
        /// </summary>
        [JsonPropertyName("cnam_listing_enabled")]
        public bool CnamListingEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether caller ID is enabled for the phone number.
        /// </summary>
        [JsonPropertyName("caller_id_name_enabled")]
        public bool CallerIdNameEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether call recording is enabled for the phone number.
        /// </summary>
        [JsonPropertyName("call_recording_enabled")]
        public bool CallRecordingEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether T38 Fax Gateway is enabled for inbound calls to the phone number.
        /// </summary>
        [JsonPropertyName("t38_fax_gateway_enabled")]
        public bool T38FaxGatewayEnabled { get; set; }

        /// <summary>
        /// Gets or sets the ISO 8601 formatted date indicating when the phone number was purchased.
        /// </summary>
        [JsonPropertyName("purchased_at")]
        public string PurchasedAt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ISO 8601 formatted date indicating when the phone number was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ISO 8601 formatted date indicating the last update timestamp for the phone number.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the routing configuration for the phone number. Currently only "disabled" is supported.
        /// </summary>
        [JsonPropertyName("number_level_routing")]
        public string NumberLevelRouting { get; set; } = "disabled"; // Deprecated value

        /// <summary>
        /// Gets or sets the type of the phone number (e.g., local, toll_free, mobile, etc.).
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string PhoneNumberType { get; set; } = string.Empty;
    }

}
