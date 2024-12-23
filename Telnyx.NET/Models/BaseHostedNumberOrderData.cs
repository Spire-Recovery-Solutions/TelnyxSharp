using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the base data for a hosted number order, including identifiers, status, and associated phone numbers.
    /// </summary>
    public class BaseHostedNumberOrderData
    {
        /// <summary>
        /// Gets or sets the unique identifier for the hosted number order.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of record, typically used to differentiate between resource types.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the optional messaging profile ID associated with the hosted number order.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the current status of the hosted number order (e.g., pending, completed, etc.).
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of phone numbers associated with the hosted number order.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<HostedPhoneNumber> PhoneNumbers { get; set; } = new();
    }

     public class HostedPhoneNumber
    {
        /// <summary>
        /// The type of the resource.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// The unique identifier of the phone number.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// The phone number in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// The status of the phone number.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }
}