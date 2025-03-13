using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for listing porting comments in a porting order.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> with a generic type of <see cref="List{PortingComment}"/>.
    /// </summary>
    public class ListPortingCommentsResponse : TelnyxResponse<List<PortingComment>>
    {
    }
}
