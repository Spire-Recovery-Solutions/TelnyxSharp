using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations
{
    /// <summary>
    /// Represents a response containing a slim list of phone numbers and their configurations.
    /// </summary>
    public class SlimListNumbersResponse : TelnyxResponse<List<SlimListNumbersData>>
    {
    }

    /// <summary>
    /// Represents the data for a phone number with its associated configurations in a slim response format.
    /// </summary>
    public class SlimListNumbersData
    {
        /// <summary>
        /// Unique identifier for the phone number configuration.
        /// </summary>
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The type of record (e.g., "phone_number").
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? Number { get; set; }

        /// <summary>
        /// The current status of the phone number (e.g., "active").
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// External PIN associated with the phone number.
        /// </summary>
        [JsonPropertyName("external_pin")]
        public string? ExternalPin { get; set; }

        /// <summary>
        /// Identifier for the associated connection.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Optional reference for the customer.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Identifier for the associated billing group.
        /// </summary>
        [JsonPropertyName("billing_group_id")]
        public string? BillingGroupId { get; set; }

        /// <summary>
        /// Indicates whether emergency services are enabled.
        /// </summary>
        [JsonPropertyName("emergency_enabled")]
        public bool? EmergencyEnabled { get; set; }

        /// <summary>
        /// Identifier for the emergency address associated with the phone number.
        /// </summary>
        [JsonPropertyName("emergency_address_id")]
        public long? EmergencyAddressId { get; set; }

        /// <summary>
        /// Status of emergency services (e.g., "active").
        /// </summary>
        [JsonPropertyName("emergency_status")]
        public string? EmergencyStatus { get; set; }

        /// <summary>
        /// Indicates whether call forwarding is enabled.
        /// </summary>
        [JsonPropertyName("call_forwarding_enabled")]
        public bool? CallForwardingEnabled { get; set; }

        /// <summary>
        /// Indicates whether CNAM (Caller Name) listing is enabled.
        /// </summary>
        [JsonPropertyName("cnam_listing_enabled")]
        public bool? CnamListingEnabled { get; set; }

        /// <summary>
        /// Indicates whether Caller ID name is enabled.
        /// </summary>
        [JsonPropertyName("caller_id_name_enabled")]
        public bool? CallerIdNameEnabled { get; set; }

        /// <summary>
        /// Indicates whether call recording is enabled.
        /// </summary>
        [JsonPropertyName("call_recording_enabled")]
        public bool? CallRecordingEnabled { get; set; }

        /// <summary>
        /// Indicates whether the T38 fax gateway is enabled.
        /// </summary>
        [JsonPropertyName("t38_fax_gateway_enabled")]
        public bool? T38FaxGatewayEnabled { get; set; }

        /// <summary>
        /// The date and time when the phone number was purchased.
        /// </summary>
        [JsonPropertyName("purchased_at")]
        public DateTimeOffset? PurchasedAt { get; set; }

        /// <summary>
        /// The date and time when the phone number configuration was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The type of the phone number (e.g., "local", "toll_free").
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Settings for inbound call screening.
        /// </summary>
        [JsonPropertyName("inbound_call_screening")]
        public string? InboundCallScreening { get; set; }
    }
}