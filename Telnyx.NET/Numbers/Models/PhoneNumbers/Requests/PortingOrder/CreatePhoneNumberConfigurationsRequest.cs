using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to create phone number configurations for a porting order.
    /// </summary>
    public class CreatePhoneNumberConfigurationsRequest : ITelnyxRequest
    {
        /// <summary>
        /// A list of phone number configurations associated with the porting order.
        /// </summary>
        [JsonPropertyName("phone_number_configurations")]
        public List<PhoneNumberConfigurationRequest>? PhoneNumberConfigurations { get; set; }
    }

    /// <summary>
    /// Represents the configuration details for a specific phone number in a porting order.
    /// </summary>
    public class PhoneNumberConfigurationRequest
    {
        /// <summary>
        /// The unique identifier of the porting phone number.
        /// </summary>
        [JsonPropertyName("porting_phone_number_id")]
        public string? PortingPhoneNumberId { get; set; }

        /// <summary>
        /// The identifier for the user bundle associated with the phone number.
        /// </summary>
        [JsonPropertyName("user_bundle_id")]
        public string? UserBundleId { get; set; }
    }
}