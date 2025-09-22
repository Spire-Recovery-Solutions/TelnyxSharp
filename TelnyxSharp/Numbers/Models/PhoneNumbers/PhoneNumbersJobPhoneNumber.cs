using System.Text.Json.Serialization;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers
{
    /// <summary>
    /// Represents a phone number in bulk operations/jobs context.
    /// Used for phone number jobs, bulk updates, and similar operations.
    /// </summary>
    public class PhoneNumbersJobPhoneNumber
    {
        /// <summary>
        /// The phone number's unique identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The phone number in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
    }
}