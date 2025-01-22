using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the different types of phone number jobs that can be performed in the Telnyx API.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhoneNumberJobType
    {
        /// <summary>
        /// Updates the emergency settings for a batch of phone numbers.
        /// </summary>
        [JsonPropertyName("update_emergency_settings")]
        UpdateEmergencySettings,

        /// <summary>
        /// Deletes a batch of phone numbers.
        /// </summary>
        [JsonPropertyName("delete_phone_numbers")]
        DeletePhoneNumbers,

        /// <summary>
        /// Updates a batch of phone numbers.
        /// </summary>
        [JsonPropertyName("update_phone_numbers")]
        UpdatePhoneNumbers
    }
}