using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response returned when a porting phone block is deleted.
    /// Inherits from TelnyxResponse with a generic parameter of PortingPhoneBlock,
    /// indicating that the response will include the deleted phone block's data.
    /// </summary>
    public class DeletePortingPhoneBlockResponse : TelnyxResponse<PortingPhoneBlock>
    {
    }
}