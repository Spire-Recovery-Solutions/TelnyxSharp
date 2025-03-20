using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
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
        [JsonStringEnumMemberName("update_emergency_settings")]
        UpdateEmergencySettings,

        /// <summary>
        /// Deletes a batch of phone numbers.
        /// </summary>
        [JsonStringEnumMemberName("delete_phone_numbers")]
        DeletePhoneNumbers,

        /// <summary>
        /// Updates a batch of phone numbers.
        /// </summary>
        [JsonStringEnumMemberName("update_phone_numbers")]
        UpdatePhoneNumbers
    }
}