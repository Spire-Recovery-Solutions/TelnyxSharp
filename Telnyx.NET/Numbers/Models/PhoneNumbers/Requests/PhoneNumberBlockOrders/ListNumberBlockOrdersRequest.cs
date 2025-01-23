using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberBlockOrders
{
    /// <summary>
    /// Represents a request to list phone number block orders.
    /// This request supports filtering, pagination, and sorting to narrow down results based on specific criteria.
    /// </summary>
    public class ListNumberBlockOrdersRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the status filter for the block orders.
        /// Optional: Filters block orders based on their current status (e.g., "pending", "completed").
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the filter for block orders created after the specified date and time.
        /// Optional: Allows narrowing results to orders created after this timestamp.
        /// </summary>
        public DateTimeOffset? CreatedAfter { get; set; }

        /// <summary>
        /// Gets or sets the filter for block orders created before the specified date and time.
        /// Optional: Allows narrowing results to orders created before this timestamp.
        /// </summary>
        public DateTimeOffset? CreatedBefore { get; set; }

        /// <summary>
        /// Gets or sets the filter for block orders based on the starting phone number.
        /// Optional: Filters results to include orders with the specified starting number.
        /// </summary>
        public string? StartingNumber { get; set; }

        /// <summary>
        /// Gets or sets the number of results per page for paginated results.
        /// Optional: Defaults to 20. Specifies the maximum number of results to retrieve per page.
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}
