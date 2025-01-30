using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Represents the response for retrieving a specific comment associated with a phone number order.
    /// </summary>
    /// <remarks>
    /// This class extends <see cref="TelnyxResponse{T}"/> to include the details of a comment,
    /// encapsulated within a <see cref="CommentData"/> object.
    /// </remarks>
    public class GetCommentResponse : TelnyxResponse<CommentData>
    {
    }
}
