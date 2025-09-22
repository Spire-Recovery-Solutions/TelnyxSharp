using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Response model for listing number orders.
    /// Contains a list of number orders with minimal phone number information.
    /// </summary>
    public class ListNumberOrdersResponse : TelnyxResponse<List<NumberOrderListData>>
    {
    }
}