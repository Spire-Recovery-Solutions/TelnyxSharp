using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.RegulatoryRequirements
{
    /// <summary>
    /// Represents a request for retrieving regulatory requirements for a phone number.
    /// This request filters the requirements based on the specified phone number.
    /// </summary>
    public class ListRegulatoryRequirementsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the phone number to check regulatory requirements for.
        /// The phone number is required to filter the regulatory requirements associated with it.
        /// </summary>
        public required string PhoneNumber { get; set; }
    }
}