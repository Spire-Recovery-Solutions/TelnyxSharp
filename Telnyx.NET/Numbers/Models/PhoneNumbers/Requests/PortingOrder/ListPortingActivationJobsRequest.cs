using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to list porting activation jobs for phone numbers.
    /// This class supports pagination by specifying the number of results per page.
    /// </summary>
    public class ListPortingActivationJobsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of porting activation jobs to retrieve per page.
        /// This is used for pagination of the results.
        /// </summary>
        public int? PageSize { get; set; }
    }
}