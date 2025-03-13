using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlockOrders
{
    /// <summary>
    /// Represents the response for creating a new number block order.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> and contains the created <see cref="NumberBlockOrder"/> object.
    /// </summary>
    public class CreateNumberBlockOrderResponse : TelnyxResponse<NumberBlockOrder>
    {
    }
}
