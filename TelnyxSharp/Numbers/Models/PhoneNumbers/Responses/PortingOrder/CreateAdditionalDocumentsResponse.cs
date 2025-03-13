using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response returned when creating additional documents for a porting order.
    /// Inherits from TelnyxResponse and contains a list of AdditionalDocument objects.
    /// </summary>
    public class CreateAdditionalDocumentsResponse : TelnyxResponse<List<AdditionalDocument>>
    {
    }
}