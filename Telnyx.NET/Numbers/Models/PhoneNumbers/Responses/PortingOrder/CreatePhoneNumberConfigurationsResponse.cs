using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response returned when creating phone number configurations for a porting order.
    /// Inherits from TelnyxResponse and contains a list of PhoneNumberConfiguration objects.
    /// </summary>
    public class CreatePhoneNumberConfigurationsResponse : TelnyxResponse<List<PhoneNumberConfiguration>>
    {
    }

    /// <summary>
    /// Represents the configuration details of a phone number within a porting order.
    /// </summary>
    public class PhoneNumberConfiguration
    {
        /// <summary>
        /// Gets or sets the unique identifier for the phone number configuration.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the user bundle identifier associated with the phone number configuration.
        /// </summary>
        [JsonPropertyName("user_bundle_id")]
        public string? UserBundleId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the porting phone number associated with the configuration.
        /// </summary>
        [JsonPropertyName("porting_phone_number_id")]
        public string? PortingPhoneNumberId { get; set; }

        /// <summary>
        /// Gets or sets the type of the record (e.g., "new", "existing").
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp of the phone number configuration.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last updated timestamp of the phone number configuration.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}