using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberSearch
{
    /// <summary>
    /// Represents the response for a request to retrieve available phone number blocks.
    /// Contains the main data and metadata related to the response.
    /// </summary>
    public class ListAvailablePhoneNumberBlocksResponse : TelnyxResponse<ListAvailablePhoneNumberBlocksData>
    {
        /// <summary>
        /// Gets or sets the metadata associated with the response.
        /// Metadata includes additional information such as total results, pagination details, etc.
        /// </summary>
        [JsonPropertyName("meta")]
        public new AvailablePhoneNumbersMeta? Meta { get; set; }
    }

    /// <summary>
    /// Represents the data structure for a single phone number block in the response.
    /// Includes detailed information about the block's properties, costs, and features.
    /// </summary>
    public class ListAvailablePhoneNumberBlocksData
    {
        /// <summary>
        /// Gets or sets the type of record for the phone number block.
        /// This specifies the category or classification of the record (e.g., "phone_number_block").
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the starting phone number in the block.
        /// This represents the first number in the block's range.
        /// </summary>
        [JsonPropertyName("starting_number")]
        public string? StartingNumber { get; set; }

        /// <summary>
        /// Gets or sets the range of phone numbers in the block.
        /// This specifies the total number of phone numbers available in the block.
        /// </summary>
        [JsonPropertyName("range")]
        public int Range { get; set; }

        /// <summary>
        /// Gets or sets the region information associated with the phone number block.
        /// Includes details about the geographic area covered by the block.
        /// </summary>
        [JsonPropertyName("region_information")]
        public List<RegionInformation>? RegionInformation { get; set; }

        /// <summary>
        /// Gets or sets the cost information for the phone number block.
        /// Includes details about upfront and monthly costs, as well as the currency used.
        /// </summary>
        [JsonPropertyName("cost_information")]
        public CostInformation? CostInformation { get; set; }

        /// <summary>
        /// Gets or sets the features available for the phone number block.
        /// This includes capabilities like SMS, voice, and other features.
        /// </summary>
        [JsonPropertyName("features")]
        public List<Feature>? Features { get; set; }
    }
}