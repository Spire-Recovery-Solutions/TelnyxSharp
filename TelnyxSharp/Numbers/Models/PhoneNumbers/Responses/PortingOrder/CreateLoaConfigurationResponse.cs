using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response returned when creating an LOA (Letter of Authorization) configuration for a porting order.
    /// Inherits from TelnyxResponse and contains an LoaConfiguration object.
    /// </summary>
    public class CreateLoaConfigurationResponse : TelnyxResponse<LoaConfiguration>
    {
    }
}