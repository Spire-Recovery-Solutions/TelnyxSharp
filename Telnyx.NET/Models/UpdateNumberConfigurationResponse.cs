using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    using System;
    using System.Collections.Generic;
    

    public partial class UpdateNumberConfigurationResponse : TelnyxResponse<UpdateNumberConfigurationResponseData>
    {
    }

    public class UpdateNumberConfigurationResponseData
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; }

        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        [JsonPropertyName("connection_name")]
        public string? ConnectionName { get; set; }

        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        [JsonPropertyName("external_pin")]
        public string? ExternalPin { get; set; }

        [JsonPropertyName("t38_fax_gateway_enabled")]
        public bool?  T38FaxGatewayEnabled { get; set; }

        [JsonPropertyName("purchased_at")]
        public DateTimeOffset? PurchasedAt { get; set; }

        [JsonPropertyName("billing_group_id")]
        public string? BillingGroupId { get; set; }

        [JsonPropertyName("emergency_enabled")]
        public bool?  EmergencyEnabled { get; set; }

        [JsonPropertyName("emergency_address_id")]
        public string? EmergencyAddressId { get; set; }

        [JsonPropertyName("emergency_status")]
        public string? EmergencyStatus { get; set; }

        [JsonPropertyName("call_forwarding_enabled")]
        public bool? CallForwardingEnabled { get; set; }

        [JsonPropertyName("cnam_listing_enabled")]
        public bool? CnamListingEnabled { get; set; }

        [JsonPropertyName("call_recording_enabled")]
        public bool? CallRecordingEnabled { get; set; }

        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        [JsonPropertyName("messaging_profile_name")]
        public string? MessagingProfileName { get; set; }

        [JsonPropertyName("number_block_id")]
        public string? NumberBlockId { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
