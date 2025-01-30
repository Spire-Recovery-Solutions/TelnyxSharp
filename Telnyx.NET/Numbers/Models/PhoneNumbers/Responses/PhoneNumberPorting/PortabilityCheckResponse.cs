using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberPorting
{
    /// <summary>
    /// Represents the response returned when performing a portability check on a phone number.
    /// Inherits from TelnyxResponse to encapsulate the list of portability check results.
    /// </summary>
    public class PortabilityCheckResponse : TelnyxResponse<List<PortabilityCheckResult>>
    {
    }

    /// <summary>
    /// Represents the result of a portability check for a single phone number.
    /// Contains details about whether the number is portable, reasons if it's not portable, and other relevant information.
    /// </summary>
    public class PortabilityCheckResult
    {
        /// <summary>
        /// Gets or sets the type of record associated with the portability check.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the phone number is fast portable.
        /// </summary>
        [JsonPropertyName("fast_portable")]
        public bool? FastPortable { get; set; }

        /// <summary>
        /// Gets or sets the reason why the phone number is not portable, if applicable.
        /// </summary>
        [JsonPropertyName("not_portable_reason")]
        public string? NotPortableReason { get; set; }

        /// <summary>
        /// Gets or sets the phone number that was checked for portability.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the phone number is portable.
        /// </summary>
        [JsonPropertyName("portable")]
        public bool? Portable { get; set; }
    }
}
