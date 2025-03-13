using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Represents the response for listing comments related to a phone number order.
    /// Inherits from the TelnyxResponse class and encapsulates a list of CommentData objects.
    /// </summary>
    public class ListCommentsResponse : TelnyxResponse<List<CommentData>>
    {
    }
}
