using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.ChannelZones.Requests
{
    /// <summary>
    /// Represents a request to retrieve a paginated list of channel zones.
    /// </summary>
    public class ListChannelZonesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of records to return per page.
        /// Default value is 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}