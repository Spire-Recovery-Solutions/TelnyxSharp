using TelnyxSharp.Models;

namespace TelnyxSharp.BrandedCalling.Models.Enterprises.Responses
{
    /// <summary>
    /// Represents a single-enterprise response in the Branded Calling API.
    /// Returned by the create, retrieve, update, and Branded Calling activation operations,
    /// which all share the same wire shape (an enterprise wrapped in a data envelope).
    /// </summary>
    public class EnterpriseResponse : TelnyxResponse<Enterprise>
    {
    }
}
