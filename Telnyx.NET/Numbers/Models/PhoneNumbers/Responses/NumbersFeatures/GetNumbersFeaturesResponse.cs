using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.NumbersFeatures
{
    /// <summary>
    /// Represents the response for retrieving features associated with a phone number.
    /// </summary>
    public class GetNumbersFeaturesResponse : TelnyxResponse<NumberFeature>
    {
    }

    /// <summary>
    /// Represents the details of a phone number and its associated features.
    /// </summary>
    public class NumberFeature
    {
        /// <summary>
        /// Gets or sets the phone number for which the features are listed.
        /// </summary>
        /// <remarks>
        /// The phone number is expected to be in E.164 format (e.g., "+1234567890").
        /// </remarks>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the list of features associated with the phone number.
        /// </summary>
        /// <remarks>
        /// Features represent capabilities or services enabled for the phone number, such as "sms", "voice", or "mms".
        /// </remarks>
        [JsonPropertyName("features")]
        public List<string> Features { get; set; } = new();
    }
}