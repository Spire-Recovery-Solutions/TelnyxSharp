using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for retrieving a verification code for a phone number.
    /// Inherits from <see cref="TelnyxResponse{T}"/> where T is a <see cref="VerificationCode"/>.
    /// </summary>
    public class ListVerificationCodesResponse : TelnyxResponse<VerificationCode>
    {
    }

    /// <summary>
    /// Represents a verification code for a phone number.
    /// Contains details such as the phone number, verification status, and timestamps.
    /// </summary>
    public class VerificationCode
    {
        /// <summary>
        /// Gets or sets the unique identifier for the verification code.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the phone number associated with the verification code.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the verification code has been verified.
        /// </summary>
        [JsonPropertyName("verified")]
        public bool? Verified { get; set; }

        /// <summary>
        /// Gets or sets the ID of the porting order associated with the verification code.
        /// </summary>
        [JsonPropertyName("porting_order_id")]
        public string? PortingOrderId { get; set; }

        /// <summary>
        /// Gets or sets the type of record associated with the verification code.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the verification code was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the verification code was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}