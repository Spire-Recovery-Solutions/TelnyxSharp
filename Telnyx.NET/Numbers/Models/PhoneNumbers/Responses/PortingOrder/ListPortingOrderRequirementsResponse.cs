using System.Text.Json.Serialization;
using Telnyx.NET.Models;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.RegulatoryRequirements;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for retrieving a list of porting order requirements.
    /// Inherits from <see cref="TelnyxResponse{T}"/> where T is a list of <see cref="ListPortingOrderRequirementsData"/>.
    /// </summary>
    public class ListPortingOrderRequirementsResponse : TelnyxResponse<List<ListPortingOrderRequirementsData>>
    {
    }

    /// <summary>
    /// Represents a single porting order requirement, including the requirement type and its status.
    /// Inherits from <see cref="PortingRequirement"/>.
    /// </summary>
    public class ListPortingOrderRequirementsData : PortingRequirement
    {
        /// <summary>
        /// Gets or sets the type of porting requirement (e.g., documentation, approval).
        /// </summary>
        [JsonPropertyName("requirement_type")]
        public PortingRequirementType? RequirementType { get; set; }

        /// <summary>
        /// Gets or sets the status of the requirement (e.g., pending, completed).
        /// </summary>
        [JsonPropertyName("requirement_status")]
        public string? RequirementStatus { get; set; }
    }

    /// <summary>
    /// Represents the type of a porting requirement, including criteria, description, and example.
    /// </summary>
    public class PortingRequirementType
    {
        /// <summary>
        /// Gets or sets the acceptance criteria associated with this requirement.
        /// </summary>
        [JsonPropertyName("acceptance_criteria")]
        public AcceptanceCriteria? AcceptanceCriteria { get; set; }

        /// <summary>
        /// Gets or sets the description of the requirement type.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets an example related to the requirement type.
        /// </summary>
        [JsonPropertyName("example")]
        public string? Example { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the requirement type.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the requirement type.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the requirement (e.g., validation, approval).
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}