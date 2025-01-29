using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for listing phone number configurations in a porting order.
    /// Inherits from <see cref="TelnyxResponse{T}"/> with a generic type of <see cref="List{PhoneNumberConfiguration}"/>.
    /// </summary>
    public class ListPhoneNumberConfigurationsResponse : TelnyxResponse<List<PhoneNumberConfiguration>>
    {
    }
}