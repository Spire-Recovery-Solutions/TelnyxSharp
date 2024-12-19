using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    using System;
    using System.Collections.Generic;
    

    public class CreateNumberOrderResponse : ITelnyxResponse
    {
        [JsonPropertyName("data")]
        public CreateNumberOrderResponseData Data { get; set; }
    }

    public class CreateNumberOrderResponseData
    {
        [JsonPropertyName("phone_numbers_count")]
        public long PhoneNumbersCount { get; set; }

        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("billing_group_id")]
        public string? BillingGroupId { get; set; }

        [JsonPropertyName("phone_numbers")]
        public List<CreateNumberOrderResponsePhoneNumber> PhoneNumbers { get; set; }

        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }

    public class CreateNumberOrderResponsePhoneNumber
    {
        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        [JsonPropertyName("regulatory_requirements")]
        public List<CreateNumberOrderRegulatoryRequirement> RegulatoryRequirements { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("requirements_status")]
        public string? RequirementsStatus { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        [JsonPropertyName("phone_number")]
        public string? PhoneNumberPhoneNumber { get; set; }

        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }
}
