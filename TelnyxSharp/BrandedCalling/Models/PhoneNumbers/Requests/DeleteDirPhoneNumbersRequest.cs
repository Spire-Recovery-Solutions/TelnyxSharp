using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.PhoneNumbers.Requests
{
    /// <summary>
    /// Represents a request to bulk-delete phone numbers from a Display Identity Record (DIR).
    /// </summary>
    public class DeleteDirPhoneNumbersRequest : ITelnyxRequest
    {
        /// <summary>
        /// 1-15 phone numbers in E.164 format to remove from the DIR. Required.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<string>? PhoneNumbers { get; set; }
    }
}
