using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.InfringementClaims.Requests
{
    /// <summary>
    /// Represents a request for listing the infringement claims filed against a Display Identity Record (DIR).
    /// </summary>
    public class ListInfringementClaimsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of items per page (default 50, maximum 250).
        /// </summary>
        public int? PageSize { get; set; }
    }
}
