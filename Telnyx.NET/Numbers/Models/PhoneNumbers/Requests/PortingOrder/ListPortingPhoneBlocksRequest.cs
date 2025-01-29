using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to list phone blocks associated with porting orders.
    /// This class allows filtering by phone number, sorting by a specified order, and pagination.
    /// </summary>
    public class ListPortingPhoneBlocksRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets a specific phone number to filter the phone blocks by.
        /// This allows fetching phone blocks associated with a single phone number.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a list of phone numbers to filter the phone blocks by.
        /// This allows fetching phone blocks associated with multiple phone numbers.
        /// </summary>
        public List<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the phone blocks.
        /// The sorting can be controlled based on the specified requirement sorting criteria.
        /// </summary>
        public RequirementSort? Sort { get; set; }

        /// <summary>
        /// Gets or sets the number of phone blocks to retrieve per page.
        /// This is used for pagination, allowing the user to limit the number of results per API call.
        /// </summary>
        public int? PageSize { get; set; }
    }
}