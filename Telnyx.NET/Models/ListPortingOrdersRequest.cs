using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Request model for listing porting orders.
    /// This class is used to specify the filters and pagination options when retrieving porting orders.
    /// </summary>
    public class ListPortingOrdersRequest : PortingOrdersRequest, ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of results per page (default is 20, maximum is 250).
        /// </summary>
        public int PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets a value indicating whether to include the first 50 phone numbers in the results (default is true).
        /// </summary>
        public bool IncludePhoneNumbers { get; set; } = true;

        /// <summary>
        /// Gets or sets the porting order status to filter by (e.g., 'draft', 'in-process', etc.).
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets a list of multiple statuses to filter porting orders by.
        /// </summary>
        public List<string>? StatusList { get; set; }

        /// <summary>
        /// Gets or sets the customer reference to filter the porting orders by.
        /// </summary>
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the parent support key to filter the porting orders by.
        /// </summary>
        public string? ParentSupportKey { get; set; }

        /// <summary>
        /// Gets or sets the country code to filter porting orders by (ISO 3166-1 alpha-2 code).
        /// </summary>
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the carrier name of the old service provider to filter by.
        /// </summary>
        public string? CarrierName { get; set; }

        /// <summary>
        /// Gets or sets the porting order type to filter by (e.g., 'full' or 'partial').
        /// </summary>
        public string? PortingOrderType { get; set; }

        /// <summary>
        /// Gets or sets the entity name to filter porting orders by (e.g., company or person).
        /// </summary>
        public string? EntityName { get; set; }

        /// <summary>
        /// Gets or sets the name of the authorized person to filter porting orders by.
        /// </summary>
        public string? AuthorizedPerson { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to filter results by fast port eligibility.
        /// </summary>
        public bool? FastPortEligible { get; set; }

        /// <summary>
        /// Gets or sets the "foc_datetime_requested" filter to include porting orders with an FOC datetime later than this value.
        /// </summary>
        public DateTimeOffset? FocDatetimeRequestedAfter { get; set; }

        /// <summary>
        /// Gets or sets the "foc_datetime_requested" filter to include porting orders with an FOC datetime earlier than this value.
        /// </summary>
        public DateTimeOffset? FocDatetimeRequestedBefore { get; set; }

        /// <summary>
        /// Gets or sets the phone number to filter by, supports partial matching.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the sort order for the results. By default, the results are sorted by creation date (`created_at`).
        /// </summary>
        public string? Sort { get; set; }
    }

    /// <summary>
    /// Base class for porting orders. This class is intended to be extended for further specifications.
    /// </summary>
    public class PortingOrdersRequest
    {
    }
}