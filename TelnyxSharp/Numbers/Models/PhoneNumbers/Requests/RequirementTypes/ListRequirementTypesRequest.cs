using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.RequirementTypes
{
    /// <summary>
    /// Represents a request to list requirement types for phone numbers in the Telnyx API.
    /// Allows filtering by name and sorting by a specific field.
    /// </summary>
    public class ListRequirementTypesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the partial name to filter the requirement types.
        /// Only requirement types whose names contain this value will be included in the response.
        /// </summary>
        public string? NameContains { get; set; }

        /// <summary>
        /// Gets or sets the sort order for the requirement types.
        /// Specifies how the requirement types should be sorted in the response.
        /// </summary>
        public RequirementTypeSort? Sort { get; set; }
    }
}