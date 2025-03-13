using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for retrieving a list of porting phone blocks.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> where T is a list of <see cref="PortingPhoneBlock"/>.
    /// </summary>
    public class ListPortingPhoneBlocksResponse : TelnyxResponse<List<PortingPhoneBlock>>
    {
    }

    /// <summary>
    /// Represents a single porting phone block, including details about phone number ranges and associated metadata.
    /// </summary>
    public class PortingPhoneBlock
    {
        /// <summary>
        /// Gets or sets the unique identifier of the porting phone block.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the country code associated with the porting phone block.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the type of phone number (e.g., mobile, landline) associated with the porting phone block.
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the range of phone numbers associated with the porting phone block.
        /// </summary>
        [JsonPropertyName("phone_number_range")]
        public Ranges? PhoneNumberRange { get; set; }

        /// <summary>
        /// Gets or sets a list of activation ranges for the phone numbers in this block.
        /// </summary>
        [JsonPropertyName("activation_ranges")]
        public List<Ranges>? ActivationRanges { get; set; }

        /// <summary>
        /// Gets or sets the record type associated with this porting phone block (e.g., the type of data record).
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp of the porting phone block.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last update timestamp of the porting phone block.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}