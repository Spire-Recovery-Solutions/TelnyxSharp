using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to send verification codes to one or more phone numbers.
    /// This class is used to initiate the verification process for porting orders.
    /// </summary>
    public class SendVerificationCodesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of phone numbers to which verification codes will be sent.
        /// This is a required parameter that must contain one or more phone numbers.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the method used for verification (e.g., SMS, email).
        /// This specifies how the verification code will be delivered.
        /// </summary>
        [JsonPropertyName("verification_method")]
        public string? VerificationMethod { get; set; }
    }
}