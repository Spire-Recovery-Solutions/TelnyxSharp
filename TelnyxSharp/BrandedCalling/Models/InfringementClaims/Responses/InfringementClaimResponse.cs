using TelnyxSharp.Models;

namespace TelnyxSharp.BrandedCalling.Models.InfringementClaims.Responses
{
    /// <summary>
    /// Represents a single infringement-claim response in the Branded Calling API.
    /// Returned by the retrieve and contest operations, which share the same wire shape.
    /// </summary>
    public class InfringementClaimResponse : TelnyxResponse<InfringementClaim>
    {
    }
}
