using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders
{
    /// <summary>
    /// Represents the request parameters for listing sub-number orders.
    /// Used to filter and retrieve specific sub-number orders.
    /// </summary>
    public class ListSubNumberOrdersRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the status of the sub-number order.
        /// Possible values: [pending, success, failure].
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the unique ID of the order request.
        /// This is used to filter sub-number orders related to a specific order request.
        /// </summary>
        public string? OrderRequestId { get; set; }

        /// <summary>
        /// Gets or sets the country code of the phone numbers in the sub-number order.
        /// Filters orders based on the country code of the phone numbers.
        /// </summary>
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the type of phone numbers in the sub-number order.
        /// Possible values: [local, mobile, national, shared_cost, toll_free].
        /// </summary>
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the count of phone numbers in the sub-number order.
        /// Filters orders based on the number of phone numbers requested in the order.
        /// </summary>
        public int? PhoneNumbersCount { get; set; }
    }
}