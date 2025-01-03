using System.Text.Json.Serialization;

using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    using System.Collections.Generic;
    

    public class CreateNumberOrderRequest : ITelnyxRequest
    {
        [JsonPropertyName("phone_numbers")]
        public List<CreateNumberOrderPhoneNumber> PhoneNumbers { get; set; } = new List<CreateNumberOrderPhoneNumber>();

        [JsonPropertyName("connection_id")]
        public string?  ConnectionId { get; set; }

        [JsonPropertyName("messaging_profile_id")]
        public string?  MessagingProfileId { get; set; }
        
        [JsonPropertyName("billing_group_id")]
        public string?  BillingGroupId { get; set; }
        
        [JsonPropertyName("customer_reference")]
        public string?  CustomerReference { get; set; }
    }

    public class CreateNumberOrderPhoneNumber
    {
        [JsonPropertyName("phone_number")]
        public required string PhoneNumber { get; set; }

        [JsonPropertyName("regulatory_requirements")]
        public List<CreateNumberOrderRegulatoryRequirement> RegulatoryRequirements { get; set; }
    }
}
