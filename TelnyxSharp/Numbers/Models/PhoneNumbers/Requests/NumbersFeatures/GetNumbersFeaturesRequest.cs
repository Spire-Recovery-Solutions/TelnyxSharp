using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.NumbersFeatures
{
    /// <summary>
    /// Represents a request to retrieve features associated with a list of phone numbers.
    /// </summary>
    public class GetNumbersFeaturesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of phone numbers for which features should be retrieved.
        /// </summary>
        /// <remarks>
        /// This property is required and must contain valid phone numbers in E.164 format.
        /// </remarks>
        [JsonPropertyName("phone_numbers")]
        public required List<string> PhoneNumbers { get; set; }
    }
}