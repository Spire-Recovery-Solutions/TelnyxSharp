using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlockOrders
{
    /// <summary>
    /// Represents the response for retrieving a specific number block order.
    /// Inherits from <see cref="TelnyxResponse{T}"/> and contains a single <see cref="NumberBlockOrder"/> object.
    /// </summary>
    public class GetNumberBlockOrderResponse : TelnyxResponse<NumberBlockOrder>
    {
    }
}
