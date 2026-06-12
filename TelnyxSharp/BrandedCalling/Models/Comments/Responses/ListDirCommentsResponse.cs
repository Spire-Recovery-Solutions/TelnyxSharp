using TelnyxSharp.Models;

namespace TelnyxSharp.BrandedCalling.Models.Comments.Responses
{
    /// <summary>
    /// Represents the paginated response for listing the customer-visible comments on a DIR.
    /// </summary>
    public class ListDirCommentsResponse : TelnyxResponse<List<DirComment>>
    {
    }
}
