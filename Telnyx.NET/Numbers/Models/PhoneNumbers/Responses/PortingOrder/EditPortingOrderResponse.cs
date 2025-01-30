using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response when editing a porting order.
    /// Inherits from TelnyxResponse and includes a list of PortingOrder objects.
    /// </summary>
    public class EditPortingOrderResponse : TelnyxResponse<List<PortingOrder>>
    {
    }
}