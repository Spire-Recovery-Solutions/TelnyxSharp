using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Request model for listing porting phone numbers.
    /// This class is used to specify filters and pagination options when retrieving porting phone numbers associated with porting orders.
    /// </summary>
    public class ListPortingPhoneNumbersRequest : PortingOrdersRequest, ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of results per page (default is 20, maximum is 250).
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets the porting order ID to filter by.
        /// </summary>
        public string? PortingOrderId { get; set; }

        /// <summary>
        /// Gets or sets a list of porting order IDs to filter by.
        /// </summary>
        public List<string>? PortingOrderIds { get; set; }

        /// <summary>
        /// Gets or sets the support key to filter by (exact match).
        /// </summary>
        public string? SupportKeyEq { get; set; }

        /// <summary>
        /// Gets or sets a list of support keys to filter by (inclusion).
        /// </summary>
        public List<string>? SupportKeyIn { get; set; }

        /// <summary>
        /// Gets or sets the phone number to filter porting phone numbers by (supports partial matching).
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a list of phone numbers to filter porting phone numbers by.
        /// </summary>
        public List<string>? PhoneNumberIn { get; set; }

        /// <summary>
        /// Gets or sets the porting order status to filter by (e.g., 'draft', 'in-process', etc.).
        /// </summary>
        public string? PortingOrderStatus { get; set; }

        /// <summary>
        /// Gets or sets the activation status of the porting phone numbers to filter by.
        /// </summary>
        public string? ActivationStatus { get; set; }

        /// <summary>
        /// Gets or sets the portability status of the porting phone numbers to filter by.
        /// </summary>
        public string? PortabilityStatus { get; set; }
    }
}