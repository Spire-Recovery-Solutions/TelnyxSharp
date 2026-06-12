using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.ReferenceData.Requests
{
    /// <summary>
    /// Represents a request for listing the pre-vetted call-reason library.
    /// </summary>
    public class ListCallReasonsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of items per page (default 50, maximum 250).
        /// </summary>
        public int? PageSize { get; set; }
    }
}
