using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberReservations
{
    /// <summary>
    /// Represents a request to create a number reservation in the Telnyx API.
    /// Contains customer reference and a list of phone numbers for reservation.
    /// </summary>
    public class CreateNumberReservationRequest : ITelnyxRequest
    {
        /// <summary>
        /// Optional reference provided by the customer for tracking purposes.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// List of phone numbers to be reserved.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<CreateNumberReservationPhoneNumber> PhoneNumbers { get; set; }
    }

    /// <summary>
    /// Represents a phone number to be reserved.
    /// Contains the actual phone number in E.164 format.
    /// </summary>
    public class CreateNumberReservationPhoneNumber
    {
        /// <summary>
        /// The phone number to be reserved, in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
    }
}