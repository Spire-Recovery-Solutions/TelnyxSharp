using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for listing phone number extensions in a porting order.
    /// Inherits from <see cref="TelnyxResponse{T}"/> with a generic type of <see cref="List{PhoneNumberExtensionData}"/>.
    /// </summary>
    public class ListPhoneNumberExtensionsResponse : TelnyxResponse<List<PhoneNumberExtensionData>>
    {
        // This class doesn't have additional properties or methods; it serves as a response type for phone number extensions.
    }

    /// <summary>
    /// Represents the details of a phone number extension within a porting order.
    /// </summary>
    public class PhoneNumberExtensionData
    {
        /// <summary>
        /// Gets or sets the ID of the phone number extension.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the porting phone number ID associated with the extension.
        /// </summary>
        [JsonPropertyName("porting_phone_number_id")]
        public string? PortingPhoneNumberId { get; set; }

        /// <summary>
        /// Gets or sets the range of the extension.
        /// </summary>
        [JsonPropertyName("extension_range")]
        public Ranges? ExtensionRange { get; set; }

        /// <summary>
        /// Gets or sets the activation ranges for the extension.
        /// </summary>
        [JsonPropertyName("activation_ranges")]
        public List<Ranges>? ActivationRanges { get; set; }

        /// <summary>
        /// Gets or sets the record type for the extension.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp for the extension.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last updated timestamp for the extension.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents a range of values, used for the extension range and activation ranges.
    /// </summary>
    public class Ranges
    {
        /// <summary>
        /// Gets or sets the start value of the range.
        /// </summary>
        [JsonPropertyName("start_at")]
        public int? StartAt { get; set; }

        /// <summary>
        /// Gets or sets the end value of the range.
        /// </summary>
        [JsonPropertyName("end_at")]
        public int? EndAt { get; set; }
    }
}