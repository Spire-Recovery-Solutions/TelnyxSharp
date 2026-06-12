using TelnyxSharp.Models;

namespace TelnyxSharp.BrandedCalling.Models.InfringementClaims.Responses
{
    /// <summary>
    /// Represents the paginated response for listing the infringement claims filed against a DIR.
    /// </summary>
    public class ListInfringementClaimsResponse : TelnyxResponse<List<InfringementClaim>>
    {
    }
}
