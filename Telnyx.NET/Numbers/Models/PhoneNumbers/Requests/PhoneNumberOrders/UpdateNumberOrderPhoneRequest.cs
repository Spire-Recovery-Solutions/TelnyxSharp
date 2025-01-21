using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using System.Collections.Generic;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders
{
    /// <summary>
    /// Represents a request to update a phone number order with specific regulatory requirements.
    /// </summary>
    public class UpdateNumberOrderPhoneRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of regulatory requirements to be updated for the phone number order.
        /// </summary>
        /// <remarks>
        /// Each regulatory requirement in the list specifies details necessary to comply with 
        /// regulations for the given phone number.
        /// </remarks>
        [JsonPropertyName("regulatory_requirements")]
        public List<UpdateRegulatoryRequirement>? RegulatoryRequirements { get; set; }
    }
}