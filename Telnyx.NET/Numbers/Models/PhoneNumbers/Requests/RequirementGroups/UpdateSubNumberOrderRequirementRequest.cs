using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.RequirementGroups
{
    /// <summary>
    /// Represents a request to update a sub-number order requirement by specifying a requirement group ID.
    /// </summary>
    public class UpdateSubNumberOrderRequirementRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier for the requirement group.
        /// This property is required to associate the update with a specific requirement group.
        /// </summary>
        [JsonPropertyName("requirement_group_id")]
        public required string RequirementGroupId { get; set; }
    }
}