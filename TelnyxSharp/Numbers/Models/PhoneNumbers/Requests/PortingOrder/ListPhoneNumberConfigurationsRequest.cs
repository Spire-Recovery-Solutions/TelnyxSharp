using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to list phone number configurations for porting orders.
    /// It allows filtering by various criteria such as porting order IDs, statuses, and phone number IDs,
    /// as well as pagination and sorting.
    /// </summary>
    public class ListPhoneNumberConfigurationsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of phone number configurations to retrieve per page.
        /// Used for pagination, with a default value of 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets the specific porting order ID to filter by.
        /// </summary>
        public string? PortingOrderId { get; set; }

        /// <summary>
        /// Gets or sets a list of porting order IDs to filter by.
        /// Allows filtering by multiple porting orders.
        /// </summary>
        public List<string>? PortingOrderIds { get; set; }

        /// <summary>
        /// Gets or sets the status of the porting order to filter by.
        /// </summary>
        public PortingOrderStatus? PortingOrderStatus { get; set; }

        /// <summary>
        /// Gets or sets a list of porting order statuses to filter by.
        /// Allows filtering by multiple statuses.
        /// </summary>
        public List<PortingOrderStatus>? PortingOrderStatuses { get; set; }

        /// <summary>
        /// Gets or sets the specific porting phone number ID to filter by.
        /// </summary>
        public string? PortingPhoneNumberId { get; set; }

        /// <summary>
        /// Gets or sets a list of porting phone number IDs to filter by.
        /// Allows filtering by multiple phone numbers.
        /// </summary>
        public List<string>? PortingPhoneNumberIds { get; set; }

        /// <summary>
        /// Gets or sets the user bundle ID to filter by.
        /// </summary>
        public string? UserBundleId { get; set; }

        /// <summary>
        /// Gets or sets a list of user bundle IDs to filter by.
        /// Allows filtering by multiple user bundles.
        /// </summary>
        public List<string>? UserBundleIds { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the request.
        /// Determines the order in which the results are returned.
        /// </summary>
        public RequirementTypeSort? Sort { get; set; }
    }
}