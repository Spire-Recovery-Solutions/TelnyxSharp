using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for verifying porting order verification codes.
    /// Inherits from <see cref="TelnyxResponse{List{VerificationCode}}"/> 
    /// which includes a list of verification codes related to the porting order.
    /// </summary>
    public class VerifyCodesResponse : TelnyxResponse<List<VerificationCode>>
    {
    }
}
