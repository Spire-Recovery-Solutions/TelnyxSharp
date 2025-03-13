using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for listing phone number configurations in a porting order.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> with a generic type of <see cref="List{PhoneNumberConfiguration}"/>.
    /// </summary>
    public class ListPhoneNumberConfigurationsResponse : TelnyxResponse<List<PhoneNumberConfiguration>>
    {
    }
}