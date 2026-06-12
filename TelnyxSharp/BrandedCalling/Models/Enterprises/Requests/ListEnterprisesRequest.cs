using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.Enterprises.Requests
{
    /// <summary>
    /// Represents a request for listing enterprises in the Branded Calling API.
    /// </summary>
    public class ListEnterprisesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of items per page (default 50, maximum 250).
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets a case-insensitive partial match filter on the enterprise legal name.
        /// </summary>
        public string? LegalName { get; set; }
    }
}
