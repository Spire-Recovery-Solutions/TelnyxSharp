using TelnyxSharp.Models;

namespace TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Responses
{
    /// <summary>
    /// Represents a single-DIR response in the Branded Calling API.
    /// Returned by the create, retrieve, update, submit, and infringement-update operations,
    /// which all share the same wire shape (a DIR wrapped in a data envelope).
    /// </summary>
    public class DirResponse : TelnyxResponse<Dir>
    {
    }
}
