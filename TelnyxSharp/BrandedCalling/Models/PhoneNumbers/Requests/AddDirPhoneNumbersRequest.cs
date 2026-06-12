using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.PhoneNumbers.Requests
{
    /// <summary>
    /// Represents a request to bulk-add phone numbers to a Display Identity Record (DIR).
    /// All numbers in the request are vetted together as a single batch; if any number fails,
    /// the entire request is rejected.
    /// </summary>
    public class AddDirPhoneNumbersRequest : ITelnyxRequest
    {
        /// <summary>
        /// 1-15 phone numbers in E.164 format. 10-digit US numbers are auto-prefixed with "1". Required.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Supporting documents covering this batch (1-20). At least one entry with document type
        /// "letter_of_authorization" is required — the LOA authorises Telnyx to register these
        /// numbers under the DIR. Required.
        /// </summary>
        [JsonPropertyName("documents")]
        public List<DirDocument>? Documents { get; set; }
    }
}
