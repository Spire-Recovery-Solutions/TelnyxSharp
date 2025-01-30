using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.ChannelZones.Requests
{
    /// <summary>
    /// Represents a request to retrieve a paginated list of phone numbers for a specific channel zone.
    /// </summary>
    public class GetChannelZonePhoneNumbersRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of records to return per page.
        /// Default value is 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}