using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to verify porting verification codes for a list of phone numbers in the Telnyx system.
    /// </summary>
    public class VerifyCodesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of verification code entries that need to be verified.
        /// Each entry contains a phone number and the corresponding verification code.
        /// </summary>
        [JsonPropertyName("verification_codes")]
        public List<VerificationCodeEntry>? VerificationCodes { get; set; }
    }

    /// <summary>
    /// Represents an individual verification code entry, which includes the phone number and its associated verification code.
    /// </summary>
    public class VerificationCodeEntry
    {
        /// <summary>
        /// Gets or sets the phone number that requires verification.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the verification code associated with the phone number.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }
    }
}