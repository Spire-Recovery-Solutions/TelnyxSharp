using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.Requirements
{
    /// <summary>
    /// Represents a request to list requirements for phone number operations.
    /// This includes filtering options based on country, phone number type, action type, and sorting preferences.
    /// </summary>
    public class ListRequirementsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the country code for filtering the requirements.
        /// This should be a valid ISO 3166-1 alpha-2 country code (e.g., "US", "CA").
        /// </summary>
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the type of phone number for filtering the requirements.
        /// Example values might include Mobile, Landline, or Toll-Free.
        /// </summary>
        public PhoneNumberType? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the action type for filtering the requirements.
        /// Example values might include create, update, or delete.
        /// </summary>
        public RequirementActionType? Action { get; set; }

        /// <summary>
        /// Gets or sets the sorting preference for the requirements.
        /// Use <see cref="RequirementSort"/> to specify the field and order (ascending/descending) for sorting.
        /// </summary>
        public RequirementSort? Sort { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of results to return per page.
        /// If not specified, the default value determined by the API will be used.
        /// </summary>
        public int? PageSize { get; set; }
    }
}