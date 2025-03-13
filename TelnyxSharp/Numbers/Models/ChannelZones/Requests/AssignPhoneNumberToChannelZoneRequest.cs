using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.ChannelZones.Requests
{
    /// <summary>
    /// Represents a request to assign a phone number to a specific channel zone.
    /// </summary>
    public class AssignPhoneNumberToChannelZoneRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the phone number to assign to the channel zone.
        /// This field is required and must be in E.164 format (e.g., +1234567890).
        /// </summary>
        [JsonPropertyName("phone_number")]
        public required string PhoneNumber { get; set; }
    }
}