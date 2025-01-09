using Telnyx.NET.Base;

namespace Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests
{
    /// <summary>
    /// Request model for listing number orders.
    /// This class is used to specify the filters and pagination options when retrieving number orders.
    /// </summary>
    public class ListNumberOrdersRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the status of the number orders to filter by (e.g., pending, completed).
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the timestamp to filter orders created after this time.
        /// The format should be a string representation of the date/time.
        /// </summary>
        public string? CreatedAfter { get; set; }

        /// <summary>
        /// Gets or sets the timestamp to filter orders created before this time.
        /// The format should be a string representation of the date/time.
        /// </summary>
        public string? CreatedBefore { get; set; }

        /// <summary>
        /// Gets or sets the number of phone numbers associated with the orders to filter by.
        /// </summary>
        public int? PhoneNumberCount { get; set; }

        /// <summary>
        /// Gets or sets a reference identifier for the customer to filter by.
        /// </summary>
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets whether the requirements for the phone numbers in the orders must be met.
        /// </summary>
        public bool? RequirementsMet { get; set; }

        /// <summary>
        /// Gets or sets the number of results to return per page for pagination.
        /// </summary>
        public int? PageSize { get; set; }
    }
}