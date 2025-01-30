using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response returned when cancelling a porting order.
    /// Inherits from TelnyxResponse and contains a PortingOrder object with details of the cancelled porting order.
    /// </summary>
    public class CancelPortingOrderResponse : TelnyxResponse<PortingOrder>
    {
    }
}