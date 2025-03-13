using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlockOrders
{
    /// <summary>
    /// Represents the response for retrieving a specific number block order.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> and contains a single <see cref="NumberBlockOrder"/> object.
    /// </summary>
    public class GetNumberBlockOrderResponse : TelnyxResponse<NumberBlockOrder>
    {
    }
}
