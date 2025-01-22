using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.BulkPhoneNumberOperations
{
    /// <summary>
    /// Represents a request to delete multiple phone numbers in a batch operation.
    /// This is useful for efficiently managing and removing phone numbers in bulk.
    /// </summary>
    public class DeleteNumbersBatchRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of phone numbers to be deleted.
        /// The phone numbers should be in E.164 format (e.g., "+1234567890").
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public required string[]? PhoneNumbers { get; set; }
    }
}