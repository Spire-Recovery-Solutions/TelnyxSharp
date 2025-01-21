using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders
{
    /// <summary>
    /// Represents a request to update an existing phone number order.
    /// </summary>
    public class UpdateNumberOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of regulatory requirements for the phone number order.
        /// </summary>
        /// <value>
        /// A list of <see cref="UpdateNumberOrderRegulatoryRequirement"/> objects that represent the regulatory requirements.
        /// </value>
        [JsonPropertyName("regulatory_requirements")]
        public List<UpdateNumberOrderRegulatoryRequirement>? RegulatoryRequirements { get; set; }

        /// <summary>
        /// Gets or sets the customer reference for the phone number order.
        /// </summary>
        /// <value>
        /// A string representing the customer reference for the order.
        /// </value>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }
    }

    /// <summary>
    /// Represents a regulatory requirement for updating a phone number order.
    /// </summary>
    public class UpdateNumberOrderRegulatoryRequirement
    {
        /// <summary>
        /// Gets or sets the unique identifier for the regulatory requirement.
        /// </summary>
        /// <value>
        /// A string representing the unique identifier of the regulatory requirement.
        /// </value>
        [JsonPropertyName("requirement_id")]
        public string? RequirementId { get; set; }

        /// <summary>
        /// Gets or sets the value for the regulatory requirement field.
        /// </summary>
        /// <value>
        /// A string representing the value of the regulatory requirement field.
        /// </value>
        [JsonPropertyName("field_value")]
        public string? FieldValue { get; set; }
    }
}