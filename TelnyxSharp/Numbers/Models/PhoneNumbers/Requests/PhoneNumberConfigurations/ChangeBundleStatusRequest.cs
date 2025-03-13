using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations
{
    /// <summary>
    /// Represents a request to change the bundle status of a phone number.
    /// </summary>
    public class ChangeBundleStatusRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the ID of the bundle to be updated.
        /// </summary>
        /// <remarks>
        /// This property is required and must be a valid bundle ID.
        /// </remarks>
        [JsonPropertyName("bundle_id")]
        public required string BundleId { get; set; }
    }
}