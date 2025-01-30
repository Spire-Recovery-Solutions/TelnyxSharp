using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using System.Collections.Generic;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders
{
    /// <summary>
    /// Represents a request to update a sub-number order with specific regulatory requirements.
    /// </summary>
    public class UpdateSubNumberOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of regulatory requirements to be updated for the sub-number order.
        /// </summary>
        /// <remarks>
        /// Each regulatory requirement in the list specifies the compliance information 
        /// necessary for processing the sub-number order.
        /// </remarks>
        [JsonPropertyName("regulatory_requirements")]
        public List<UpdateRegulatoryRequirement>? RegulatoryRequirements { get; set; }
    }

    /// <summary>
    /// Represents a regulatory requirement to be updated in a sub-number order.
    /// </summary>
    public class UpdateRegulatoryRequirement
    {
        /// <summary>
        /// Gets or sets the unique identifier for the regulatory requirement.
        /// </summary>
        /// <remarks>
        /// The <c>RequirementId</c> corresponds to the specific regulation being addressed.
        /// </remarks>
        [JsonPropertyName("requirement_id")]
        public string? RequirementId { get; set; }

        /// <summary>
        /// Gets or sets the value for the regulatory field being updated.
        /// </summary>
        /// <remarks>
        /// The <c>FieldValue</c> provides the required data to meet the regulatory requirement.
        /// </remarks>
        [JsonPropertyName("field_value")]
        public string? FieldValue { get; set; }
    }
}