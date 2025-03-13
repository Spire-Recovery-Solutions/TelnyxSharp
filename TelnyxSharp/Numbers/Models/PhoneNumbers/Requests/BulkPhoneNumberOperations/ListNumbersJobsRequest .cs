using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.BulkPhoneNumberOperations
{
    /// <summary>
    /// Represents a request to list jobs related to bulk phone number operations.
    /// This allows for filtering, pagination, and sorting of job records.
    /// </summary>
    public class ListNumbersJobsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the filter for job types.
        /// Specifies the type of phone number job to retrieve (e.g., deletion, addition, update).
        /// </summary>
        public PhoneNumberJobType? Type { get; set; }

        /// <summary>
        /// Gets or sets the number of records to include in each page of results.
        /// Default value is 20. Adjust for larger or smaller pagination.
        /// </summary>
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets the sorting parameter for the results.
        /// Default value is "created_at". Can be adjusted to other sortable fields as needed.
        /// </summary>
        public string Sort { get; set; } = "created_at";
    }
}