using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.RequirementGroups
{
    /// <summary>
    /// Represents a request to update a requirement group.
    /// This includes optional customer reference and regulatory requirements.
    /// </summary>
    public class UpdateRequirementGroupRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets an optional customer reference string.
        /// This can be used to associate the requirement group with a specific customer.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets a list of regulatory requirements to be updated.
        /// Each item in the list represents a regulatory requirement associated with the requirement group.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<UpdateRegulatoryRequirement>? RegulatoryRequirements { get; set; }
    }
}