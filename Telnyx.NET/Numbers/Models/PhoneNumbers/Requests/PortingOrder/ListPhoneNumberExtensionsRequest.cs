using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to list phone number extensions associated with porting orders.
    /// It supports filtering by phone numbers, porting phone number IDs, sorting, and pagination.
    /// </summary>
    public class ListPhoneNumberExtensionsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the specific phone number to filter by.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a list of phone numbers to filter by.
        /// Allows filtering by multiple phone numbers.
        /// </summary>
        public List<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the specific porting phone number ID to filter by.
        /// </summary>
        public string? PortingPhoneNumberId { get; set; }

        /// <summary>
        /// Gets or sets a list of porting phone number IDs to filter by.
        /// Allows filtering by multiple porting phone numbers.
        /// </summary>
        public List<string>? PortingPhoneNumberIds { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the request.
        /// Determines the order in which the results are returned.
        /// </summary>
        public RequirementSort? Sort { get; set; }

        /// <summary>
        /// Gets or sets the number of phone number extensions to retrieve per page.
        /// Used for pagination, with a default value of 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}
