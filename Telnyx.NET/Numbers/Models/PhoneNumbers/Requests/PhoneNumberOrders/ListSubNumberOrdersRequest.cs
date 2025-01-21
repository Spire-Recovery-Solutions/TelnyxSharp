using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders
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
        [JsonPropertyName("filter[status]")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the unique ID of the order request.
        /// This is used to filter sub-number orders related to a specific order request.
        /// </summary>
        [JsonPropertyName("filter[order_request_id]")]
        public string? OrderRequestId { get; set; }

        /// <summary>
        /// Gets or sets the country code of the phone numbers in the sub-number order.
        /// Filters orders based on the country code of the phone numbers.
        /// </summary>
        [JsonPropertyName("filter[country_code]")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the type of phone numbers in the sub-number order.
        /// Possible values: [local, mobile, national, shared_cost, toll_free].
        /// </summary>
        [JsonPropertyName("filter[phone_number_type]")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the count of phone numbers in the sub-number order.
        /// Filters orders based on the number of phone numbers requested in the order.
        /// </summary>
        [JsonPropertyName("filter[phone_numbers_count]")]
        public int? PhoneNumbersCount { get; set; }
    }
}