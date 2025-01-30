using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.RequirementGroups
{
    /// <summary>
    /// Represents a request to update a phone number order requirement.
    /// This includes the identifier for the requirement group that needs to be updated.
    /// </summary>
    public class UpdatePhoneNumberOrderRequirementRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier of the requirement group to be updated.
        /// This value is required and must be provided in the request.
        /// </summary>
        [JsonPropertyName("requirement_group_id")]
        public required string RequirementGroupId { get; set; }
    }
}