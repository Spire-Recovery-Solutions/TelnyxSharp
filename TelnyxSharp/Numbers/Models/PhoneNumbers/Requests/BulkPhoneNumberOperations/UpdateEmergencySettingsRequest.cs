using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.BulkPhoneNumberOperations
{
    public class UpdateEmergencySettingsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Indicates whether to enable or disable emergency services for the phone numbers.
        /// </summary>
        [JsonPropertyName("emergency_enabled")]
        public required bool EmergencyEnabled { get; set; }

        /// <summary>
        /// The ID of the address to be used with emergency services.
        /// </summary>
        [JsonPropertyName("emergency_address_id")]
        public required long EmergencyAddressId { get; set; }

        /// <summary>
        /// A list of phone numbers to update emergency settings for, in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public required List<string> PhoneNumbers { get; set; }
    }
}
