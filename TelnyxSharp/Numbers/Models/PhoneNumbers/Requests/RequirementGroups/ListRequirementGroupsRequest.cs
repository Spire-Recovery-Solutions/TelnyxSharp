using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.RequirementGroups
{
    /// <summary>
    /// Represents a request to list requirement groups for phone numbers.
    /// This includes optional filters such as country code, phone number type, action, status, and customer reference.
    /// </summary>
    public class ListRequirementGroupsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the country code filter for the requirement groups.
        /// Example: "US" for the United States.
        /// </summary>
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the phone number type filter for the requirement groups.
        /// Example: Geographic, TollFree, etc.
        /// </summary>
        public PhoneNumberType? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the action type filter for the requirement groups.
        /// Example: Provisioning or other valid actions.
        /// </summary>
        public RequirementActionType? Action { get; set; }

        /// <summary>
        /// Gets or sets the status filter for the requirement groups.
        /// Example: Pending, Completed, or other valid statuses.
        /// </summary>
        public RequirementStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the customer reference filter for the requirement groups.
        /// This is used to match requirement groups associated with a specific customer reference.
        /// Example: "Customer12345".
        /// </summary>
        public string? CustomerReference { get; set; }
    }
}