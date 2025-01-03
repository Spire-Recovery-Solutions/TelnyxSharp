using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    using System;
    using System.Collections.Generic;
    

    public partial class CreateNumberReservationResponse : TelnyxResponse
    {
        [JsonPropertyName("data")]
        public CreateNumberReservationResponseData Data { get; set; }
    }

    public partial class CreateNumberReservationResponseData
    {
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }   

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("phone_numbers")]
        public List<CreateNumberReservationResponsePhoneNumber> PhoneNumbers { get; set; }

        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }

    public partial class CreateNumberReservationResponsePhoneNumber
    {
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonPropertyName("phone_number")]
        public string? PhoneNumberPhoneNumber { get; set; }

        [JsonPropertyName("errors")]
        public string? Errors { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("expired")]
        public bool? Expired { get; set; }

        [JsonPropertyName("expired_at")]
        public DateTimeOffset? ExpiredAt { get; set; }

        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }
}