using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlockOrders
{
    /// <summary>
    /// Represents the response for creating a new number block order.
    /// Inherits from <see cref="TelnyxResponse{T}"/> and contains the created <see cref="NumberBlockOrder"/> object.
    /// </summary>
    public class CreateNumberBlockOrderResponse : TelnyxResponse<NumberBlockOrder>
    {
    }
}
