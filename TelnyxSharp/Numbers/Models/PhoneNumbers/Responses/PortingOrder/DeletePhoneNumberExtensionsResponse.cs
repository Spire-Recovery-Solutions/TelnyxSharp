using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response returned when phone number extensions are deleted.
    /// Inherits from TelnyxResponse with a generic type of PhoneNumberExtensionData,
    /// indicating that the response includes data related to phone number extensions.
    /// </summary>
    public class DeletePhoneNumberExtensionsResponse : TelnyxResponse<PhoneNumberExtensionData>
    {
    }
}