using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.InventoryLevel
{
    /// <summary>
    /// Represents the response for an inventory coverage request.
    /// Inherits from <see cref="TelnyxResponse{T}"/> to encapsulate the response data.
    /// </summary>
    public class InventoryCoverageResponse : TelnyxResponse<List<InventoryCoverageData>>
    {
    }

    /// <summary>
    /// Represents the detailed data for inventory coverage, including group information, number types, and coverage details.
    /// </summary>
    public class InventoryCoverageData
    {
        /// <summary>
        /// Gets or sets the group associated with the inventory coverage, such as a locality or NPA.
        /// Optional.
        /// </summary>
        [JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        /// Gets or sets the type of the group, which indicates the grouping criteria (e.g., locality, NPA).
        /// Optional.
        /// </summary>
        [JsonPropertyName("group_type")]
        public string? GroupType { get; set; }

        /// <summary>
        /// Gets or sets the range of numbers available in the group.
        /// Optional.
        /// </summary>
        [JsonPropertyName("number_range")]
        public int? NumberRange { get; set; }

        /// <summary>
        /// Gets or sets the type of numbers in the inventory (e.g., local, toll-free).
        /// Optional.
        /// </summary>
        [JsonPropertyName("number_type")]
        public string? NumberType { get; set; }

        /// <summary>
        /// Gets or sets the phone number type for the inventory (e.g., SMS, voice).
        /// Optional.
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the type of coverage provided (e.g., geographic or feature-based).
        /// Optional.
        /// </summary>
        [JsonPropertyName("coverage_type")]
        public string? CoverageType { get; set; }

        /// <summary>
        /// Gets or sets the record type associated with the inventory data.
        /// Optional.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the administrative area (e.g., state, province) associated with the inventory.
        /// Optional.
        /// </summary>
        [JsonPropertyName("administrative_area")]
        public string? AdministrativeArea { get; set; }

        /// <summary>
        /// Gets or sets the count of phone numbers in the inventory.
        /// Optional.
        /// </summary>
        [JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether advance requirements apply for obtaining the inventory.
        /// Optional.
        /// </summary>
        [JsonPropertyName("advance_requirements")]
        public bool? AdvanceRequirements { get; set; }
    }
}