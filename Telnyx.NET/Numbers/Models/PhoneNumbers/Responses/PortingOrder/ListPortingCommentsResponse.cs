using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for listing porting comments in a porting order.
    /// Inherits from <see cref="TelnyxResponse{T}"/> with a generic type of <see cref="List{PortingComment}"/>.
    /// </summary>
    public class ListPortingCommentsResponse : TelnyxResponse<List<PortingComment>>
    {
    }
}
